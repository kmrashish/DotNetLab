using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace TextRead
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyWindow());
            
        }
    }
    public class MyWindow:Form
    {
        int moveX, moveY;
        int L_Click_Status, R_Click_Status;
        public MyWindow():base()
    {
        this.Text = "Mouse Movement Reader";
        this.Size = new Size(400, 400);
        System.Console.WriteLine("something one");
        Shown+=ExecuteClicks;
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        public void ExecuteClicks(object Sender, EventArgs e)
        {
            System.Console.WriteLine("Control in ExecuteClicks");
            string[] myString = System.IO.File.ReadAllLines(@"C:\Users\Ashu\Desktop\Sample.txt");
            moveX = Convert.ToInt32(myString[0]);
            moveY = Convert.ToInt32(myString[1]);
            Cursor.Position = new Point(moveX, moveY);
            L_Click_Status=Convert.ToInt32(myString[2]);
            R_Click_Status=Convert.ToInt32(myString[3]);
            if (L_Click_Status==1)
            {
                System.Console.WriteLine(" Control in Left Click Event ");
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
            } 
            if (R_Click_Status==1)
            {
                System.Console.WriteLine(" Control in Right Click Event ");
                mouse_event((int)(MouseEventFlags.RIGHTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.RIGHTUP), 0, 0, 0, 0);
            }
        }
    }

}
