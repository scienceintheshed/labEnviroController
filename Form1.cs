using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace labEnviroController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bwSystemTime.RunWorkerAsync();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bwSystemTime_DoWork(object sender, DoWorkEventArgs e)
        {
            //  Backgroundworker 2 is used to update the system time on the form.  System time is used both as a check that the 
            //  program has not been caught in an unresponsive loop but also as the source of the timestamp information for
            //  writing to the datafile.  The timestamp for publishing to the cloud is derived from the called python script
            //
            //  We use the InvokeRequired method to prevent a  "Cross thread operation not valid".This error occurs when we try to
            //  call a Windows Forms control from a thread that didn't create that control.  We can pass a text value from the calling 
            //  function.

            //  This thread is started at form_load and doesn't have a stop function.
            while (true)
            {
                if (lblSystemTime.InvokeRequired)
                {
                    lblSystemTime.Invoke(new MethodInvoker(delegate { lblSystemTime.Text = DateTime.Now.ToString(); }));
                    Thread.Sleep(100);
                }
                else
                {
                    lblSystemTime.Text = DateTime.Now.ToString();
                    Thread.Sleep(100);
                }
            }
        }
    }
}
