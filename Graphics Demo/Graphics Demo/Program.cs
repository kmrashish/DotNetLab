using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
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
    class MyWindow : Form
    {

        string msg;
        TextBox tb = new TextBox();
        public MyWindow():base()
        {
            this.Text = "Graphics Demo";
            this.Size = new Size(600, 600);
            Button b1=new Button();
            b1.Location = new Point(100, 200);
            this.Controls.Add(b1);
            b1.Click += CreateLine;
            b1.Text = "Line";
            Button b2 = new Button();
            b2.Location = new Point(300, 500);
            this.Controls.Add(b2);
            b2.Text = " Draw Text";
            b2.Click += DisplayText;
            this.BackColor = Color.White;
            
            tb.Location = new Point(200, 500);
            this.Controls.Add(tb);
            msg = tb.Text;

           // TextBox startPointInput = new TextBox();
           // startPointInput.Location=new Point(
            
        }

        void CreateLine(object sender, EventArgs e)
        {
            System.Drawing.Pen myPen = new Pen(Color.Red);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, 50, 180, 250, 180);
            myPen.Color = Color.Green;
            formGraphics.DrawLine(myPen, 70, 20, 70, 200);
            myPen.Dispose();
            formGraphics.Dispose();
        }

        void DisplayText(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
           // string myString = ".NET Framework";
            msg = tb.Text;
            Font myFont = new Font("Arial", 20);
            Pen myPen = new Pen(Color.Red);
            SolidBrush myBrush = new SolidBrush(Color.CornflowerBlue);
            formGraphics.DrawString(msg, myFont, myBrush, 50, 10);
            myBrush.Dispose();
            myPen.Dispose();
            myFont.Dispose();
            formGraphics.Dispose();

        }

    }
}
