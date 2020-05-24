using FileSearcherDemo.BindingModels.SearchFileForm;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToolBoxGNAUnitTesting.Services.FileManager
{
    [TestFixture]
    public class FileManagerTests
    {
        [TestCase(@"E:\Star Wars Jedi Fallen Order", 16)]
        [TestCase(@"C:\Users\Nikih\Desktop\Recources 2", 3)]
        public void GetsAllFilesFromTheDictionary(string path, int filesCount)
        {
            SearchFileBindingModel searchFileBindingModel = new SearchFileBindingModel();

            searchFileBindingModel.DirInfo = new DirectoryInfo(path);
            searchFileBindingModel.FileInfo = searchFileBindingModel.DirInfo.GetFiles("*.*");

            Assert.AreEqual(searchFileBindingModel.FileInfo.Length, filesCount);
        }

        [TestCase(@"C:\Users\Nikih\Desktop\aaa", 0)]
        public void FileInfoLenghtIsZeroWhenNoneFilesFoundInTheDirectory(string path, int filesCount)
        {
            SearchFileBindingModel searchFileBindingModel = new SearchFileBindingModel();

            searchFileBindingModel.DirInfo = new DirectoryInfo(path);
            searchFileBindingModel.FileInfo = searchFileBindingModel.DirInfo.GetFiles("*.*");

            Assert.AreEqual(searchFileBindingModel.FileInfo.Length, filesCount);
        }

        [TestCase(@"C:\Users\Nikih\Desktop\Recources 2","i da padnem", 1)]
        [TestCase(@"C:\Users\Nikih\Desktop\Recources 2","a",3)]
        public void FilesFilteredCorrectlyWhenEnteredNameForSearching(string path,string fileName,int foundFilesCount)
        {
            SearchFileBindingModel searchFileBindingModel = new SearchFileBindingModel();
            searchFileBindingModel.DirInfo = new DirectoryInfo(path);
            searchFileBindingModel.FileInfo = searchFileBindingModel.DirInfo.GetFiles("*.*");

            searchFileBindingModel.FileDic = new Dictionary<int, string>();
            for (int i = 0; i < searchFileBindingModel.FileInfo.Length; i++)
            {
                searchFileBindingModel.FileDic.Add(i, searchFileBindingModel.FileInfo[i].Name);
            }
            searchFileBindingModel.SaveFileName = fileName;
            searchFileBindingModel.FilterFoundFiles = searchFileBindingModel.FileDic.Values.Where(s => s.Contains(searchFileBindingModel.SaveFileName)).ToArray();

            Assert.AreEqual(searchFileBindingModel.FilterFoundFiles.Length, foundFilesCount);
        }

        [TestCase(@"C:\Users\Nikih\Desktop\Resources","test", 0)]
        [TestCase(@"C:\Users\Nikih\Desktop\Resources", "Alex", 0)]
        public void NoneFilteredFilesFoundInTheDirectory(string path,string fileName,int foundFilesCount)
        {
            SearchFileBindingModel searchFileBindingModel = new SearchFileBindingModel();
            searchFileBindingModel.DirInfo = new DirectoryInfo(path);
            searchFileBindingModel.FileInfo = searchFileBindingModel.DirInfo.GetFiles("*.*");

            searchFileBindingModel.FileDic = new Dictionary<int, string>();
            for (int i = 0; i < searchFileBindingModel.FileInfo.Length; i++)
            {
                searchFileBindingModel.FileDic.Add(i, searchFileBindingModel.FileInfo[i].Name);
            }
            searchFileBindingModel.SaveFileName = fileName;
            searchFileBindingModel.FilterFoundFiles = searchFileBindingModel.FileDic.Values.Where(s => s.Contains(searchFileBindingModel.SaveFileName)).ToArray();

            Assert.AreEqual(searchFileBindingModel.FilterFoundFiles.Length, foundFilesCount);
        }

    }
}
