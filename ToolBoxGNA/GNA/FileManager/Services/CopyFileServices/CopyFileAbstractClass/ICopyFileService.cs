using FileSearcherDemo.BindingModels.SearchFileForm;
using FileSearcherDemo.Entities.BindingModels.CopyFileBindingModel;


namespace FileSearcherDemo.Services.CopyFileServices.CopyFileAbstractClass
{
    /* interface used by CopyFileServiceAbstract for implementing Copy methods*/
    public interface ICopyFileService
    {
        void Copy(string[] files, SearchFileBindingModel searchFileBindingModel);
        void Copy(string[] files, CopyFileBindingModel copyFileBindingModel);
    }
}
