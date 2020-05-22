using FileSearcherDemo.BindingModels.CreateFileForm;

namespace FileSearcherDemo.Services.CreateFileServices.CreatePowerPointFileServiceF
{
    /* interface used by CreateFileService for implementing CreatePowerPoint method*/
    public interface ICreatePowerPointFileService
    {
        void CreatePowerPoint(CreateFileBindingModel createPPBindingmodel);
    }
}
