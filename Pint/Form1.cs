using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pint
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool pint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 1);
        int index = 0;

        public Form1()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pbQuadro.Width, pbQuadro.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pbQuadro.Image = bm;
        }

        private void pbQuadro_MouseDown(object sender, MouseEventArgs e)
        {
            pint = true;
            py = e.Location;

        }

        private void pbQuadro_MouseMove(object sender, MouseEventArgs e)
        {
            if (pint)
            {
                if(index == 1)
                {
                    px = e.Location;
                    g.DrawLine(pen, px, py);
                    py = px;
                }
                else if(index == 2)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
            }
            pbQuadro.Refresh();

        }

        private void pbQuadro_MouseUp(object sender, MouseEventArgs e)
        {
            pint = false;


        }
        private void btnPensil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void tbSize_Scroll(object sender, EventArgs e)
        {
            pen.Width = tbSize.Value;
            eraser.Width = tbSize.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pen.Color = colorDialog1.Color;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string local;
            Bitmap img = new Bitmap(pbQuadro.Image);
            saveFileDialog1.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog1.Title = "Salve uma Imagem";
            saveFileDialog1.ShowDialog();
            if(saveFileDialog1.FileName != "")
            {
                local = saveFileDialog1.FileName;
                img.Save(local, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void btnDesf_Click(object sender, EventArgs e)
        {

            g.Clear(Color.White);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
