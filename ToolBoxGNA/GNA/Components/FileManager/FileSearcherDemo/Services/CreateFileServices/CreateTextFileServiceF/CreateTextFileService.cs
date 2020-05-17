using FileSearcherDemo.BindingModels.CreateFileForm;
using System.IO;


namespace FileSearcherDemo.Services.CreateFileServices.CreateTextFileServiceF
{
    /* This is a service that creates Text file*/
    public class CreateTextFileService : ICreateTextFileService
    {
        public void Create(CreateFileBindingModel textFileBindingModel)
        {
            //Uses CreateFileBindingModel to get specific information from it. 
            File.Create(textFileBindingModel.DestPath + @"\" + $"{textFileBindingModel.FileName}.txt");
        }
    }
}
