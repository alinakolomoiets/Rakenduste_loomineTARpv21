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
        Button sulge;
        Button nupp1;
        Button pildi;
        Button selge;
        CheckBox mruut;
        public Form1()
    
        {
            Height = 600;
            Width = 800;
            Text = "Minu oma vorm koos elementidega";
            BackColor = Color.LightSeaGreen;

            mruut= new CheckBox();
            mruut.Text = "Stretch";
            mruut.Size = new Size(80, 50);
            mruut.Location = new Point(1,510);
            mruut.BackColor = Color.LightBlue;
            mruut.Font = new Font("French Script MT", 10);
            this.Controls.Add(mruut);

            sulge = new Button();
            sulge.Text = "Close";
            sulge.Size = new Size(55, 40);
            sulge.Location = new Point(90,509);
            sulge.BackColor = Color.LightBlue;
            sulge.Font = new Font("French Script MT", 10);
            this.Controls.Add(sulge);

            nupp1 = new Button();
            nupp1.Text = "Set Background Color";
            nupp1.Size = new Size(200, 40);
            nupp1.Location = new Point(150, 509);
            nupp1.BackColor = Color.LightBlue;
            nupp1.Font = new Font("French Script MT", 10);
            this.Controls.Add(nupp1);

            selge = new Button();
            selge.Text = "Clear The Picture";
            selge.Size = new Size(200, 40);
            selge.Location = new Point(355, 509);
            selge.BackColor = Color.LightBlue;
            selge.Font = new Font("French Script MT", 10);
            this.Controls.Add(selge);

            pildi = new Button();
            pildi.Text = "Show The Picture";
            pildi.Size = new Size(200, 40);
            pildi.Location = new Point(560, 509);
            pildi.BackColor = Color.LightBlue;
            pildi.Font = new Font("French Script MT", 10);
            pildi.Click += Pildid_Click;
            this.Controls.Add(pildi);

        }
        private void Pildid_Click(object sender, EventArgs e)
        {
            Pildid piltVaatamine = new Pildid();
            piltVaatamine.ShowDialog();
        }

    }
}
