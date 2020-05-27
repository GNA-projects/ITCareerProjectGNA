using DatabaseOperations;
using FileSearcherDemo.BindingModels.SearchFileForm;
using FileSearcherDemo.Entities.BindingModels.CopyFileBindingModel;
using FileSearcherDemo.Services.CopyFileServices.CopyFileAbstractClass;
using FileSearcherDemo.Services.CopyFileServices.CopyFileServiceF;
using NUnit.Framework;
using System.Linq;
using System.Reflection;

namespace ToolBoxGNAUnitTesting.Services.FileManager
{
    public class CopyServiceTests
    {
        [TestCase(@"C:\Users\Nikih\Desktop\aaa")]
        public void CopyMethodOnSearchCopiesFilesSuccesfully(string destPath)
        {
            SearchFileBindingModel bindingModel = new SearchFileBindingModel();
            bindingModel.SearchDir = @"C:\Users\Nikih\Desktop\Resources";
            bindingModel.DestDir = destPath;
            CopyFileServiceAbstract copyFileService = new CopierFileService();
            string[] files = new string[] { "aaaa.pptx", "banan.docx" };

            copyFileService.Copy(files, bindingModel);

            FileAssert.Exists(destPath + @"\aaaa.pptx");
            FileAssert.Exists(destPath + @"\banan.docx");

        }
        [TestCase(@"C:\Users\Nikih\Desktop\aaa")]
        public void CopyMethodOnSearchOverwritesFilesSuccesfully(string destPath)
        {
            SearchFileBindingModel bindingModel = new SearchFileBindingModel();
            bindingModel.SearchDir = @"C:\Users\Nikih\Desktop\Resources";
            bindingModel.DestDir = destPath;
            CopyFileServiceAbstract copyFileService = new CopierFileService();
            string[] files = new string[] { "aaaa.pptx", "banan.docx" };

            copyFileService.Copy(files, bindingModel);

            FileAssert.Exists(destPath + @"\Overwrite -aaaa.pptx");
            FileAssert.Exists(destPath + @"\Overwrite -banan.docx");

        }

        [TestCase(@"C:\Users\Nikih\Desktop\aaa")]
        public void CopyMethodOnSearchFailed(string destPath)
        {
            SearchFileBindingModel bindingModel = new SearchFileBindingModel();
            bindingModel.SearchDir = @"C:\Users\Nikih\Desktop\Resources";
            bindingModel.DestDir = destPath;
            CopyFileServiceAbstract copyFileService = new CopierFileService();

            FieldInfo[] fields = typeof(CopyFileServiceAbstract).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).ToArray();
            FieldInfo isCompleted = fields.FirstOrDefault(x => x.Name == "isCompleted");
            isCompleted.SetValue(copyFileService, false);

            string[] files = new string[] { "aaaa.pptx", "banan.docx" };

            copyFileService.Copy(files, bindingModel);

            Assert.IsFalse((bool)isCompleted.GetValue(copyFileService));

        }

        [TestCase(@"C:\Users\Nikih\Desktop\aaa")]
        public void CopyMethodCopiesFilesSuccesfully(string destPath)
        {
            CurrentUser.user.username = "Test";
            CopyFileBindingModel bindingModel = new CopyFileBindingModel();
            bindingModel.FileSourcePath = @"C:\Users\Nikih\Desktop\Resources";
            bindingModel.FileDestPath = destPath;
            CopierFileService copyFileService = new CopierFileService();
            string[] files = new string[] { "aaaa.pptx", "banan.docx" };


            copyFileService.Copy(files, bindingModel);


            FileAssert.Exists(destPath + @"\aaaa.pptx");
            FileAssert.Exists(destPath + @"\banan.docx");

        }
        [TestCase(@"C:\Users\Nikih\Desktop\aaa")]
        public void CopyMethodOverwritesFilesSuccesfully(string destPath)
        {
            CopyFileBindingModel bindingModel = new CopyFileBindingModel();
            bindingModel.FileSourcePath = @"C:\Users\Nikih\Desktop\Resources";
            bindingModel.FileDestPath = destPath;
            CopierFileService copyFileService = new CopierFileService();
            string[] files = new string[] { "aaaa.pptx", "banan.docx" };

            CurrentUser.user.username = "Test";
            copyFileService.Copy(files, bindingModel);

            FileAssert.Exists(destPath + @"\Overwrite -aaaa.pptx");
            FileAssert.Exists(destPath + @"\Overwrite -banan.docx");

        }

        [TestCase(@"C:\Users\Nikih\Desktop\aaa")]
        public void CopyMethodFailed(string destPath)
        {
            CurrentUser.user.username = "Test";
            CopyFileBindingModel bindingModel = new CopyFileBindingModel();
            bindingModel.FileSourcePath = @"C:\Users\Nikih\Desktop\Resources";
            bindingModel.FileDestPath = destPath;
            CopierFileService copyFileService = new CopierFileService();

            FieldInfo[] fields = typeof(CopierFileService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).ToArray();
            FieldInfo isCompleted = fields.FirstOrDefault(x => x.Name == "isCompleted");
            isCompleted.SetValue(copyFileService, false);

            string[] files = new string[] { "aaaa.pptx", "banan.docx" };

            copyFileService.Copy(files, bindingModel);

            Assert.IsFalse((bool)isCompleted.GetValue(copyFileService));

        }

    }
}
