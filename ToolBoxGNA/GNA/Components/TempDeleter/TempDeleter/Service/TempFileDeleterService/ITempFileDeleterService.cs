using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempDeleter.ViewModel.TempFileDeleterService
{
    interface ITempFileDeleterService
    {
        void TempFileRemover(string FolderName);
    }
}
