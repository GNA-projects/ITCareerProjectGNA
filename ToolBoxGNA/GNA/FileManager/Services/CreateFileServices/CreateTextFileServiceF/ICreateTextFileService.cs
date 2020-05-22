using FileSearcherDemo.BindingModels.CreateFileForm;

namespace FileSearcherDemo.Services.CreateFileServices.CreateTextFileServiceF
{
    /* interface used by CreateFileService for implementing Create method*/
    public interface ICreateTextFileService
    {
        void Create(CreateFileBindingModel textFileBindingModel);
    }
}