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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Image = System.Net.Mime.MediaTypeNames.Image;

namespace Anime_Royale_v1
{
    public partial class Form1 : Form
    {
        int parse = 1;
        int imgCount;
        int imgCountEnd;

        bool end = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();

            if (File.ShowDialog() == DialogResult.OK)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(180, 223);
                pictureBox.ImageLocation = File.FileName;
                flowLayoutPanel1.Controls.Add(pictureBox);

            }
        }

        private void countL_TextChanged_1(object sender, EventArgs e)
        {
            parse = int.Parse(countL.Text);
            if (parse > imgCount)
            {
                countL.Text = "1";
                flowLayoutPanel1.Controls.Clear();

                foreach (Control controls in System.Windows.Forms.Application.OpenForms.OfType<Form2>().ToList())
                {
                    if (controls.Name == "NEXT")
                    {
                        foreach (Control control in controls.Controls)
                        {
                            if (control is PictureBox)
                            {
                                PictureBox control1 = new PictureBox();
                                control1.Image = control.BackgroundImage;
                                flowLayoutPanel1.Controls.Add(control1);
                            }
                        }
                    }
                    foreach (Control controlsz in controls.Controls)
                    {
                        if (controlsz.Name == "NEXT")
                        {
                            foreach (Control control in controlsz.Controls)
                            {
                                if (control is PictureBox)
                                {
                                    PictureBox control1 = new PictureBox();
                                    control1.Image = control.BackgroundImage;
                                    flowLayoutPanel1.Controls.Add(control1);
                                }
                                foreach (Control control3 in controlsz.Controls)
                                {
                                    if (control3 is PictureBox)
                                    {
                                        PictureBox control6 = new PictureBox();
                                        control6.Image = control3.BackgroundImage;
                                        flowLayoutPanel1.Controls.Add(control6);
                                    }
                                }
                            }
                        }
                    }
                }

                imgCount /= 2;
            }
            if (end == false)
            {
                imgwork();
            }
        }

        private void imgwork()
        {
            parse = int.Parse(countL.Text);

            Control image = flowLayoutPanel1.Controls[parse - 1];
            Control image2 = flowLayoutPanel1.Controls[parse];

            PictureBox Iteration = (PictureBox)image;
            PictureBox Iteration2 = (PictureBox)image2;

            pictureBox1.BackgroundImage = Iteration.Image;
            pictureBox2.BackgroundImage = Iteration2.Image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            Form2 Start = new Form2();

            Start.Show();
            foreach (Control images in flowLayoutPanel1.Controls)
            {
                imgCount += 1;
            }
            //this.Hide();

        }
    }
}
