using DatabaseOperations;
using FileSearcherDemo.Entities.BindingModels.MoveFileBindingModel;
using FileSearcherDemo.Services.MoveFileServices.MoveFileServiceF;
using NUnit.Framework;
using System.Linq;
using System.Reflection;

namespace ToolBoxGNAUnitTesting.Services.FileManager
{
    public class MoveServiceTests
    //TODO: TESTS NEED TO SETUP DIFFERENT PARAMETHERS FOR DIFFERENT MACHINES
    {
        [TestCase(@"C:\Users\Nikih\Desktop\aaa")]
        public void MoveMethodMovesFilesSuccesfully(string destPath)
        {
            CurrentUser.user.username = "Test";
            MoveFileBindingModel bindingModel = new MoveFileBindingModel();
            bindingModel.FileSourcePath = @"C:\Users\Nikih\Desktop\Resources";
            bindingModel.FileDest = destPath;
            MoverFileService moveFileService = new MoverFileService();
            string[] files = new string[] { @"C:\Users\Nikih\Desktop\Resources\aaaa.pptx", @"C:\Users\Nikih\Desktop\Resources\banan.docx" };


            moveFileService.Move(files, bindingModel);


            FileAssert.Exists(destPath + @"\aaaa.pptx");
            FileAssert.Exists(destPath + @"\banan.docx");

        }
        [TestCase(@"C:\Users\Nikih\Desktop\aaa")]
        public void MoveMethodOverwritesFilesSuccesfully(string destPath)
        {
            MoveFileBindingModel bindingModel = new MoveFileBindingModel();
            bindingModel.FileSourcePath = @"C:\Users\Nikih\Desktop\Resources";
            bindingModel.FileDest = destPath;
            MoverFileService MoveService = new MoverFileService();
            string[] files = new string[] { @"C:\Users\Nikih\Desktop\Resources\aaaa.pptx", @"C:\Users\Nikih\Desktop\Resources\banan.docx" };

            CurrentUser.user.username = "Test";
            MoveService.Move(files, bindingModel);

            FileAssert.Exists(destPath + @"\Overwrite -aaaa.pptx");
            FileAssert.Exists(destPath + @"\Overwrite -banan.docx");

        }

        [TestCase(@"C:\Users\Nikih\Desktop\aaa")]
        public void MoveMethodFailed(string destPath)
        {
            CurrentUser.user.username = "Test";
            MoveFileBindingModel bindingModel = new MoveFileBindingModel();
            bindingModel.FileSourcePath = @"C:\Users\Nikih\Desktop\Resources";
            bindingModel.FileDest = destPath;
            MoverFileService moveFileService = new MoverFileService();

            FieldInfo[] fields = typeof(MoverFileService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).ToArray();
            FieldInfo isMoved = fields.FirstOrDefault(x => x.Name == "isMoved");
            isMoved.SetValue(moveFileService, false);

            string[] files = new string[] { @"C:\Users\Nikih\Desktop\Resources\aaaa.pptx", @"C:\Users\Nikih\Desktop\Resources\banan.docx" };

            moveFileService.Move(files, bindingModel);

            Assert.IsFalse((bool)isMoved.GetValue(moveFileService));
            
        }
    }
}
