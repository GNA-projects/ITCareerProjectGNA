using FileSearcherDemo.BindingModels.CreateFileForm;
using Excel = Microsoft.Office.Interop.Excel;
namespace FileSearcherDemo.Services.CreateFileServices.CreateExcelFileServiceF
{
    /* This is a service that creates Excel file*/
    public class CreateExelFileService : ICreateExcelFileService
    {
        public void CreateExcel(CreateFileBindingModel createExcelFileBindingModel)
        {
            //Uses CreateFileBindingModel to get specific information from it. 

            //Creates a excel application that runs in the background.
            //In the background the application adds the things it needs to be opened after being created.
            Excel.Application objExcelApplication = new Excel.Application();
            Excel.Workbook excelWorkbook = objExcelApplication.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet excelWorksheet = excelWorkbook.Worksheets[1];

            //After the user has given a directory and a name for the file, it is saved there with that name.
            excelWorkbook.SaveAs(createExcelFileBindingModel.DestPath + @"\" + $"{createExcelFileBindingModel.FileName}");

            //This closes the created in the background application and quits it.
            excelWorkbook.Close();
            objExcelApplication.Quit();
        }
    }
}
