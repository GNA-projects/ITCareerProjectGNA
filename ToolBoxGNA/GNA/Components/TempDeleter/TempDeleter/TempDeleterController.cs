using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempDeleter.TempDeleter
{
    public static class TempDeleterController
    {
        static readonly TempFileDeleterService deleterService = new TempFileDeleterService();
        public static void ResetValues()
        {
            deleterService.Reset();
        }
        public static async void DeleteTempFilesAsync(string FolderName)
        {

           await Task.Run(() => deleterService.TempFileRemover(FolderName));

        }
        public static async void GetNamesAsync()
        {
            await Task.Run(() => deleterService.GetModelNames());
        }
        public static bool HasTempFiles()
        {
            FileInfo[] tempPath = deleterService.GetTempFileInfo(Path.GetTempPath());

            if (tempPath.Length > 0)
            {
                MessageBox.Show($"Temp files found and are ready to be deleted.", "Scan complete.");
                return true;
            }
            else
            {
                MessageBox.Show($"No temp files found to be deleted", "Scan Complete");
                return false;
            }
        }
        public static void DeleteTempFiles(string FolderName)
        {
            deleterService.TempFileRemover(FolderName);
        }
        public static void GetNames()
        {
            deleterService.GetModelNames();
        }
    }
}
