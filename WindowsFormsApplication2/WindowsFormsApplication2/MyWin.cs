using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usit
{

    public partial class MyWin : Form
    {
       // int value1;
        //int value2;
        //int sum;
                    TreeView tv = new TreeView();
                    ListView lv = new ListView();   

        
        public MyWin()
            : base()
        {
            this.Text = "Form One";
            this.Size = new Size(600, 600);
            Label lb = new Label();
            lb.Text = "USICT";
            lb.ForeColor = System.Drawing.Color.Red;
            lb.Location = new Point(180, 20);
            this.Controls.Add(lb);
            Button b1 = new Button();
            b1.Text = "Exit";
            b1.Location = new Point(150, 200);
            this.Controls.Add(b1);
            b1.Click += new EventHandler(exitButtonOnClick);
            TextBox tb1 = new TextBox();
            tb1.Location = new Point(50, 75);
            TextBox tb2 = new TextBox();
            tb2.Location = new Point(150, 75);
            TextBox tb3 = new TextBox();
            tb3.Location = new Point(50, 100);
            Button b2 = new Button();
            b2.Text = "Find the Sum";
            b2.Click += new EventHandler(findSumButtonOnClick);
            this.Controls.AddRange(new Control[] { tb1, tb2, tb3, b2 });
            ComboBox lb1 = new ComboBox();
            lb1.Items.AddRange(new String[] { "JNU", "DU", "USIT" });
            this.Controls.Add(lb1);
            lb1.Location = new Point(200, 230);
            ListBox lb2 = new ListBox();
            lb2.Items.AddRange(new string[] { "JNU", "DU", "USIT" });
            this.Controls.Add(lb2);
            lb2.Location = new Point(100, 200);
            //var value = this.tb1.Text;
            //this.value1 = tb1.Text;
            //this.value1 = Convert.ToInt32(tb1.Text);
            //this.value1 = int.Parse(tb1.Text);
            //value = this.tb2.Text;
            //this.value2 = Convert.ToInt32(tb2.Text);
            //this.value2 = int.Parse(tb2.Text);
            //this.sum = value1 + value2;
           // this.StartPosition = FormStartPosition.CenterScreen;*/
            this.Text = "Form One";
            tv.Nodes.Clear();
            tv.Nodes.Add("USS");
            TreeNode tn = new TreeNode("USICT");
            tv.Nodes.Add("Staff");
            tv.Nodes.Add("Other");
            TreeNode subnode1 = tn.Nodes.Add("Teaching");
            TreeNode subnode2 = tn.Nodes.Add("Non-Teaching");
            tv.Nodes[0].Nodes.Add(tn);
            Button b3 = new Button();
            b3.Text = "Show Selection";
            b3.Size = new Size(100, 50);
            b3.Location = new Point(150, 150);
            this.Controls.AddRange(new Control[] { tv, b3 });
            b3.Click += theNewButtonClick;
            lv.Location = new Point(300, 300);
            lv.Items.Add("USIT");
            lv.Items.Add("USBS");
            lv.Items.Add("USMS");
            lv.Items.Add("USLLS");
            Button b4=new Button();
            b4.Text="Select";
            b4.Location=new Point(150, 250);
            b4.Size=new Size(100,50);
            this.Controls.Add(b4);
            this.Controls.Add(lv);
            System.Windows.Forms.ToolTip tp=new System.Windows.Forms.ToolTip();
            tp.SetToolTip(b4, "This is button");
            this.BackColor=System.Drawing.Color.AntiqueWhite;
            b4.Click+=new EventHandler(b4Click);


        }

        private void MyWin_Load(object sender, EventArgs e)
        {
            //this.text = "Form One";
        }
        public void exitButtonOnClick(object sender, EventArgs e)
        {
            MessageBox.Show("Application Closing", "USICT");
            Application.Exit();
        }

        public void findSumButtonOnClick(object sender, EventArgs e)
        {
           // MessageBox.Show("the sum is "+sum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void b4Click(object sender, EventArgs e)
        {
            MessageBox.Show(lv.SelectedItems[0].Text);
            Application.Exit();
        }

        public void theNewButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Item: " +tv.SelectedNode.Text);
            //Application.Exit();
        }
    }

    class Win
    {
        static void Main()
        {
            Application.Run(new MyWin());
        }
    }
}


        

       
 
