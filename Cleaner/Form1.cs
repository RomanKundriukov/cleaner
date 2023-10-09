using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Cleaner;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Machen die Gränze des Fensters stabil ohne Möglichkeit änderung
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            
        }

        private void LöschenButton_Click(object sender, EventArgs e)
        {
            cleaner cleaner = new cleaner();
            Log log = new Log();

            log.PrüfenFilesUndOrdners(cleaner.TempPath);
            log.ErschaffenLogFile();
            //cleaner.DeleteFileInDirectory(cleaner.TempPath);
            //cleaner.DeleteOrdner(cleaner.TempPath);
            cleaner.DeleteFileUndOrdnerInDirectory(cleaner.TempPath);

            log.PrüfenFilesUndOrdners(cleaner.TempLocalPath);
            log.ErschaffenLogFile();
            //cleaner.DeleteFileInDirectory(cleaner.TempLocalPath);
            //cleaner.DeleteOrdner(cleaner.TempLocalPath);
            cleaner.DeleteFileUndOrdnerInDirectory(cleaner.TempLocalPath);

            log.PrüfenFilesUndOrdners(cleaner.PrefetchPath);
            log.ErschaffenLogFile();
            //cleaner.DeleteFileInDirectory(cleaner.PrefetchPath);
            //cleaner.DeleteOrdner(cleaner.PrefetchPath);
            cleaner.DeleteFileUndOrdnerInDirectory(cleaner.PrefetchPath);

            log.PrüfenFilesUndOrdners(cleaner.SoftwareDistributionPath);
            log.ErschaffenLogFile();
            //cleaner.DeleteFileInDirectory(cleaner.SoftwareDistributionPath);
            //cleaner.DeleteOrdner(cleaner.SoftwareDistributionPath);
            cleaner.DeleteFileUndOrdnerInDirectory(cleaner.SoftwareDistributionPath);

            log.PrüfenFilesUndOrdners(cleaner.DownloadsPath);
            log.ErschaffenLogFile();
            //cleaner.DeleteFileInDirectory(cleaner.DownloadsPath);
            //cleaner.DeleteOrdner(cleaner.DownloadsPath);
            cleaner.DeleteFileUndOrdnerInDirectory(cleaner.DownloadsPath);

            log.PrüfenFilesUndOrdners(cleaner.LogsPath);
            log.ErschaffenLogFile();
            //cleaner.DeleteFileInDirectory(cleaner.LogsPath);
            //cleaner.DeleteOrdner(cleaner.LogsPath);
            cleaner.DeleteFileUndOrdnerInDirectory(cleaner.LogsPath);

            ErfolgLabel.Text += "Die Ordnen und Datei wurden erfolgreich gelöscht!\n";
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            cleaner cleaner = new cleaner();
            cleaner.OrdnerOpen(cleaner.TempPath);
            cleaner.OrdnerOpen(cleaner.TempLocalPath);
            cleaner.OrdnerOpen(cleaner.PrefetchPath);
            cleaner.OrdnerOpen(cleaner.SoftwareDistributionPath);
            cleaner.OrdnerOpen(cleaner.DownloadsPath);
            cleaner.OrdnerOpen(cleaner.LogsPath);
            //cleaner.OrdnerOpen(cleaner.OldPath);

            
            ErfolgLabel.Text += "Die Ordnen wurden erfolgreich aufgemacht!\n";
            
        }

       
    }
}
