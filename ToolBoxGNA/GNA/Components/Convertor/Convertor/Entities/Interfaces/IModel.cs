using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterDemo
{
    public interface IModel
    {

        string FileName { get; set; }
        
        string DirectoryPath { get; set; }
        
        string Type { get; set;}

    }
}
