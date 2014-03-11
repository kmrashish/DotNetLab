using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Handling_Mouse_and_Keyboard_Events
{
    
    public class MyWindow : Form
    {
        public MyWindow()
            : base()
        {
            Top = 100;
            Left = 75;
            Height = 100;
            Width = 500;
            this.Text = "My Event Handling";
            this.MouseUp += new MouseEventHandler(OnMouseUp);
            this.MouseMove += new MouseEventHandler(OnMouseMove);
            this.KeyUp += new KeyEventHandler(OnKeyUp);
            this.Size = new Size(400, 400);
            this.BackColor = Color.AntiqueWhite;
        }
        protected void OnMouseUp(Object Sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left){
                MessageBox.Show("Left Click");
            }
            else if(e.Button==MouseButtons.Right){
                MessageBox.Show("Right Click");
            }
            else if(e.Button==MouseButtons.Middle){
                MessageBox.Show("Middle Click");
            }
        }
        protected void OnMouseMove(Object Sender, MouseEventArgs e)
        {
            this.Text="Current Position: ("+e.X+","+e.Y+")";
        }
        public void OnKeyUp(Object Sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString(), " Key Pressed");
        }

        }
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
    }
