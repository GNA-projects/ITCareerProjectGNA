using FileSearcherDemo.BindingModels.CreateFileForm;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace FileSearcherDemo.Services.CreateFileServices.CreatePowerPointFileServiceF
{
    /* This is a service that creates Power Point file*/
    public class CreatePowerPointFileService : ICreatePowerPointFileService
    {
        public void CreatePowerPoint(CreateFileBindingModel createPPBindingModel)
        {
            //Uses CreateFileBindingModel to get specific information from it. 
            //Creates a excel application that runs in the background.
            //In the background the application adds the things it needs to be opened after being created.
            PowerPoint.Application objPowerPoint = new PowerPoint.Application();
            PowerPoint.Presentation objPresentation = objPowerPoint.Presentations.Add(Microsoft.Office.Core.MsoTriState.msoFalse);
            Microsoft.Office.Interop.PowerPoint.Slides slides;
            Microsoft.Office.Interop.PowerPoint._Slide slide;
            Microsoft.Office.Interop.PowerPoint.TextRange objText;
            Microsoft.Office.Interop.PowerPoint.CustomLayout custLayout =
                            objPresentation.SlideMaster.CustomLayouts[Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutText];
            slides = objPresentation.Slides;
            slide = slides.AddSlide(1, custLayout);
            objText = slide.Shapes[1].TextFrame.TextRange;
            objText.Text = "Title of page";
            objText.Font.Name = "Arial";
            objText.Font.Size = 32;
            Microsoft.Office.Interop.PowerPoint.Shape shape = slide.Shapes[2];

            //After the user has given a directory and a name for the file, it is saved there with that name.
            objPresentation.SaveAs(createPPBindingModel.DestPath + @"\" + $"{createPPBindingModel.FileName}", Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsDefault,
            Microsoft.Office.Core.MsoTriState.msoTrue);

            //This closes the created in the background application and quits it.
            objPresentation.Close();
            objPowerPoint.Quit();
        }
    }
}
