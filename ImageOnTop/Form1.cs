using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageOnTop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);

           
        }
        private void pictureBox1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ///process mouse event
            int x = e.Delta;
            if (e.Delta<0)
                this.Size = new Size(this.Size.Width - 100, this.Size.Height - 100);
            else if (e.Delta > 0) 
                this.Size = new Size(this.Size.Width + 100, this.Size.Height + 100);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a Image";
            ofd.Filter = "Images (*.jpg,*.png) | *.jpg;*.png | All Files(*.*) | *.*"; //Here you can filter which all files you wanted allow to open  
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.Opacity = 0.4;
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.TopMost == true)
                this.TopMost = false;
            else
                this.TopMost = true;
        }
    }
}
