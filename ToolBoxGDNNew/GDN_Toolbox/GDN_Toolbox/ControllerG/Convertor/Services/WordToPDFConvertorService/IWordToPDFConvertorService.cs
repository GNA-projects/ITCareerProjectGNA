using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterDemo.Services.WordToPDFConvertorService
{
    interface IWordToPDFConvertorService
    {
        void WordToPDFConv(string input, string outpath);
    }
}
