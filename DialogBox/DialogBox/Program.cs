using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DialogBox
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
        Button b1 = new Button();
        Button b2 = new Button();
        Button b3 = new Button();
        Button b4 = new Button();

        TextBox tb;

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        FontDialog fd = new FontDialog();
        ColorDialog cd = new ColorDialog();
        string msg;

        public MyWindow()
            : base()
        {
            this.Text = "DIALOG BOX";
            this.Size = new Size(700, 700);
            this.StartPosition = FormStartPosition.CenterParent;
            tb = new TextBox();
            b1.Text = "File Open Dialog Box";
            b2.Text = " File Save As Dialog Box";
            b3.Text = " Font Dialog Box";
            b4.Text = "Color Dialog Box";

            tb.Location = new Point(100, 100);
            b1.Location = new Point(100, 200);
            b2.Location = new Point(100, 300);
            b3.Location = new Point(100, 400);
            b4.Location = new Point(100, 500);

            

            tb.Size = new Size(150, 50);
            b1.Size = new Size(150, 50);
            b2.Size = new Size(150, 50);
            b3.Size = new Size(150, 50);
            b4.Size = new Size(150, 50);
            this.Controls.AddRange(new Control[] { b1, b2, b3, b4, tb });
            this.BackColor=Color.Aquamarine;

            b1.Click += b1_Click;
            b2.Click += b2_Click;
            b3.Click += b3_Click;
            b4.Click += b4_Click;





        }

        void b4_Click(object sender, EventArgs e)
        {
            DialogResult rs = cd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                tb.ForeColor = cd.Color;
            }
        }

        void b3_Click(object sender, EventArgs e)
        {
            DialogResult rs = fd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                tb.Font = fd.Font;
                tb.ForeColor = fd.Color;
            }
        }

        void b2_Click(object sender, EventArgs e)
        {
            DialogResult rs = sfd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                MessageBox.Show(sfd.FileName, "Save As Dialog Box", MessageBoxButtons.YesNo);
            }
        }

        void b1_Click(object sender, EventArgs e)
        {
            DialogResult rs = ofd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName, "File Open Dialog Box", MessageBoxButtons.YesNo);
            }
        }
    }


}
