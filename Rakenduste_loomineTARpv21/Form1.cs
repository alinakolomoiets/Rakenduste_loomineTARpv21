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
    public partial class Form1 : Form
    {
        Button Pildi;
        public Form1()
        {
            Height = 720;
            Width = 1280;
            BackColor = Color.LightBlue;
            ForeColor = Color.Black;
            Text = "Peamine Vorm";

            Pildi = new Button();
            Pildi.Text = "Pildi vaata";
            Pildi.ForeColor = Color.Black;
            Pildi.BackColor = Color.White;
            Pildi.Width = 150;
            Pildi.Height = 50;
            Pildi.Location = new Point(150, 300);
            this.Controls.Add(Pildi);
            Pildi.Click += Pildid_Click;
        }
        private void Pildid_Click(object sender, EventArgs e)
        {
            Pildid piltVaatamine = new Pildid();
            piltVaatamine.ShowDialog();
        }
    }
}
