using FileSearcherDemo.BindingModels.SearchFileForm;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace FileSearcherDemo.Services.SearchFileService
{
    /*this class is a service that is used to search for files in a specific directory given by the user*/
    public class SearcherFileService : ISearcherFileService
    {
        public void SetInfo(SearchFileBindingModel searchFileBindingModel)
        {
            //Uses SearchFileBindingModel to get specific information from the binding model and set some properties.

            //Sets DirInfo property of the binding model with the directory choosen from the user to search for files.
            searchFileBindingModel.DirInfo = new DirectoryInfo(searchFileBindingModel.SearchDir);
            //Sets the FileInfo property of the binding model with all the files in the choosen path
            searchFileBindingModel.FileInfo = searchFileBindingModel.DirInfo.GetFiles("*.*");
        }
        public void SetFileDic(SearchFileBindingModel searchFileBindingModel)
        {
            //Uses SearchFileBindingModel to get specific information from the binding model and set some properties.

            //Sets a new dictionary on the FileDic property of the binding model.
            searchFileBindingModel.FileDic = new Dictionary<int, string>();
            for (int i = 0; i < searchFileBindingModel.FileInfo.Length; i++)
            {
                //Adds the name of the file to the dictionary to be filtered
                searchFileBindingModel.FileDic.Add(i, searchFileBindingModel.FileInfo[i].Name);
            }

            //Sets the FilterFoundFiles property and filters the FileDic to return to the user all the files he wants.
            searchFileBindingModel.FilterFoundFiles = searchFileBindingModel.FileDic.Values.Where(s => s.Contains(searchFileBindingModel.SaveFileName)).ToArray();
        }

    }
}
