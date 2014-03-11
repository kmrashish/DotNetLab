using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MenuBar
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
    public class MyWindow : Form
    {
        public MyWindow():base()
        {
            Menu = new MainMenu();
            Menu.MenuItems.Add("File");
            Menu.MenuItems.Add("Edit");
            Menu.MenuItems.Add("View");
            Menu.MenuItems.Add("Help");


            Bitmap bm = new Bitmap(GetType(), "SimpleToolbar.bmp");
            ImageList imglist = new ImageList();
            imglist.Images.AddStrip(bm);
            imglist.TransparentColor = Color.LightBlue;
            ToolBar tb = new ToolBar();
            tb.Parent = this;
            tb.ShowToolTips = true;
            string[] astr = { "New", "Open", "Save", "Print", "Cut", "Copy", "Paste" };
            for (int i = 0; i < 7; i++)
            {
                ToolBarButton tbb = new ToolBarButton();
                tbb.ImageIndex = i;
                tbb.ToolTipText = astr[i];
                tb.Buttons.Add(tbb);
            }
        }
    }
}
