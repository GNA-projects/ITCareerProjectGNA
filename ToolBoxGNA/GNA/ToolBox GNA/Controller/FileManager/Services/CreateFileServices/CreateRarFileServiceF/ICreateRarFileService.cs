using FileSearcherDemo.BindingModels.CreateFileForm;


namespace FileSearcherDemo.Services.CreateFileServices.CreateRarFileServiceF
{
    /* interface used by CreateFileService for implementing CreateRar method*/
    public interface ICreateRarFileService
    {
        void CreateRar(CreateFileBindingModel createRarFileBindingModel);
    }
}
