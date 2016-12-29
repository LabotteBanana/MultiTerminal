using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTerminal
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private metroUserControl1 usercontrol1 = new metroUserControl1();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            usercontrol1.Init();
           Controls.Add(usercontrol1);
            usercontrol1.Show();
        }
        [Docking(DockingBehavior.Ask)]
        public class metroUserControl1 : MetroFramework.Controls.MetroUserControl
        {
            public MetroFramework.Controls.MetroLabel metroLabel1;
            public MetroFramework.Controls.MetroLabel metroLabel2;
            public MetroFramework.Controls.MetroLabel metroLabel3;
            public MetroFramework.Controls.MetroLabel metroLabel4;

            public MetroFramework.Controls.MetroButton metroButton1;

            public MetroFramework.Controls.MetroTextBox metroTextBox1;
            public MetroFramework.Controls.MetroTextBox metroTextBox2;
            public MetroFramework.Controls.MetroTextBox metroTextBox3;
            public MetroFramework.Controls.MetroTextBox metroTextBox4;
            public MetroFramework.Controls.MetroTextBox metroTextBox5;

            private Size controlSize = new Size(30, 40);
            private Size controlSize2 = new Size(60, 90);
            public metroUserControl1()
            {

            }
            public void Init()
            {

                Location = new System.Drawing.Point(5, 368);
                Name = "metroUserControl1";
                Size = new System.Drawing.Size(300, 340);
                TabIndex = 2;
                Theme = MetroFramework.MetroThemeStyle.Dark;
                //metroLabel1 = new MetroFramework.Controls.MetroLabel();
                //metroLabel2 = new MetroFramework.Controls.MetroLabel();
                //metroLabel3 = new MetroFramework.Controls.MetroLabel();
                //metroLabel4 = new MetroFramework.Controls.MetroLabel();
                //metroButton1 = new MetroFramework.Controls.MetroButton();
                //metroButton1.Location = new Point(5, 10);
                
                metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
                metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
                metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
                metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
                metroTextBox5 = new MetroFramework.Controls.MetroTextBox();

                metroTextBox1.Location = new Point(15, 10);
                metroTextBox2.Location = new Point(35, 10);
                metroTextBox3.Location = new Point(55, 30);
                metroTextBox4.Location = new Point(65, 80);
                metroTextBox5.Location = new Point(105, 150);

                metroTextBox1.Size = controlSize;
                metroTextBox2.Size = controlSize;
                metroTextBox3.Size = controlSize;
                metroTextBox4.Size = controlSize;
                metroTextBox5.Size = controlSize;

                this.Controls.Add(metroTextBox1);
                this.Controls.Add(metroTextBox2);
                this.Controls.Add(metroTextBox3);
                this.Controls.Add(metroTextBox4);
                this.Controls.Add(metroTextBox5);

                metroTextBox1.Show();
                metroTextBox2.Show();
                metroTextBox3.Show();
                metroTextBox4.Show();

                metroTextBox4.Text = "쒸발";
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroTextBox6.Text = usercontrol1.metroTextBox4.Text;
        }
    }
}
