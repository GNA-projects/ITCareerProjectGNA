using DatabaseOperations.Operations.TempDeleterBuisseness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempDeleter.ViewModel.TempFileDeleterService;

namespace TempDeleter
{
    public class TempFileDeleterService : ITempFileDeleterService
    {
        TempFIle model = new TempFIle();
        int count = 0;
        StringBuilder sb = new StringBuilder();
        public void TempFileRemover(string FolderName)
        {

            Delete(FolderName);



            if (count > 0)
            {
                MessageBox.Show($"{count} files COULDN'T BE DELETED BECAUSE THEY ARE USED BY ANOTHER PROCESS!", "Error", MessageBoxButtons.OK);
                TempDeleterDbService.AddTempFiles(false, count);
            }
            else
            {

                MessageBox.Show("Everything is deleted!");
                
            }


            model.Count = count;
            model.Names = sb.ToString();
            TempDeleterDbService.AddTempFiles(true, count);
        }
        public void Reset()
        {
            count = 0;
            sb.Clear();
        }
        public string GetModelNames()
        {
            return sb.ToString();

        }
        private void Delete(string FolderName)
        {
            string name = null;
            DirectoryInfo dir = new DirectoryInfo(FolderName);
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    name = file.Name;

                    file.Delete();
                    
                }
                catch (UnauthorizedAccessException)

                {
                    
                    count++;
                    sb.Append(name + ", ");
                }
                catch (System.IO.IOException)
                {
                    
                    count++;
                    sb.Append(name + ", ");
                }
            }

            foreach (DirectoryInfo directory in dir.GetDirectories())
            {
                try
                {

                    Delete(directory.FullName);

                    directory.Delete(true);
                }
                catch (UnauthorizedAccessException)
                {

                }
                catch (System.IO.IOException)
                {

                }

            }
        }

        public FileInfo[] GetTempFileInfo(string path)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            FileInfo[] files = new FileInfo[1000];
            foreach (var file in directoryInfo.GetFiles())
            {
                files.Append(file);
            }
            for (int i = 0; i < directoryInfos.Length; i++)
            {
                FileInfo[] fileInfos = directoryInfos[i].GetFiles();
                foreach (var fileinfo in fileInfos)
                {
                    files.Append(fileinfo);
                }
            }
            return files;
        }
    }
}
