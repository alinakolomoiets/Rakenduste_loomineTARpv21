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
        PictureBox pilt;
        TableLayoutPanel tableLayoutPanel;
        public Pildid()
        {
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Text = "Pildid";

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

            pilt = new PictureBox()
            {
                Image = new Bitmap("korea.jpeg"),
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(2, 2),
                Size = new System.Drawing.Size(100, 100),
                TabIndex = 0,
                TabStop = false,
            };
            tableLayoutPanel1.Controls.Add(pilt, 0, 0);
            tableLayoutPanel1.SetCellPosition(pilt, new TableLayoutPanelCellPosition(0, 0));
            tableLayoutPanel1.SetColumnSpan(pilt, 2);



        }
    }
}
