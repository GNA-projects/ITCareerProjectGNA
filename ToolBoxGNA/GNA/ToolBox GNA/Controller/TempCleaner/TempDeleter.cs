using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempDeleter
{
    public static class TempDeleter
    {
        static TempFileDeleterService service = new TempFileDeleterService();
        public static async void DeleteTempFilesAsync(string folder)
        {
            await Task.Run(()=>service.TempFileRemover(folder));
        }
        public static async void GetErrorFilesNamesAsync()
        {
            await Task.Run(()=>service.GetModelNames());
        }
        public static bool HasErrors()
        {
            
            return service.HasErrors();
        }
        public static void ResetValues()
        {
            service.Reset();
        }
       
        public static bool HasTempFiles()
        {
            FileInfo[] tempDir = GetTempFileInfo(Path.GetTempPath());
            
            if (tempDir.Length > 0)
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
        private static FileInfo[] GetTempFileInfo(string path)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles();
            return files;
        }
    }
}
