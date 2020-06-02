using DatabaseOperations;
using FileSearcherDemo.BindingModels.SearchFileForm;
using FileSearcherDemo.Services.SearchFileServices;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToolBoxGNAUnitTesting.Services.FileManager
{
    class SearchSericeTests
    {
        //TODO: TESTS NEED TO SETUP DIFFERENT PARAMETHERS FOR DIFFERENT MACHINES
        [TestCase(@"E:\Star Wars Jedi Fallen Order", 16)]
        [TestCase(@"C:\Users\Nikih\Desktop\Recources 2", 1)]
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

        [TestCase(@"C:\Users\Nikih\Desktop\Recources 2", "i da padnem", 1)]
        [TestCase(@"C:\Users\Nikih\Desktop\Recources 2", "a", 3)]
        public void FilesFilteredCorrectlyWhenEnteredNameForSearching(string path, string fileName, int foundFilesCount)
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

        [TestCase(@"C:\Users\Nikih\Desktop\aaa", "test", 0)]
        [TestCase(@"C:\Users\Nikih\Desktop\aaa", "Alex", 0)]
        public void NoneFilteredFilesFoundInTheDirectory(string path, string fileName, int foundFilesCount)
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

        [TestCase(@"C:\Users\Nikih\Desktop\Recources 2")]
        public void SourcePathSetCorrectlly(string path)
        {
            SearchFileService searchService = new SearchFileService();
            FieldInfo[] fields = typeof(SearchFileService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo sourcePath = fields.FirstOrDefault(x => x.Name == "sourcePath");
            sourcePath.SetValue(searchService, path);
            Thread thread = new Thread((ThreadStart)(() => { searchService.SearchFiles(); }));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
            CurrentUser.user.username = "Test";

            Assert.AreEqual(path, sourcePath.GetValue(searchService));

        }

    }
}
