using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempDeleter;

namespace ToolBoxGNAUnitTesting.Services.TempDelete
{
    //TODO: TESTS NEED TO SETUP DIFFERENT PARAMETHERS FOR DIFFERENT MACHINES
    [TestFixture()]
    public class TempFileDeleterServiceTests
    {
        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(100)]
        [TestCase(-100)]
        public void ResetMethod_ResetsCorecttly_Count(int testcount)
        {
            TempFileDeleterService service = new TempFileDeleterService();
            FieldInfo[] fields = typeof(TempFileDeleterService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo count = fields.FirstOrDefault(x => x.Name == "count");
            count.SetValue(service, testcount);
            service.Reset();
            Assert.AreEqual(0, count.GetValue(service));
        }


        [TestCase("Test")]
        [TestCase("LongerTestValue")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("Test ; ! @ \\")]
        public void ResetMethod_ResetsCorecttly_Names(string text)
        {
            TempFileDeleterService service = new TempFileDeleterService();
            FieldInfo[] fields = typeof(TempFileDeleterService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo sb = fields.FirstOrDefault(x => x.Name == "sb");
            sb.SetValue(service, new StringBuilder(text));

            service.Reset();
            Assert.IsEmpty(sb.GetValue(service).ToString());
        }


        [TestCase("Test")]
        [TestCase("LongerTestValue")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("Test ; ! @")]
        public void GetModelNamesMethod_ReturnsCorrect_PositiveMessage(string text)
        {
            TempFileDeleterService service = new TempFileDeleterService();
            FieldInfo[] fields = typeof(TempFileDeleterService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo sb = fields.FirstOrDefault(x => x.Name == "sb");
            sb.SetValue(service, new StringBuilder(text));
            FieldInfo count = fields.FirstOrDefault(x => x.Name == "count");
            count.SetValue(service, 5);
            service.GetModelNames();
            if ((int)count.GetValue(service) > 0)
            {
                Assert.AreEqual(MessageBox.Show($"{text}"), MessageBox.Show($"{sb.GetValue(service)}"));
            }
            else
            {
                Assert.Fail();
            }
        }


        [TestCase("Test")]
        [TestCase("LongerTestValue")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("Test ; ! @")]
        public void GetModelNamesMethod_ReturnsCorrect_NegativeMessage(string text)
        {
            TempFileDeleterService service = new TempFileDeleterService();
            FieldInfo[] fields = typeof(TempFileDeleterService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo sb = fields.FirstOrDefault(x => x.Name == "sb");
            sb.SetValue(service, new StringBuilder(text));
            FieldInfo count = fields.FirstOrDefault(x => x.Name == "count");
            count.SetValue(service, 0);
            service.GetModelNames();
            if ((int)count.GetValue(service) == 0)
            {
                MessageBox.Show("100% of files are deleted!");
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }


        [TestCase(@"C:\Users\Admin\Desktop\New folder\New folder\New folder (2)")]
        [TestCase(@"C:\Users\Admin\Desktop\New folder\New folder\New folder")]
        [TestCase(@"C:\Users\Admin\Desktop\New folder")]
        public void TempFileRemover_RemovesEverythingCorrectlyFromDifferentPaths(string path)
        {
            TempFileDeleterService service = new TempFileDeleterService();
            FieldInfo[] fields = typeof(TempFileDeleterService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo count = fields.FirstOrDefault(x => x.Name == "count");
            count.SetValue(service, 0);
            service.TempFileRemover(path);
            Assert.AreEqual(0, count.GetValue(service));
        }


        [TestCase(@"C:\Users\Admin\Desktop\TestFolderReadOnly")]
        public void TempFileRemover_ReturnsCorrectOutputAndCountWhenCantDelete(string path)
        {
            TempFileDeleterService service = new TempFileDeleterService();
            FieldInfo[] fields = typeof(TempFileDeleterService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo count = fields.FirstOrDefault(x => x.Name == "count");
            count.SetValue(service, 0);
            service.TempFileRemover(path);
            Assert.AreEqual(1, count.GetValue(service));
        }
    }
}
