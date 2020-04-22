using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox_GNA.Controller.Convertor.ViewModels.GetFilePathViewModel
{
    interface IGetFilePathViewModel
    {
        string GetFileDirectory(bool radioButtonChecked);
    }
}
