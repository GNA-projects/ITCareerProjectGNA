using FileSearcherDemo.Entities.BindingModels.DeleteFileBindingModel;

namespace FileSearcherDemo.Services.DeleteFileServices.DeleteFileServiceF
{
    /* interface used by DeleterFileService for implementing Delete method*/
    public interface IDelete
    {
        void Delete(string[] files, DeleteFileBindingModel deleteFileBindingModel);
    }
}
