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
            DirectoryInfo dir = new DirectoryInfo(FolderName);
            string name = null;

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

                    TempFileRemover(directory.FullName);

                    directory.Delete(true);
                }
                catch (UnauthorizedAccessException)
                {

                }
                catch (System.IO.IOException)
                {

                }

            }

            model.Count = count;
            model.Names = sb.ToString();

                
        }

        public void Reset()
        {
            count = 0;
            sb.Clear();
        }

        public void GetModelNames()
        {
            MessageBox.Show($"{model.Names}");
        }

        public bool HasErrors()
        {
            
            if (model.Count > 0)
            {
                MessageBox.Show($"{model.Count} files COULDN'T BE DELETED BECAUSE THEY ARE USED BY ANOTHER PROCESS!", "Error", MessageBoxButtons.OK);
                return true;
            }
            else
                return false;
        }

    }
}
