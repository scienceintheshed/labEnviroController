using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labEnviroController
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtTempMax.Text = Properties.Settings.Default.maxTemp;
            txtTempMin.Text = Properties.Settings.Default.minTemp;
        }

        private void updateAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.maxTemp = txtTempMax.Text;
            //Properties.Settings.Default.Save();
            Properties.Settings.Default.minTemp = txtTempMin.Text;
            Properties.Settings.Default.Save();


        }
    }
}
