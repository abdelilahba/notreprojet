using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ideapro_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox_user.Text == "222")
            {
                guna2CirclePictureBox_prof.Image = Properties.Resources.images__1_;
                guna2Transition1.Show(guna2CirclePictureBox_prof);

            }
            if (guna2TextBox_user.Text == "ismailelhadad3@gmail.com")
            {
                guna2CirclePictureBox_prof.Image = Properties.Resources.images__1_;
                guna2Transition1.Show(guna2CirclePictureBox_prof);


            }
            if (guna2TextBox_user.Text == "333")
            {
                guna2CirclePictureBox_prof.Image = Properties.Resources.images__1_;
                guna2Transition1.Show(guna2CirclePictureBox_prof);

            }
            else guna2CirclePictureBox_prof.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(guna2Panel_signup.FillColor.A==200)
            {
                timer1.Stop();
                guna2Panel3.Visible = true;

            }
            guna2Panel_signup.FillColor = Color.FromArgb(guna2Panel_signup.FillColor.A + 5, 255, 255, 255);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text != guna2TextBox5.Text || guna2TextBox5.Text=="")
            {
                lblteste.ForeColor = Color.Black;
                lblteste.Text = "Password not valide";
                return;
            }
            
            
                guna2Panel3.Visible = false;
            guna2Panel_signup.FillColor = Color.FromArgb(0, 255, 0, 0);
            this.Hide();
            Vehicule v = new Vehicule();
            v.ShowDialog();
            

        }


        private void label2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox_prof_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text == guna2TextBox5.Text)
            {
                lblteste.ForeColor = Color.Green;
                lblteste.Text = "Password Valide";
            }else
            {
                lblteste.ForeColor = Color.Red;
                lblteste.Text = "Password not valide";

            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
