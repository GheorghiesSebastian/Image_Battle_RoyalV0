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
    public partial class Form2 : Form
    {
        List<Image> newlist = new List<Image>();
        int countAll = 0;
        bool end = false;

        public static Image final;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Form1.imageList[countAll];
            pictureBox2.Image = Form1.imageList[countAll + 1];

            pictureBox1.Click += imgDecision;
            pictureBox2.Click += imgDecision;

        }

        private void imgDecision(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                newlist.Add(clickedPictureBox.Image);
            }
            countAll += 2;

            if (Form1.imgCount == 2)
            {
                final = clickedPictureBox.Image;
                end = true;
                Form3 form3 = new Form3();
                form3.Show();

            }
            if (countAll == Form1.imgCount)
            {
                Form1.imgCount = newlist.Count;
                Form1.imageList = new List<Image>(newlist);
                newlist.Clear();
                countAll = 0;
            }
            if (end == false)
            {
                pictureBox1.Image = Form1.imageList[countAll];
                pictureBox2.Image = Form1.imageList[countAll + 1];
            }


        }

    }
}
