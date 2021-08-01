using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Runtime.InteropServices;

static class Yasuo
{
#if DEBUG
    [DllImport("kernel32.dll", SetLastError = true)]

    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool AllocConsole();

    [DllImport("kernel32.dll")]
    static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    private const int SW_HIDE = 0;
    private const int SW_SHOW = 5;
#endif

    [STAThread]
    static void Main()
    {
#if DEBUG
        AllocConsole();
#endif
        var handle = GetConsoleWindow();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
        {
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show("Please reopen program as an Administrator!",
                    "Yasharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        LastBreath.Intend();
        LastBreath.Resolve();

        if (!LastBreath.IsConnected)
        {
            MessageBox.Show("Could not connect to League, the application will be closed!",
                "Yasharp", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            ShowWindow(handle, SW_HIDE);
            Application.Run(new Yasharp.src.MainForm());

            Task.Run(() => MessageBox.Show("Successfully connected to League!\n" +
                "Please goto chat box and type /help or /?.\n\n" +
                "Notice: creating a new dummy club is recommended.",
                "Yasharp", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }
    }
}
