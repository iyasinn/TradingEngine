using System;
using System.Windows.Forms;

namespace GraphicUI
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of the Form1
            var form = new Form1();

            // Optional: Prevent the form from automatically showing when the program starts
            form.Visible = false;

            // Run the application event loop
            Application.Run();

            // Clean up resources
            form.Dispose();
        }
    }
}
