using FileSearcherDemo.Services.CopyFileServices;
using FileSearcherDemo.Services.CreateFileServices;
using FileSearcherDemo.Services.DeleteFileServices;
using FileSearcherDemo.Services.MoveFileServices;
using FileSearcherDemo.Services.RenameFileService;
using FileSearcherDemo.Services.SearchFileServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearcherDemo.Controllers
{
    /* this is a class that creates instances of all the services and uses them to manipulate input from user
     this class is used only on the Main Form*/
    public static class MainMenuController
    {
        //All the instances of the services needed for the program to run correctly
        private static SearchFileService searchFileService = new SearchFileService();
        private static CopyFileService copyFileService = new CopyFileService();
        private static MoveFileService moveFileService = new MoveFileService();
        private static DeleteFileService deleteFileService = new DeleteFileService();
        private static CreateFileService createFileService = new CreateFileService();
        private static RenameFileService renameFileService = new RenameFileService();

        //Sets a service used for searching files asynchronously
        public static async void SetSearchFileServiceAsync()
        {
            await Task.Run(() => SetSearchFileThread(searchFileService));
        }
        public static void SetSearchFileServiceNonAsync()
        {
             SetSearchFileThread(searchFileService);
        }
        //Method Shows information to the user about searched files asynchronously
        public static async void PopulateSearchInformationAsync(System.Windows.Forms.TextBox txtBox1, System.Windows.Forms.TextBox txtBox2, RichTextBox richtxtBox1, RichTextBox richtxtBox2)
        {
            txtBox1.Text = await Task.Run(() => searchFileService.ShowSourcePath());
            txtBox2.Text = await Task.Run(() => searchFileService.ShowDestPath());
            richtxtBox1.Text = await Task.Run(() => searchFileService.ShowFoundFilesCount());
            richtxtBox2.Text = await Task.Run(() => searchFileService.ShowFoundFilesNames());
        }
        public static void PopulateSearchInformationNonAsync(System.Windows.Forms.TextBox txtBox1, System.Windows.Forms.TextBox txtBox2, RichTextBox richtxtBox1, RichTextBox richtxtBox2)
        {
            txtBox1.Text = searchFileService.ShowSourcePath();
            txtBox2.Text = searchFileService.ShowDestPath();
            richtxtBox1.Text = searchFileService.ShowFoundFilesCount();
            richtxtBox2.Text = searchFileService.ShowFoundFilesNames();
        }

        //Sets a service used for copying files asynchronously
        public static async void SetCopyFileServiceAsync()
        {
            await Task.Run(() => SetCopyFileThread(copyFileService));
        }
        public static void SetCopyFileServiceNonAsync()
        {
            SetCopyFileThread(copyFileService);
        }
        //Method Shows information to the user about copied files asynchronously
        public static async void PopulateCopyInformationAsync(System.Windows.Forms.TextBox txtBox1, System.Windows.Forms.TextBox txtBox2, RichTextBox richtxtBox1, RichTextBox richtxtBox2)
        {
            txtBox1.Text = await Task.Run(() => copyFileService.ShowSourcePath());
            txtBox2.Text = await Task.Run(() => copyFileService.ShowDestPath());
            richtxtBox1.Text = await Task.Run(() => copyFileService.ShowCopyFilesCount());
            richtxtBox2.Text = await Task.Run(() => copyFileService.ShowCopyFilesNames());
        }
        public static void PopulateCopyInformationNonAsync(System.Windows.Forms.TextBox txtBox1, System.Windows.Forms.TextBox txtBox2, RichTextBox richtxtBox1, RichTextBox richtxtBox2)
        {
            txtBox1.Text = copyFileService.ShowSourcePath();
            txtBox2.Text = copyFileService.ShowDestPath();
            richtxtBox1.Text = copyFileService.ShowCopyFilesCount();
            richtxtBox2.Text = copyFileService.ShowCopyFilesNames();
        }

        //Sets a service used for moving files asynchronously
        public static async void SetMoveFileServiceAsync()
        {
            await Task.Run(() => SetMoveFileThread(moveFileService));
        }
        public static void SetMoveFileServiceNonAsync()
        {
             SetMoveFileThread(moveFileService);
        }
        //Method Shows information to the user about moved files asynchronously
        public static async void PopulateMoveInformationAsync(System.Windows.Forms.TextBox txtBox1, System.Windows.Forms.TextBox txtBox2, RichTextBox richtxtBox1, RichTextBox richtxtBox2)
        {
            txtBox1.Text = await Task.Run(() => moveFileService.ShowSourcePath());
            txtBox2.Text = await Task.Run(() => moveFileService.ShowDestPath());
            richtxtBox1.Text = await Task.Run(() => moveFileService.ShowMoveFilesCount());
            richtxtBox2.Text = await Task.Run(() => moveFileService.ShowMoveFilesNames());
        }
        public static void PopulateMoveInformationNonAsync(System.Windows.Forms.TextBox txtBox1, System.Windows.Forms.TextBox txtBox2, RichTextBox richtxtBox1, RichTextBox richtxtBox2)
        {
            txtBox1.Text = moveFileService.ShowSourcePath();
            txtBox2.Text = moveFileService.ShowDestPath();
            richtxtBox1.Text = moveFileService.ShowMoveFilesCount();
            richtxtBox2.Text = moveFileService.ShowMoveFilesNames();
        }

        //Sets a service used for deleting files asynchronously
        public static async void SetDeleteFileServiceAsync()
        {
            await Task.Run(() => SetDeleteFileThread(deleteFileService));
        }
        public static void SetDeleteFileServiceNonAsync()
        {
            SetDeleteFileThread(deleteFileService);
        }
        //Method Shows information to the user about deleted files asynchronously
        public static async void PopulateDeleteInformationAsync(System.Windows.Forms.TextBox txtBox1, RichTextBox richtxtBox1, RichTextBox richtxtBox2)
        {
            txtBox1.Text = await Task.Run(() => deleteFileService.ShowSourcePath());
            richtxtBox1.Text = await Task.Run(() => deleteFileService.ShowDeleteFilesCount());
            richtxtBox2.Text = await Task.Run(() => deleteFileService.ShowDeleteFilesNames());
        }
        public static void PopulateDeleteInformationNonAsync(System.Windows.Forms.TextBox txtBox1, RichTextBox richtxtBox1, RichTextBox richtxtBox2)
        {
            txtBox1.Text = deleteFileService.ShowSourcePath();
            richtxtBox1.Text = deleteFileService.ShowDeleteFilesCount();
            richtxtBox2.Text = deleteFileService.ShowDeleteFilesNames();
        }

        //Sets a service used for creating files asynchronously
        public static async void SetCreateFileServiceAsync()
        {
            await Task.Run(() => SetCreateFileThread(createFileService));
        }
        public static void SetCreateFileServiceNonAsync()
        {
            SetCreateFileThread(createFileService);
        }
        //Method Shows information to the user about creating files asynchronously
        public static async void PopulateCreateInformationAsync(System.Windows.Forms.TextBox txtBox2, RichTextBox richtxtBox1, RichTextBox richtxtBox2)
        {
            txtBox2.Text = await Task.Run(() => createFileService.ShowDestPath());
            richtxtBox1.Text = await Task.Run(() => createFileService.ShowFileName());
            richtxtBox2.Text = await Task.Run(() => createFileService.ShowFileType());
        }
        public static void PopulateCreateInformationNonAsync(System.Windows.Forms.TextBox txtBox2, RichTextBox richtxtBox1, RichTextBox richtxtBox2)
        {
            txtBox2.Text = createFileService.ShowDestPath();
            richtxtBox1.Text = createFileService.ShowFileName();
            richtxtBox2.Text = createFileService.ShowFileType();
        }

        //Sets a service used for renaming a file asynchronously
        public static async void SetRenameFileServiceAsync()
        {
            await Task.Run(() => SetRenameFileThread(renameFileService));
        }
        public static void SetRenameFileServiceNonAsync()
        {
            SetRenameFileThread(renameFileService);
        }
        //Method Shows information to the user about renaming files asynchronously
        public static async void PopulateRenameInformationAsync(System.Windows.Forms.TextBox txtBox1, RichTextBox richtxtBox1, RichTextBox richtxtBox2)
        {
            txtBox1.Text = await Task.Run(() => renameFileService.ShowSourcePath());
            richtxtBox1.Text = await Task.Run(() => renameFileService.ShowOldFileName());
            richtxtBox2.Text = await Task.Run(() => renameFileService.ShowNewName());
        }
        public static void PopulateRenameInformationNonAsync(System.Windows.Forms.TextBox txtBox1, RichTextBox richtxtBox1, RichTextBox richtxtBox2)
        {
            txtBox1.Text = renameFileService.ShowSourcePath();
            richtxtBox1.Text = renameFileService.ShowOldFileName();
            richtxtBox2.Text = renameFileService.ShowNewName();
        }

        //We change the Apartment State of the thread from Multi Thread Apartment(MTA) to Single Thread Apartment (STA) mode
        //Those threads allow the program to run multiple threads while working. 
        //By default the program has only one thread running, so with those threads we make the program multi-functional.
        //Also, if we don't have multi-threading program it gives error when trying to run a thread while other thread is running.
        //The threads are set to be backgound, which means that they are going to stop the service when the program stops.
        private static void SetSearchFileThread(SearchFileService searchFileService)
        {
            Thread thread = new Thread((ThreadStart)(() => { searchFileService.SearchFiles(); }));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
        private static void SetCopyFileThread(CopyFileService copyFileService)
        {
            Thread thread = new Thread((ThreadStart)(() => { copyFileService.CopyFiles(); }));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
        private static void SetMoveFileThread(MoveFileService moveFileService)
        {
            Thread thread = new Thread((ThreadStart)(() => { moveFileService.MoveFiles(); }));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
        private static void SetDeleteFileThread(DeleteFileService deleteFileService)
        {
            Thread thread = new Thread((ThreadStart)(() => { deleteFileService.DeleteFiles(); }));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
        private static void SetCreateFileThread(CreateFileService createFileService)
        {
            Thread thread = new Thread((ThreadStart)(() => { createFileService.CreateFile(); }));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
        private static void SetRenameFileThread(RenameFileService renameFileService)
        {
            Thread thread = new Thread((ThreadStart)(() => { renameFileService.RenameFile(); }));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
    }
}
