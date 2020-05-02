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
         static TempFileDeleterService deleterService = new TempFileDeleterService();
        public static void ResetValues()
        {
            deleterService.Reset();
        }
        public static async void DeleteTempFilesAsync(string FolderName)
        {

            await Task.Run(() => deleterService.TempFileRemover(FolderName));

        }
        public static async void GetNames()
        {
            await Task.Run(() => deleterService.GetModelNames());
        }
        public static FileInfo[] GetTempFileInfo(string path)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles();
            return files;
        }
        public static bool HasTempFiles()
        {
            FileInfo[] tempPath = TempDeleterController.GetTempFileInfo(Path.GetTempPath());

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
    }
}
