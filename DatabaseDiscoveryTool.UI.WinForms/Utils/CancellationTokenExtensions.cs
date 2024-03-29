using System;
using System.Threading;
using System.Threading.Tasks;

namespace DatabaseDiscoveryTool.UI.WinForms.Utils
{
    static class CancellationTokenExtensions
    {
        public static bool WaitCancellationRequested(this CancellationToken token,TimeSpan timeout){return token.WaitHandle.WaitOne(timeout);}
    }
    internal static class Repeat
    {
        public static Task Interval(TimeSpan pollInterval, Action action, CancellationToken token)
        {
            // We don't use Observable.Interval:
            // If we block, the values start bunching up behind each other.
            return Task.Factory.StartNew(
                () =>
                {
                    for (; ; )
                    {
                        if (token.WaitCancellationRequested(pollInterval))
                            break;

                        action();
                    }
                }, token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }
    }
}