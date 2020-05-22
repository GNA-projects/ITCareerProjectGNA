using FileSearcherDemo.BindingModels.CreateFileForm;
using Word = Microsoft.Office.Interop.Word;

namespace FileSearcherDemo.Services.CreateFileServices.CreateWordFileServiceF
{
    /* This is a service that creates Word file*/
    public class CreateWordFileService : ICreateWordFileService
    {
        public void CreateWord(CreateFileBindingModel createWordFileBindingModel)
        {
            //Uses CreateFileBindingModel to get specific information from it. 

            //Creates a excel application that runs in the background.
            //In the background the application adds the things it needs to be opened after being created.
            Word.Application objWord = new Word.Application();
            objWord.Visible = false;
            Word.Document objDoc = objWord.Documents.Add();
            Word.Paragraph objPara;
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "";

            //After the user has given a directory and a name for the file, it is saved there with that name.
            objDoc.SaveAs2(createWordFileBindingModel.DestPath + @"\" + $"{createWordFileBindingModel.FileName}");

            //This closes the created in the background application and quits it.
            objDoc.Close();
            objWord.Quit();
        }
    }
}
