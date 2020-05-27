using DatabaseOperations;
using FileSearcherDemo.Entities.BindingModels.DeleteFileBindingModel;
using FileSearcherDemo.Services.DeleteFileServices.DeleteFileServiceF;
using NUnit.Framework;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ToolBoxGNAUnitTesting.Services.FileManager
{
    public class DeleteServiceTests
    {
        [TestCase(@"C:\Users\Nikih\Desktop\Resources")]
        public void DeleteMethodDeletesFilesSuccesfully(string sourcePath)
        {
            CurrentUser.user.username = "Test";
            DeleteFileBindingModel bindingModel = new DeleteFileBindingModel();
            bindingModel.FileSourcePath = sourcePath;

            DeleterFileService deleteFileService = new DeleterFileService();
            string[] files = new string[] { sourcePath +"\\aaaa.pptx", sourcePath + "\\banan.docx" };


            deleteFileService.Delete(files, bindingModel);


            FileAssert.DoesNotExist(sourcePath + @"\aaaa.pptx");
            FileAssert.DoesNotExist(sourcePath + @"\banan.docx");

        }

        [TestCase(@"C:\Users\Nikih\Desktop\Resources")]
        public void DeleteMethodFailed(string sourcePath)
        {
            CurrentUser.user.username = "Test";
            DeleteFileBindingModel bindingModel = new DeleteFileBindingModel();
            bindingModel.FileSourcePath = sourcePath;

            DeleterFileService deleteFileService = new DeleterFileService();

            FieldInfo[] fields = typeof(DeleterFileService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).ToArray();
            FieldInfo isDeleted = fields.FirstOrDefault(x => x.Name == "isDeleted");
            isDeleted.SetValue(deleteFileService, false);

            string[] files = new string[] { sourcePath + "\\aaaa.pptx", sourcePath + "\\banan.docx" };

            deleteFileService.Delete(files, bindingModel);
            
            Assert.IsFalse((bool)isDeleted.GetValue(deleteFileService));

        }
    }
}
