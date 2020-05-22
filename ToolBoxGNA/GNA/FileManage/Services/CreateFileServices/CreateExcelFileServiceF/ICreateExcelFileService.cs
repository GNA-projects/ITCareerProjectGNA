using FileSearcherDemo.BindingModels.CreateFileForm;


namespace FileSearcherDemo.Services.CreateFileServices.CreateExcelFileServiceF
{
    /* interface used by CreateFileService for implementing CreateExcel method*/
    public interface ICreateExcelFileService
    {
        void CreateExcel(CreateFileBindingModel createExcelFileBindingModel);
    }
}
