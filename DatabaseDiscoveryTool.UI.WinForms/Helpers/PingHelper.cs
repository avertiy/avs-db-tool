using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using DatabaseDiscoveryTool.UI.WinForms.Utils;

namespace DatabaseDiscoveryTool.UI.WinForms.Helpers
{
    public class PingHelper
    {
        public static string PingSqlServer(string connectionString)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                Stopwatch t = new Stopwatch();
                t.Start();
                using (var connection = new SqlConnection(connectionString))
                {
                    sb.AppendFormat("{0:MM-dd hh:mm:ss}  - connecting to: {1}, DB: {2}", DateTime.Now, connection.DataSource, connection.Database);

                    var query = "select 1";
                    var command = new SqlCommand(query, connection);
                    connection.Open();
                    sb.AppendLine("SQL Connection SUCCESSFULL.");
                    sb.AppendFormat("Executing: {0}", query);
                    sb.AppendLine();
                    command.ExecuteScalar();
                    sb.AppendLine("SQL Query execution SUCCESSFULL.");
                }
                t.Stop();
                sb.AppendLine();
                sb.AppendFormat("Elapsed time: {0} ms", t.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                sb.AppendFormat("FAILURE: {0}", ex.Message);
            }
            sb.AppendLine();
            return sb.ToString();
        }
        public static CancellationTokenSource PingSqlServerTask(string connectionString, TimeSpan pollInterval, StringBuilder log)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            Repeat.Interval(pollInterval, () => { log.AppendLine(PingSqlServer(connectionString)); }, cancellationTokenSource.Token);
            return cancellationTokenSource;
        }

        public static PingOptions PingWebsiteTask(PingOptions options)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            options.StartPing();
            Repeat.Interval(options.PollInterval, options.PingWebSite, cancellationTokenSource.Token);
            options.CancellationTokenSource= cancellationTokenSource;
            return options;
        }

        


       
    }

    public class PingOptions
    {
        private readonly Stopwatch _stopwatch;
        public TimeSpan PollInterval { get; set; }

        public StringBuilder Log { get; private set; }

        public Dictionary<DateTime, bool> PingResults { get; set; }
        public Func<string, bool> TestIsAlive { get; set; }
        public CancellationTokenSource CancellationTokenSource { get; set; }
        public string Url { get; set; }

        private readonly int[] _pingDomainStats;//counter, ping - ok, ping -fails

        public PingOptions(TimeSpan pollInterval)
        {
            PollInterval = pollInterval;
            Log = new StringBuilder();
            PingResults = new Dictionary<DateTime, bool>();
            _stopwatch = new Stopwatch();
            _pingDomainStats = new int[9];
        }

        public void StartPing()
        {
            Log.AppendFormat("{0:yyyy-MMM-dd HH:mm:ss}\r\nPinging {1}:\r\n", DateTime.Now, Url);
            _pingDomainStats[0] = 0;//counter
            _pingDomainStats[1] = 0;//ping ok
            _pingDomainStats[2] = 0;//ping failed content empty
            _pingDomainStats[3] = 0;//ping failed content doesn't match
            _pingDomainStats[4] = 0;//ping failed error
            _pingDomainStats[5] = 0;//ping elapsed time too big - site cache was reseted
            _pingDomainStats[6] = 0;//min ping time
            _pingDomainStats[7] = 0;//max ping time
            _pingDomainStats[8] = 0;//avg ping time
        }

        public void PingWebSite()
        {
            _stopwatch.Restart();

            //ping domain
            try
            {
                _pingDomainStats[0]++;
                using (WebClient client = new WebClient())
                {
                    Log.AppendFormat("\r\nDownloading content from {0}: ", Url);
                    string content = client.DownloadString(Url);

                    if (string.IsNullOrEmpty(content))
                    {
                        Log.AppendFormat("content is empty.      \tPing FAILED [{0:yyyy-MMM-dd HH:mm:ss}]\r\n",DateTime.Now);
                        _pingDomainStats[2]++;
                        PingFailed();
                    }
                    if (TestIsAlive(content))
                    {
                        _pingDomainStats[1]++;
                        Log.AppendFormat("OK\r\n");
                    }
                    else
                    {
                        Log.AppendFormat("content doesn't match         \tPing FAILED [{0:yyyy-MMM-dd HH:mm:ss}]\r\n", DateTime.Now);
                        _pingDomainStats[3]++;
                        PingFailed();
                    }
                }
            }
            catch (Exception ex)
            {
                _pingDomainStats[4]++;
                Log.AppendFormat("\r\nPing FAILED due to error: {0} [{1:yyyy-MMM-dd HH:mm:ss}]\r\n", ex.Message, DateTime.Now);
                PingFailed();
            }
            _stopwatch.Stop();
            Log.AppendFormat("elapsed time: {0}ms",_stopwatch.ElapsedMilliseconds);
            if (_stopwatch.ElapsedMilliseconds > 6000)
            {
                _pingDomainStats[5]++;
            }
            if (_pingDomainStats[6] == 0 || _pingDomainStats[6] > _stopwatch.ElapsedMilliseconds)
            {
                _pingDomainStats[6] = (int) _stopwatch.ElapsedMilliseconds;
            } 
            if (_pingDomainStats[7] == 0 || _pingDomainStats[7] < _stopwatch.ElapsedMilliseconds)
            {
                _pingDomainStats[7] = (int)_stopwatch.ElapsedMilliseconds;
            }
            _pingDomainStats[8] += (int)_stopwatch.ElapsedMilliseconds;
        }

        public override string ToString()
        {
            return string.Format("\r\n\r\nPing statistics for {0}:\r\n Pinged {1} times [{2}-ok; {3}-empty content; {4}-content doesn't match; {5}-error]\r\n Server response time: Minimum {6}ms, Maximum {7}ms, Avg {8}ms\r\n#{9} times response took more than 6 sec.", Url,
                _pingDomainStats[0]
                ,_pingDomainStats[1]
                ,_pingDomainStats[2]
                ,_pingDomainStats[3]
                ,_pingDomainStats[4]
                ,_pingDomainStats[6]
                ,_pingDomainStats[7]
                , _pingDomainStats[8] / _pingDomainStats[0]
                ,_pingDomainStats[5]);
        }

        public List<DateTime> GetFailedPings()
        {
            return PingResults.Where(r => r.Value == false).Select(r => r.Key).ToList();
        }
        private void PingFailed()
        {
            PingResults.Add(DateTime.Now, false);
        }
    }
}