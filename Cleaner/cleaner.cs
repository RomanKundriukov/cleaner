using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cleaner
{
    public class cleaner
    {
        //bekommen die Name des Users dieser PC
        readonly public static string userName = Environment.UserName;

        //erschaffen Path
        readonly public string TempPath = @"C:\Windows\Temp\";
        readonly public string TempLocalPath = $@"C:\Users\{userName}\AppData\Local\Temp\";
        readonly public string PrefetchPath = @"C:\Windows\Prefetch\";
        readonly public string SoftwareDistributionPath = @"C:\Windows\SoftwareDistribution\Download\";
        readonly public string DownloadsPath = $@"C:\Users\{userName}\Downloads\";
        readonly public string LogsPath = @"C:\Windows\Logs\";

        //erschaffen die Methode, die die Ordner aufmachen wird

        static public void OrdnerOpen (string path)
        {
            try
            {
                Process.Start(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler die Ordner Aufmachen");
            }
        }

        static public void DeleteFileUndOrdnerInDirectory(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    string[] filesInDirectory = Directory.GetFiles(path);
                    foreach (var file in filesInDirectory)
                    {
                        File.Delete(file);
                    }

                    string[] ordnerInDirectory = Directory.GetDirectories(path);
                    foreach (var subDirectory in ordnerInDirectory)
                    {
                        Directory.Delete(subDirectory, true);
                    }

                    //Directory.Delete(path, true);
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                string ErrorFilePath = $@"C:\Users\{userName}\Documents\logsFehler.txt";
                try
                {
                    using (StreamWriter writer = new StreamWriter(ErrorFilePath, append: true))
                    {
                        writer.WriteLine($"Date und Time: {DateTime.Now}");
                        writer.WriteLine($"Message Fehler: {ex.Message}");
                        writer.WriteLine(new string('-', 50));
                    }
                }
                catch (Exception exeption)
                {
                    MessageBox.Show("Fehler während die Fehler File aufbauen" + exeption.Message);
                }
            }
        }

        //static public void DeleteOrdner(string path)
        //{
        //    try
        //    {
        //        if (Directory.Exists(path))
        //        {
        //            string[] ordnerInDirectory = Directory.GetDirectories(path);
        //            foreach (var subDirectory in ordnerInDirectory)
        //            {
        //                DeleteOrdner(subDirectory);
        //            }
        //        }
        //        else
        //            return;
        //    }
        //    catch (Exception ex)
        //    {
        //        string ErrorFilePath = $@"C:\Users\{userName}\Documents\logsFehler.txt";
        //        try
        //        {
        //            using (StreamWriter writer = new StreamWriter(ErrorFilePath, append: true))
        //            {
        //                writer.WriteLine($"Date und Time: {DateTime.Now}");
        //                writer.WriteLine($"Message Fehler: {ex.Message}");
        //                writer.WriteLine(new string('-', 50));
        //            }
        //        }
        //        catch (Exception exeption)
        //        {
        //            MessageBox.Show("Fehler während die Fehler File aufbauen" + exeption.Message);
        //        }
        //    }
        //}

    }
}
