using SaveZone.Services.DecryptFileService;
using SaveZone.Services.EncryptFileServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveZone.Controllers
{
    /* this is a class that creates instances of all the services and uses them to manipulate input from user
     this class is used only on the Main Form*/
    public static class MainMenuController
    {
        //All the instances of the services needed for the program to run correctly
        private static EncryptFileServicer encryptFile = new EncryptFileServicer();
        private static DecryptFileService decryptFile = new DecryptFileService();

        //Sets a service used for encrypting files asynchronously
        public static Task SetEncryptFileServicerAsync()
        {
             return Task.Run(() => SetEncryptFileThread(encryptFile));
        }

        //Sets synchonous method of SetEncryptFileServicerAsync
        public static void SetEncryptFileServicerNonAsync()
        {
            SetEncryptFileThread(encryptFile);
        }

        //Sets a service used for decrypting files asynchronously
        public async static Task SetDecryptFileServicerAsync()
        {
            await Task.Run(() => SetDecryptFileThread(decryptFile));
        }

        //Sets synchonous method of SetDecryptFileServicerAsync
        public static void SetDecryptFileServicerNonAsync()
        {
            SetDecryptFileThread(decryptFile);
        }

        //Shows the encrypted file and its directory to the user
        public static async void PopulateEncryptInformationAsync(TextBox txtBox1, RichTextBox richtxtBox1)
        {
            txtBox1.Text = await Task.Run(() => encryptFile.ShowSourcePath());
            richtxtBox1.Text = await Task.Run(() => encryptFile.ShowEncryptedFile());
        }

        //Sets synchonous method of PopulateEncryptInformationAsync
        public static void PopulateEncryptInformationNonAsync(TextBox txtBox1, RichTextBox richtxtBox1)
        {
            txtBox1.Text = encryptFile.ShowSourcePath();
            richtxtBox1.Text = encryptFile.ShowEncryptedFile();
        }

        //Shows the decrypted file and its directory to the user
        public static async void PopulateDecryptInformationAsync(TextBox txtBox2, RichTextBox richtxtBox1)
        {
            txtBox2.Text = await Task.Run(() => decryptFile.ShowSourcePath());
            richtxtBox1.Text = await Task.Run(() => decryptFile.ShowDecryptedFile());
        }

        //Sets synchonous method of PopulateDecryptInformationAsync
        public static void PopulateDecryptInformationNonAsync(TextBox txtBox2, RichTextBox richtxtBox1)
        {
            txtBox2.Text = decryptFile.ShowSourcePath();
            richtxtBox1.Text = decryptFile.ShowDecryptedFile();
        }

        //We change the Apartment State of the thread from Multi Thread Apartment(MTA) to Single Thread Apartment (STA) mode
        //Those threads allow the program to run multiple threads while working. 
        //By default the program has only one thread running, so with those threads we make the program multi-functional.
        //Also, if we don't have multi-threading program it gives error when trying to run a thread while other thread is running.
        //The threads are set to be backgound, which means that they are going to stop the service when the program stops.
        private static void SetEncryptFileThread(EncryptFileServicer encryptFileService)
        {
            Thread thread = new Thread((ThreadStart)(() => { encryptFileService.EncryptFile(); }));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
        private static void SetDecryptFileThread(DecryptFileService decryptFileService)
        {
            Thread thread = new Thread((ThreadStart)(() => { decryptFileService.DecryptFile(encryptFile); }));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

    }
}
