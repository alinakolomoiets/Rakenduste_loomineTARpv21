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
    public partial class Sobitamise_mäng : Form
    {

        Label lbl;
        List<string> icons = new List<string>()
            {
                "!", "!", "N", "N", ",", ",", "k", "k",
                 "b", "b", "v", "v", "w", "w", "z", "z"
            };
        Random random = new Random();
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public Sobitamise_mäng()
        {
           
            this.Size = new System.Drawing.Size(550, 550);
            this.Text = "Piltide Leidmise Mäng";
            this.MaximizeBox = false;

            tableLayoutPanel1 = new TableLayoutPanel()
            {
                ColumnCount = 4,
                Location = new System.Drawing.Point(3, 4),
                Name = "tableLayoutPanel1",
                RowCount = 4,
                Size = new System.Drawing.Size(527, 506),
                TabIndex = 0,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset,
                BackColor = System.Drawing.Color.CornflowerBlue,
            };

        TableLayoutPanel tableLayoutPanel;
        public Sobitamise_mäng()
        {
            this.Size = new Size(550, 550);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();

            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));

            this.tableLayoutPanel1.Location = new System.Drawing.Point(159, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;

            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));

            this.Controls.Add(this.tableLayoutPanel1);

            for (int i = 0; i < 16; i++)
            {

            }
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font=new System.Drawing.Font("Webdings",48, System.Drawing.FontStyle.Bold),
            //    Text="c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 0, 0);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "w",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 0, 1);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "!",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 0, 2);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 0, 3);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 1, 0);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 1, 1);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 1, 2);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 1, 3);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 2, 0);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 2, 1);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 2, 2);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 2, 3);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 3, 0);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 3, 1);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 3, 2);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl, 3, 3);
            //lbl = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //lbl.Click += label1_Click;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                clickedLabel.ForeColor = Color.Black;
            }
        }

            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 296);
            this.tableLayoutPanel1.TabIndex = 0;
            this.Controls.Add(this.tableLayoutPanel);

        }


    }
}

