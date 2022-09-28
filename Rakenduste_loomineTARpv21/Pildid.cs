using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rakenduste_loomineTARpv21
{
    public partial class Pildid : Form
    {
        Button nupp;
        Button clear_btn;
        Button close_btn;
        Button show_btn;
        PictureBox pilt;
        TableLayoutPanel tableLayoutPanel;
        CheckBox checkBox;
        OpenFileDialog openFileDialog;
        ColorDialog colorDialog;
        PictureBox pictureBox;
        public Pildid()
        {
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Text = "Pildid";
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Files(*.jpg) | *.jpg | PNG Files(*.png) | *.png | BMP Files(*.bmp) | *.bmp | All files(*.*) | *.*";
            colorDialog = new ColorDialog();
            tableLayoutPanel = new TableLayoutPanel
            {
                AutoSize = true,
                ColumnCount=2,
                RowCount=2,
                Location=new System.Drawing.Point(20),
                TabIndex=0,
                BackColor=System.Drawing.Color.LawnGreen,
            };

            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel1";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.TabIndex = 0;

            this.Controls.Add(this.tableLayoutPanel);
            pictureBox = new System.Windows.Forms.PictureBox
            {
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location= new System.Drawing.Point(2, 2),
                Size= new System.Drawing.Size(100,100),
                TabIndex=0,
                TabStop=false,
            };
            checkBox = new CheckBox
            {
                Text = "Stratch",
                AutoSize = true,
            };
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
            tableLayoutPanel.Controls.Add(checkBox , 1 , 0);

            close_btn = new Button
            {
                Text = "Kinni",
            };
            clear_btn = new Button
            {
                Text = "Kustuta",
            };
            show_btn = new Button
            {
                Text = "Näita",
            };
            show_btn.Click += Tegevus;
            clear_btn.Click += Tegevus;
            close_btn.Click += Tegevus;
            Button[] buttons = { clear_btn, show_btn, close_btn };
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void Tegevus(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            if (nupp_sender.Text == "Näita")
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Load(openFileDialog.FileName);
                }
            }
            else if (nupp_sender.Text == "Kustuta")
            {
                pictureBox.Image = null;
            }
            else if (nupp_sender.Text == "Kinni")
            {
                this.Close();
            }
        }
    }
}
