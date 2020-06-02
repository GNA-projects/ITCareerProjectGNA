using ConverterDemo.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxGNAUnitTesting.Services.Convertor
{
    [TestFixture()]
    public class DocumetConvertorServiceTests
    {
        //TODO: TESTS NEED TO SETUP DIFFERENT PARAMETHERS FOR DIFFERENT MACHINES
        [TestCase(@"C:\Users\Admin\Desktop\TestFolderReadOnly\Test.docx.docx", @"C:\Users\Admin\Desktop\TestFolderReadOnly")]

        public void DocumentConvertor_CorrectCase_SameFolder(string input, string output)
        {
            DocumetConvertorService service = new DocumetConvertorService();
            service.WordToPDFConv(input, output);
            FileAssert.Exists(@"C:\Users\Admin\Desktop\TestFolderReadOnly\Test.pdf.pdf");
        }
        [TestCase(@"C:\Users\Admin\Desktop\TestFolderReadOnly\Test.docx.docx", @"C:\Users\Admin\Desktop\New folder")]
        public void DocumentConvertor_CorrectCase_DifferentOutputFolder(string input, string output)
        {
            DocumetConvertorService service = new DocumetConvertorService();
            service.WordToPDFConv(input, output);
            FileAssert.Exists(@"C:\Users\Admin\Desktop\New folder\Test.pdf.pdf");
        }
        [TestCase(@"C:\Users\Admin\Desktop\TestFolderReadOnly\", @"C:\Users\Admin\Desktop\New folder")]
        public void DocumentConvertor_IncorrectCae_NoFileFound(string input, string output)
        {
            DocumetConvertorService service = new DocumetConvertorService();
            FieldInfo[] fields = typeof(DocumetConvertorService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo field = fields.FirstOrDefault(x => x.Name == "isDone");

            field.SetValue(service, false);
            service.WordToPDFConv(input, output);
            Assert.IsFalse((bool)field.GetValue(service));


        }
        [TestCase(@"C:\Users\Admin\Desktop\TestFolderReadOnly\Test.docx.docx", @"C:\Users\Admin\Desktop\New folder\dox.docx")]
        public void DocumentConvertor_IncorrectCae_OtherException(string input, string output)
        {
            DocumetConvertorService service = new DocumetConvertorService();
            FieldInfo[] fields = typeof(DocumetConvertorService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo field = fields.FirstOrDefault(x => x.Name == "isDone");
            field.SetValue(service, false);
            service.WordToPDFConv(input, output);
            Assert.IsFalse((bool)field.GetValue(service));
        }
    }
}
