using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Anime_Royale_v1
{
    public partial class Form2 : Form
    {
        bool alpha = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control form in System.Windows.Forms.Application.OpenForms.OfType<Form1>().ToList())
            {
                foreach (Control control in form.Controls)
                {
                    if (control.Name == "pictureBox1")
                    {
                        pictureBox1.Image = control.BackgroundImage;
                    }
                    if (control.Name == "pictureBox2")
                    {
                        pictureBox2.Image = control.BackgroundImage;
                    }

                    if (control.Name == "countL")
                    {
                        if (alpha == false)
                        {
                            alpha = true;
                            int value = int.Parse(control.Text);
                            value += 1;
                            control.Text = value.ToString();
                        }
                        else
                        {
                            int value = int.Parse(control.Text);
                            value += 2;
                            control.Text = value.ToString();
                        }
                    }
                }

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = pictureBox1.Image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


            NEXT.Controls.Add(pictureBox);

            foreach (Control form in System.Windows.Forms.Application.OpenForms.OfType<Form1>().ToList())
            {
                foreach (Control control in form.Controls)
                {

                    if (control.Name == "countL")
                    {
                            int value = int.Parse(control.Text);
                            value += 2;
                            control.Text = value.ToString();
                    }
                    if (control.Name == "pictureBox1")
                    {
                        pictureBox1.Image = control.BackgroundImage;
                    }
                    if (control.Name == "pictureBox2")
                    {
                        pictureBox2.Image = control.BackgroundImage;
                    }
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = pictureBox2.Image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            NEXT.Controls.Add(pictureBox);

            foreach (Control form in System.Windows.Forms.Application.OpenForms.OfType<Form1>().ToList())
            {
                foreach (Control control in form.Controls)
                {

                    if (control.Name == "countL")
                    {

                            int value = int.Parse(control.Text);
                            value += 2;
                            control.Text = value.ToString();

                    }

                    if (control.Name == "pictureBox1")
                    {
                        pictureBox1.Image = control.BackgroundImage;
                    }
                    if (control.Name == "pictureBox2")
                    {
                        pictureBox2.Image = control.BackgroundImage;
                    }
                }

            }

        }

        private void NEXT_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

/*                            Control selected = images;
                            PictureBox select = (PictureBox)selected;

                            if (select.Image == Deleted.Image)
                            {
                                this.BackColor = Color.Green;
                                NEXT.Controls.Add(images);
                            }
*/