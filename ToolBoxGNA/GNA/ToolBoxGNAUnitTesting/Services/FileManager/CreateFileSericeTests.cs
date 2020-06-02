using DatabaseOperations;
using FileSearcherDemo.BindingModels.CreateFileForm;
using FileSearcherDemo.Services.CreateFileServices.CreateExcelFileServiceF;
using FileSearcherDemo.Services.CreateFileServices.CreatePowerPointFileServiceF;
using FileSearcherDemo.Services.CreateFileServices.CreateRarFileServiceF;
using FileSearcherDemo.Services.CreateFileServices.CreateTextFileServiceF;
using FileSearcherDemo.Services.CreateFileServices.CreateWordFileServiceF;
using NUnit.Framework;

namespace ToolBoxGNAUnitTesting.Services.FileManager
{
    public class CreateFileSericeTests
    //TODO: TESTS NEED TO SETUP DIFFERENT PARAMETHERS FOR DIFFERENT MACHINES
    {
        [TestCase]
        public void CreateMethodCreatesTextFileSuccesfully()
        {
            CurrentUser.user.username = "Test";
            CreateTextFileService fileService = new CreateTextFileService();
            CreateFileBindingModel bindingModel = new CreateFileBindingModel();

            bindingModel.FileName = "gogo";
            bindingModel.DestPath = @"C:\Users\Nikih\Desktop\Resources";

            fileService.Create(bindingModel);

            FileAssert.Exists(@"C:\Users\Nikih\Desktop\Resources\gogo.txt");
        }

        [TestCase]
        public void CreateMethodCreatesWordFileSuccesfully()
        {
            CurrentUser.user.username = "Test";
            CreateWordFileService fileService = new CreateWordFileService();
            CreateFileBindingModel bindingModel = new CreateFileBindingModel();

            bindingModel.FileName = "gogo";
            bindingModel.DestPath = @"C:\Users\Nikih\Desktop\Resources";

            fileService.CreateWord(bindingModel);

            FileAssert.Exists(@"C:\Users\Nikih\Desktop\Resources\gogo.docx");
        }

        [TestCase]
        public void CreateMethodCreatesPowerPointFileSuccesfully()
        {
            CurrentUser.user.username = "Test";
            CreatePowerPointFileService fileService = new CreatePowerPointFileService();
            CreateFileBindingModel bindingModel = new CreateFileBindingModel();

            bindingModel.FileName = "gogo";
            bindingModel.DestPath = @"C:\Users\Nikih\Desktop\Resources";

            fileService.CreatePowerPoint(bindingModel);

            FileAssert.Exists(@"C:\Users\Nikih\Desktop\Resources\gogo.pptx");
        }

        [TestCase]
        public void CreateMethodCreatesExcelFileSuccesfully()
        {
            CurrentUser.user.username = "Test";
            CreateExelFileService fileService = new CreateExelFileService();
            CreateFileBindingModel bindingModel = new CreateFileBindingModel();

            bindingModel.FileName = "gogo";
            bindingModel.DestPath = @"C:\Users\Nikih\Desktop\Resources";

            fileService.CreateExcel(bindingModel);

            FileAssert.Exists(@"C:\Users\Nikih\Desktop\Resources\gogo.xlsx");
        }

        [TestCase]
        public void CreateMethodCreatesRarFileSuccesfully()
        {
            CurrentUser.user.username = "Test";
            CreateRarFileService fileService = new CreateRarFileService();
            CreateFileBindingModel bindingModel = new CreateFileBindingModel();

            bindingModel.FileName = "gogo";
            bindingModel.DestPath = @"C:\Users\Nikih\Desktop\Resources";

            fileService.CreateRar(bindingModel);

            FileAssert.Exists(@"C:\Users\Nikih\Desktop\Resources\gogo.zip");
        }


    }
}
