using FileSearcherDemo.BindingModels.SearchFileForm;


namespace FileSearcherDemo.Services.SearchFileService
{
    /* interface used by SearcherFileService for implementing methods for searching*/
    public interface ISearcherFileService
    {
        void SetInfo(SearchFileBindingModel searchFileBindingModel);
        void SetFileDic(SearchFileBindingModel searchFileBindingModel);
    }
}
