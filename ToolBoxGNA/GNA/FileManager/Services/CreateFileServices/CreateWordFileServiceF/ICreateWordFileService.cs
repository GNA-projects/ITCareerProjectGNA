using FileSearcherDemo.BindingModels.CreateFileForm;


namespace FileSearcherDemo.Services.CreateFileServices.CreateWordFileServiceF
{
    /* interface used by CreateFileService for implementing CreateWord method*/
    public interface ICreateWordFileService
    {
        void CreateWord(CreateFileBindingModel createWordFileBindingModel);
    }
}
