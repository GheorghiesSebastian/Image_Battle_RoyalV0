using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime_Royale_v1
{
    public partial class Form1 : Form
    {
        public static List<Image> imageList = new List<Image>();
        public static int imgCount;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog File = new OpenFileDialog();
            File.Multiselect = true;

            if (File.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in File.FileNames)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(190, 223),
                        ImageLocation = fileName,
                        Image = Image.FromFile(fileName)
                    };
                    flowLayoutPanel1.Controls.Add(pictureBox);
                    imageList.Add(pictureBox.Image);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
