using System;
using System.IO;

namespace Cleaner
{
    class Log : cleaner
    {
        //Erschaffen die Ordner wo wird File Log sich befinden
        //string sourceDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string outputFile = $@"C:\Users\{userName}\Documents\logs.txt";

        string[] Inhalt;
        //prüfen die Ordner und Datei in Directory
        public string[] PrüfenFilesUndOrdners (string path)
        {
            this.Inhalt = Directory.GetFileSystemEntries(path);
            return Inhalt;
        }

        public void ErschaffenLogFile()
        {
            using (StreamWriter writer = new StreamWriter(outputFile, append: true))
            {
                foreach (var item in Inhalt)
                {
                    writer.WriteLine(item);
                }
            }
        }

    }
}
