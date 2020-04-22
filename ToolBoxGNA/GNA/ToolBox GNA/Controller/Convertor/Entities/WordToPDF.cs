using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox_GNA.Controller.Convertor.Entities.Interfaces;

namespace ToolBox_GNA.Controller.Convertor.Entities
{
    public class WordToPDF : IModel
    {
        private string fullName;
        private string directory;
        private string type;
        private int id;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FileName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string DirectoryPath
        {
            get { return directory; }
            set { directory = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string OutputDirectory { get; set; }


    }
}
