using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBox_GNA.Controller.Convertor.Entities;

namespace ToolBox_GNA.Controller.Convertor.Services.ImageToPNGService
{
    public class ImageToPNGService : IimageConvertServie
    {


        public void ImageConvert(string input, string output)
        {
            try
            {
                //Gets and saves ImageName and directory
                List<string> file = input.Split('\\').ToList();

                List<string> path = new List<string>();
                for (int i = 0; i < file.Count - 1; i++)
                {
                    path.Add(file[i]);
                }


                DirectoryInfo dirInfo = new DirectoryInfo(string.Join("\\", path));
                FileInfo[] ImageFiles = dirInfo.GetFiles(file.Last());


                //Using foreach for future upgrade where you would convert multiple images at once
                foreach (var image in ImageFiles)
                {


                    //Saves the image
                    string outputpath;
                    string[] separatedPath;
                    ConvertImage(input, output, file, image, out outputpath, out separatedPath);

                    string newDirect = outputpath;
                    string newFileName = separatedPath.Last();

                    ImageToPNG imageToPNG = new ImageToPNG
                    {
                        FileName = newFileName,
                        DirectoryPath = output,
                        OutputDirectory = newDirect,
                        Type = "Image"
                    };

                    string message = "Converting Done!";
                    string title = "Done!";
                    MessageBox.Show(message, title);
                }
            }
            catch (ArgumentNullException)
            {
                
                MessageBox.Show("Path not setted! Please set both Directories!", "Converting error");

            }
        }

        private void ConvertImage(string input, string outputp, List<string> file, FileInfo image, out string outputpath, out string[] separatedPath)
        {
            Image picture = Image.FromFile(input);
            //Sets outputpath
            outputpath = outputp + "\\" + file.Last().Replace(image.Extension, ".png");
            separatedPath = outputpath.Split('\\').ToArray();
            //Saves the file converting it to PNG
            picture.Save(outputpath, ImageFormat.Png);
            //Saves the new name and directory in variables


        }

    }
}
