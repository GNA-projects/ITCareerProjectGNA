using DatabaseOperations;
using FileSearcherDemo.BindingModels.RenameFileForm;
using FileSearcherDemo.Services.RenameFileService;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxGNAUnitTesting.Services.FileManager
{
    public class RenameServiceTests
    {
        [TestCase]
        public void RenameMethodRenamesFilesCorrectlly()
        {
            CurrentUser.Username = "Test";
            RenameFileBindingModel bindingModel = new RenameFileBindingModel();
            bindingModel.FileName = @"C:\Users\Nikih\Desktop\Resources\banan.docx";
            bindingModel.NewName = "izrod";
            RenamerFileService renameFileService = new RenamerFileService();

            renameFileService.Rename(bindingModel);

            FileAssert.Exists(@"C:\Users\Nikih\Desktop\Resources\izrod.docx");

        }

        [TestCase]
        public void RenameMethodOverwritesFilesSuccesfully()
        {
            CurrentUser.Username = "Test";
            RenameFileBindingModel bindingModel = new RenameFileBindingModel();
            bindingModel.FileName = @"C:\Users\Nikih\Desktop\Resources\banan.docx";
            bindingModel.NewName = "banan";
            RenamerFileService renameFileService = new RenamerFileService();

            renameFileService.Rename(bindingModel);

            FileAssert.Exists(@"C:\Users\Nikih\Desktop\Resources\Overwrite -banan.docx");
        }

        [TestCase]
        public void RenameMethodFailed()
        {
            CurrentUser.Username = "Test";
            RenameFileBindingModel bindingModel = new RenameFileBindingModel();
            bindingModel.FileName = @"C:\Users\Nikih\Desktop\Resources\banan.docx";
            bindingModel.NewName = "ggg";
            RenamerFileService renameFileService = new RenamerFileService();

            FieldInfo[] fields = typeof(RenamerFileService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).ToArray();
            FieldInfo isRenamed = fields.FirstOrDefault(x => x.Name == "isRenamed");
            isRenamed.SetValue(renameFileService, false);

            renameFileService.Rename(bindingModel);

            Assert.IsFalse((bool)isRenamed.GetValue(renameFileService));

        }



    }
}
