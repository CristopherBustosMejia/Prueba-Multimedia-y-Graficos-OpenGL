using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multimedia
{
    public partial class GraphCalc : Form
    {
        private Bitmap bmp;
        readonly Color[] colors =
        {
            Color.Blue, Color.Red, Color.Green, Color.Yellow
        };

        private int colorCount = -1;

        public GraphCalc()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pbMap.Width, pbMap.Height);
            Graphics g = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, pbMap.Width/2, 0, pbMap.Width/2, pbMap.Height);
            g.DrawLine(pen, 0, pbMap.Height/2, pbMap.Width, pbMap.Height/2);
            pbMap.Image = bmp;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                colorCount++;
                colorCount = colorCount < colors.Length ? colorCount = colorCount : 0;
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(colors[colorCount]);
                for (double i = (bmp.Width / 2) * -1; i < bmp.Width / 2; i += 0.01)
                {
                    float x = (float)i;
                    float y = (float)(float.Parse(txtA.Text) * Math.Pow(x, 2)) + (float.Parse(txtB.Text) * x) + float.Parse(txtC.Text);

                    // Dibujar un punto en la posición (i, y)
                    double xCoord = i + (bmp.Width / 2);
                    double yCoord = bmp.Height / 2 - (int)y;

                    // Verificar si el punto está dentro del área visible del plano
                    if (xCoord >= 0 && xCoord < bmp.Width && yCoord >= 0 && yCoord < bmp.Height)
                    {
                        g.DrawEllipse(pen, (float)xCoord, (float)yCoord, 2, 2);
                    }
                }
                pbMap.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(Color.Orange);
                g.DrawEllipse(pen, float.Parse(txtX.Text), float.Parse(txtY.Text), float.Parse(txtW.Text), float.Parse(txtH.Text));
                pbMap.Image = bmp;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(Color.Orange);
                g.DrawRectangle(pen, float.Parse(txtX.Text), float.Parse(txtY.Text), float.Parse(txtW.Text), float.Parse(txtH.Text));
                pbMap.Image = bmp;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void validateKeys(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-' && ((TextBox)sender).SelectionStart == 0 && !((TextBox)sender).Text.Contains("-"))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
