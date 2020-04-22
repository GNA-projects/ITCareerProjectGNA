using ConverterDemo.Models;
using ConverterDemo.Services.WordToPDFConvertorService;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterDemo.Services
{
    public class DocumetConvertorService : IWordToPDFConvertorService
    {
        private object oMissing;

        public void WordToPDFConv(string input, string outpath)
        {
            try
            {
                //Opens Microsoft Word in Background
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                //Gets DocumentName and DocumentPath
                List<string> file = input.Split('\\').ToList();

                List<string> path = new List<string>();
                for (int i = 0; i < file.Count - 1; i++)
                {
                    path.Add(file[i]);
                }
                //Saves the name and the path
                DirectoryInfo dirInfo = new DirectoryInfo(string.Join("\\", path));
                FileInfo[] wordFiles = dirInfo.GetFiles(file.Last());



                //Hides the word document in Background
                word.Visible = false;
                word.ScreenUpdating = false;
                //Using foreach for future upgrade where you would convert multiple documents at once
                foreach (FileInfo wordFile in wordFiles)
                {
                    WordToPDF wordToPDF = new WordToPDF();
                    object outputFileName = ConvertDoc(input, outpath, word, wordFile);

                    string sourceFile = (string)(input);
                    string destinationFile;


                    if (wordFile.Extension == ".docx")
                    {
                        destinationFile = outpath + "\\" + wordFile.Name.Replace(".docx", ".pdf");
                    }
                    else
                    {

                        destinationFile = outpath + "\\" + wordFile.Name.Replace(".doc", ".pdf");
                    }


                    File.Move(sourceFile, destinationFile);
                    string newDirect = destinationFile;
                    string newFileName = sourceFile;
                    wordToPDF.FileName = newFileName;
                    wordToPDF.DirectoryPath = dirInfo.FullName;
                    wordToPDF.OutputDirectory = newDirect;
                    wordToPDF.Type = "Document";

                }

                //Quitting Microsoft Word from the background
                word.Quit(ref oMissing, ref oMissing, ref oMissing);
                word = null;

                string message = "Converting Done!";
                string title = "Done!";
                MessageBox.Show(message, title);
            }
            catch (Exception e)
            {
                MessageBox.Show("Path not setted! Please set both Directories!", "Converting error");
            }
        }

        private object ConvertDoc(string input, string outpath, Microsoft.Office.Interop.Word.Application word, FileInfo wordFile)
        {


            Object filename = (Object)wordFile.FullName;
            //Opens the file in word
            Document doc = word.Documents.Open(ref filename);
            doc.Activate();
            //Renaming the original's file extension to PDF
            object outputFileName = wordFile.FullName.Replace(".doc", ".pdf");
            if (wordFile.Extension == ".docx")
            {
                outputFileName = wordFile.FullName.Replace(".docx", ".pdf");
            }
            //Saves the renamed file in PDF format
            object fileFormat = WdSaveFormat.wdFormatPDF;
            doc.SaveAs(ref outputFileName,
                ref fileFormat);

            object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
            //Closes the document
            (doc).Close(ref saveChanges);
            doc = null;
            return outputFileName;
        }
    }
}
