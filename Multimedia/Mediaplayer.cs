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
    public partial class Mediaplayer : Form
    {
        private String file;
        public Mediaplayer(String file)
        {
            InitializeComponent();
            this.file = file;
            this.Text = file;
        }

        private void Mediaplayer_Load(object sender, EventArgs e)
        {
            try
            {
                wmpPlayer.URL = file;
                wmpPlayer.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mediaplayer_Closed(object sender, FormClosedEventArgs e)
        {
            wmpPlayer.Ctlcontrols.stop();
        }
    }
}
