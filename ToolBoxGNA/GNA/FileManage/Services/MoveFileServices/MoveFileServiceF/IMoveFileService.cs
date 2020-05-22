using FileSearcherDemo.Entities.BindingModels.MoveFileBindingModel;


namespace FileSearcherDemo.Services.MoveFileServices.MoveFileServiceF
{
    /* interface used by MoveFileService for implementing Move method*/
    public interface IMoveFileService
    {
        void Move(string[] files, MoveFileBindingModel moveFileBindingModel);
    }
}
