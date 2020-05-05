﻿using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBox_GNA.Controller.Convertor.Entities;

namespace ToolBox_GNA.Controller.Convertor.Services.WordToPDFConvertorService
{
    public class DocumetConvertorService : IWordToPDFConvertorService
    {
        private object oMissing;

        public void WordToPDFConv(string input, string outpath)
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



            bool isDone = false;
            //Hides the word document in Background
            word.Visible = false;
            word.ScreenUpdating = false;
            //Using foreach for future upgrade where you would convert multiple documents at once
            foreach (FileInfo wordFile in wordFiles)
            {
                try
                {

                    WordToPDF wordToPDF = new WordToPDF();
                    object outputFileName = null;
                    Object filename = (Object)wordFile.FullName;
                    //Opens the file in word
                    Document doc = word.Documents.Open(ref filename);
                    doc.Activate();
                    //Renaming the original's file extension to PDF
                    outputFileName = wordFile.FullName.Replace(".doc", ".pdf");
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
                    if (File.Exists(destinationFile))
                    {
                        var messagebox = MessageBox.Show("File with same name already exists! Do you want to overwrite it?", "Error", MessageBoxButtons.YesNoCancel);
                        if (messagebox == DialogResult.Yes)
                        {
                            File.Delete(destinationFile);
                            File.Move((string)(outputFileName), destinationFile);
                            isDone = true;
                        }
                        else if (messagebox == DialogResult.No)
                        {
                            MessageBox.Show("Converting Canceled");
                        }
                        else
                        {

                        }
                    }

                    string newDirect = destinationFile;
                    string newFileName = sourceFile;
                    wordToPDF.FileName = newFileName;
                    wordToPDF.DirectoryPath = dirInfo.FullName;
                    wordToPDF.OutputDirectory = newDirect;
                    wordToPDF.Type = "Document";

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Has occured");
                }

                //Quitting Microsoft Word from the background
                word.Quit(ref oMissing, ref oMissing, ref oMissing);
                word = null;

                string message = "Converting Done!";
                string title = "Done!";
                if (isDone)
                {
                    MessageBox.Show(message, title);
                }
            }
        }

    }
}
