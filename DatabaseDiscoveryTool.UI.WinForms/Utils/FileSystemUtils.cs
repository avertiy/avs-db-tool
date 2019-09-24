using System;
using System.IO;

namespace DatabaseDiscoveryTool.UI.WinForms.Utils
{
    public static class FileSystemUtils
    {
        public static int CleanupDirectory(string path, bool deleteSelf)
        {
            if (path == @"C:\" || path.ToUpper() == @"C:\WINDOWS")
            {
                throw new Exception("WARNING: delete operation for path: " + path + " can't be executed");
            }
            int count = 0;
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                string[] dirs = Directory.GetDirectories(path);

                foreach (string file in files)
                {
                    try
                    {
                        File.SetAttributes(file, FileAttributes.Normal);
                        File.Delete(file);
                        count++;
                    }catch{}
                }

                foreach (string dir in dirs)
                {
                    try
                    {
                        count += CleanupDirectory(dir, true);
                        Directory.Delete(path, false);
                        count++;
                    }
                    catch
                    {
                    }
                }
                if (deleteSelf)
                {
                    try
                    {
                        Directory.Delete(path, false);
                        count++;
                    }
                    catch
                    {
                    }
                }
            }
            return count;
        }
    }
}