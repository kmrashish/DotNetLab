using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ClassAssignment
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
        Label empIdLabel = new Label();
        Label empNameLabel = new Label();
        Label empAgeLabel = new Label();
        Label empGenderLabel = new Label();
        Label empDesignationLabel = new Label();
        Label empPhoneLabel = new Label();
        Label empEmailLabel = new Label();

        TextBox empIDInput = new TextBox();
        TextBox empNameInput = new TextBox();

        DateTimePicker empAgeInput = new DateTimePicker();

        GroupBox groupbox1 = new GroupBox();
        RadioButton rbMale = new RadioButton();
        RadioButton rbFemale = new RadioButton();

        ListBox empDesignationInput = new ListBox();

        TextBox empPhoneInput = new TextBox();
        TextBox empEmailInput = new TextBox();

        Button OkButton = new Button();
        Button CButton = new Button();
        String msg;

        public MyWindow()
            : base()
        {
            this.Text = "EMPLOYEE PROFILE FORM";
            this.Size = new Size(700, 700);
            this.BackColor = Color.AntiqueWhite;
            this.StartPosition = FormStartPosition.CenterScreen;

            empIdLabel.Location = new Point(100, 100);
            empIdLabel.Text = "EMPLOYEE ID";
            this.Controls.Add(empIdLabel);

            empIDInput.Location = new Point(250, 100);
            this.Controls.Add(empIDInput);

            empNameLabel.Location = new Point(100, 150);
            empNameLabel.Text = "EMPLOYEE NAME";
            this.Controls.Add(empNameLabel);

            empNameInput.Location = new Point(250, 150);
            this.Controls.Add(empNameInput);

            empAgeLabel.Location = new Point(100, 200);
            empAgeLabel.Text = "EMPLOYEE D.O.B.";

            empAgeInput.Location = new Point(250, 200);
            this.Controls.AddRange(new Control[] { empAgeLabel, empAgeInput });

            ToolTip tp = new ToolTip();
            tp.SetToolTip(empAgeInput, "Select Employee's Date of Birth");

            empGenderLabel.Location = new Point(100, 250);
            empGenderLabel.Text = "EMPLOYEE GENDER";
            empGenderLabel.Size = new Size(150,50);
            this.Controls.Add(empGenderLabel);

            rbMale.Location = new Point(250, 250);
            rbMale.Text = "Male";
            this.Controls.Add(rbMale);

            rbFemale.Location = new Point(250, 275);
            rbFemale.Text = "Female";
            this.Controls.Add(rbFemale);

            

            empDesignationLabel.Location = new Point(100, 320);
            empDesignationLabel.Text = "EMPLOYEE DESIGNATION";
            empDesignationLabel.Size = new Size(150, 50);
            this.Controls.Add(empDesignationLabel);

            empDesignationInput.Location = new Point(250, 320);
            empDesignationInput.Items.AddRange(new string[]
            {
                "Software Developer",
                "Project Manager", 
                "System Analyst", 
                "CEO"});
            empDesignationInput.Size=new Size(150, 80);
            this.Controls.Add(empDesignationInput);

            empPhoneLabel.Location = new Point(100, 420);
            empPhoneLabel.Text = "EMPLOYEE PHONE";
            empPhoneLabel.Size = new Size(150, 50);
            this.Controls.Add(empPhoneLabel);

            empPhoneInput.Location = new Point(250, 420);
            this.Controls.Add(empPhoneInput);

            empEmailLabel.Location = new Point(100, 470);
            empEmailLabel.Text = "EMPLOYEE EMAIL ID";
            empEmailLabel.Size = new Size(150, 50);
            this.Controls.Add(empEmailLabel);

            empEmailInput.Location = new Point(250, 470);
            this.Controls.Add(empEmailInput);

            OkButton.Text = "OK";
            OkButton.Click += OkButtonClicked;
            OkButton.Location = new Point(250, 520);
            this.Controls.Add(OkButton);

            CButton.Text = "CANCEL";
            CButton.Click += CButtonClicked;
            CButton.Location = new Point(350, 520);
            this.Controls.Add(CButton);
        }
        
        public  void OkButtonClicked(Object Sender, EventArgs e)
        {
            msg= " Employee ID: "+ empIDInput.Text;
            msg += "\n\n Name: " + empNameInput.Text;

            msg += "\n\n Date of Birth: " + empAgeInput.Value.Day.ToString()+"-"+empAgeInput.Value.Month.ToString()+"-"+empAgeInput.Value.Year.ToString();

            string gender = "";
            bool isChecked = rbMale.Checked;
            if (isChecked)
                gender = rbMale.Text;
            else
                gender = rbFemale.Text;

            msg += "\n\n Designation: " + empDesignationInput.SelectedItem;
            msg += "\n\n Gender: " + gender;
            msg += "\n\n Phone: " + empPhoneInput.Text;
            msg += "\n\n Email ID: " + empEmailInput.Text;
            MessageBox.Show(msg);
        }

        public void CButtonClicked(Object Sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
