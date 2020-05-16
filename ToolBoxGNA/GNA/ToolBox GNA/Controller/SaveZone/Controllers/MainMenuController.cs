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

        public async static Task SetEncryptFileServicerAsync()
        {
            await Task.Run(() => SetEncryptFileThread(encryptFile));
        }
        public async static Task SetDecryptFileServicerAsync()
        {
            await Task.Run(() => SetDecryptFileThread(decryptFile));
        }
        public static async Task PopulateEncryptInformation(TextBox txtBox1, RichTextBox richtxtBox1)
        {
            txtBox1.Text = await Task.Run(() => encryptFile.ShowSourcePath());
            richtxtBox1.Text = await Task.Run(() => encryptFile.ShowEncryptedFile());
        }
        public static async Task PopulateDecryptInformation(TextBox txtBox2, RichTextBox richtxtBox1)
        {
            txtBox2.Text = await Task.Run(() => decryptFile.ShowSourcePath());
            richtxtBox1.Text = await Task.Run(() => decryptFile.ShowDecryptedFile());
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
