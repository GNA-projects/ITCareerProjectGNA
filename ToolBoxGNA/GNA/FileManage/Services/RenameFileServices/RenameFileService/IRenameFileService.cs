using FileSearcherDemo.BindingModels.RenameFileForm;


namespace FileSearcherDemo.Services.RenameFileService
{
    /* interface used by RenamerFileService for implementing Rename method*/
    public interface IRenameFileService
    {
        void Rename(RenameFileBindingModel renameFileBindingModel);
    }
}
