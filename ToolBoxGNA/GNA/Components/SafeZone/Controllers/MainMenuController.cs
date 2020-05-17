using SaveZone.Services.DecryptFileService;
using SaveZone.Services.EncryptFileServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveZone.Controllers
{
    public static class MainMenuController
    {
        private static EncryptFileServicer encryptFile = new EncryptFileServicer();
        private static DecryptFileService decryptFile = new DecryptFileService();

        public static async void SetEncryptFileServicerAsync()
        {
            await Task.Run(() => SetEncryptFileThread(encryptFile));
        }
        public static void SetEncryptFileServicerNonAsync()
        {
            SetEncryptFileThread(encryptFile);
        }
        public async static void SetDecryptFileServicerAsync()
        {
            await Task.Run(() => SetDecryptFileThread(decryptFile));
        }
        public static void SetDecryptFileServicerNonAsync()
        {
            SetDecryptFileThread(decryptFile);
        }
        public static async void PopulateEncryptInformationAsync(TextBox txtBox1, RichTextBox richtxtBox1)
        {
            txtBox1.Text = await Task.Run(() => encryptFile.ShowSourcePath());
            richtxtBox1.Text = await Task.Run(() => encryptFile.ShowEncryptedFile());
        }
        public static void PopulateEncryptInformationNonAsync(TextBox txtBox1, RichTextBox richtxtBox1)
        {
            txtBox1.Text = encryptFile.ShowSourcePath();
            richtxtBox1.Text = encryptFile.ShowEncryptedFile();
        }
        public static async void PopulateDecryptInformationAsync(TextBox txtBox2, RichTextBox richtxtBox1)
        {
            txtBox2.Text = await Task.Run(() => decryptFile.ShowSourcePath());
            richtxtBox1.Text = await Task.Run(() => decryptFile.ShowDecryptedFile());
        }
        public static void PopulateDecryptInformationNonAsync(TextBox txtBox2, RichTextBox richtxtBox1)
        {
            txtBox2.Text = decryptFile.ShowSourcePath();
            richtxtBox1.Text = decryptFile.ShowDecryptedFile();
        }


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
