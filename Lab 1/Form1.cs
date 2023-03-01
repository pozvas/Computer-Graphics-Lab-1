using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    enum Borders{
        X, Y
    }

    public partial class Form1 : Form
    {
        Bitmap _startImage;
        Bitmap _image;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _image = new Bitmap(ofd.FileName);
                _startImage = new Bitmap(ofd.FileName);
                pictureBox1.Image = _image;
                pictureBox1.Refresh();
            }
        }

        private void СерыймирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GreyWorldFIlter filter = new GreyWorldFIlter(_image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(_image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                _image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = _image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void блюрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void гауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void отменитьИзмененияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _image = _startImage;
            pictureBox1.Image = _image;
            pictureBox1.Refresh();
        }

        private void оттенкиСерогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void увеличениеЯркостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BrightnessFilter(10);
            backgroundWorker1.RunWorkerAsync(filter);
        }


        private void тиснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new EmbossingFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void поХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter(Borders.X);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void поYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter(Borders.Y);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
            
        }

        private void собеляToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
