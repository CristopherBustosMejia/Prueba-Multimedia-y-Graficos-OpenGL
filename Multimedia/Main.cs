using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multimedia
{
    public partial class Main : Form
    {
        private String route;
        public Main()
        {
            InitializeComponent();
        }

        private void btnOpenfileClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                route = ofd.FileName;
            };
            Mediaplayer mediaplayer = new Mediaplayer(route);
            mediaplayer.ShowDialog();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            GraphCalc graph = new GraphCalc();
            graph.Show();
        }

        private void btn3d_Click(object sender, EventArgs e)
        {
            _3d animation = new _3d();
            animation.ShowDialog();
        }
    }
}
