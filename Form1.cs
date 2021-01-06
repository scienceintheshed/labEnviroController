using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace labEnviroController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bwSystemTime.RunWorkerAsync();
            bwGetClimate.RunWorkerAsync();
            bwPublish2Adafruit.RunWorkerAsync();
            
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
                    //lblSystemTime.Text = DateTime.Now.ToString();
                    //Thread.Sleep(100);
                }
            }
        }

        private void bwGetClimate_DoWork(object sender, DoWorkEventArgs e)
        {
            //  Backgroundworker 1 is used to update the climate information on the form.  The getClimate() method handles
            //  possible "Cross thread operation not valid" errors that may occur when we try to call a Windows form control
            //  from a thread that didn't create that control.

            //  This thread is started at form_load and doesn't have a stop function.
            
            while (true)
                getClimate();
        }

        
        private void getClimate()
        {
            //  This getClimate() method calls a python script that reads temperature and humidity 
            //  information from a SHT21 sensor.  

            DateTime finishTime = (DateTime.Now).AddMilliseconds(15000);

            string python = @"/usr/bin/python3";
            string climate = @"/home/pi/Programs/pythonScripts/Adafruit_Python_HTU21D/Adafruit_HTU21D/mySHT21.py";

            try
            {
                Process _myProcess = new Process();
                ProcessStartInfo _myProcessStartInfo = new ProcessStartInfo
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = false,
                    FileName = python,
                    Arguments = climate
                };

                _myProcess.StartInfo = _myProcessStartInfo;
                _myProcess.Start();

                StreamReader _myStreamReader = _myProcess.StandardOutput;
                string _temp = _myStreamReader.ReadLine();
                string _humid = _myStreamReader.ReadLine();
                string _dewpoint = _myStreamReader.ReadLine();

                //  We use the InvokeRequired method to prevent a  "Cross thread operation not valid".This error occurs when we try to
                //  call a Windows Forms control from a thread that didn't create that control.  We can pass a text value from the calling 
                //  function.
                if (txtTemperature.InvokeRequired)
                {
                    txtTemperature.Invoke(new MethodInvoker(delegate { txtTemperature.Text = _temp; }));
                    txtHumidity.Invoke(new MethodInvoker(delegate { txtHumidity.Text = _humid; }));
                    txtDewpoint.Invoke(new MethodInvoker(delegate { txtDewpoint.Text = _dewpoint; }));
                }
                else
                {
                    txtTemperature.Text = _temp;
                    txtHumidity.Text = _humid;
                    txtDewpoint.Text = _dewpoint;
                }

            }
            catch
            {
            }            

            //This is the loop described above that creates the delay similiar to Thread.Sleep().
            while (DateTime.Now < finishTime)
            {
                //  Create a loop
            }
        }

        private void bwPublish2Adafruit_DoWork(object sender, DoWorkEventArgs e)
        {

            while (true)
                publish2Cloud();
        }

        private void publish2Cloud()
        {
            //  Lets publish the climate data to Adafruit so we can visualise in real time.

            //  Yes...this is working correctly.  All that needs to happen now is to also include the other values of interest 
            //  such as electrode outputs etc. and move the code to the backgroundworker3() method, after the getGas() method.
            DateTime nextPublish = (DateTime.Now).AddMilliseconds(15000);
            string python = @"/usr/bin/python3";
            string args3 = string.Format(@"/home/pi/Programs/pythonScripts/publish2Cloud/publish2Cloud.py {0} {1} {2}", txtTemperature.Text, txtHumidity.Text, txtDewpoint.Text);

            try
            {
                Process publish = new Process();
                ProcessStartInfo publishProcessStartInfo = new ProcessStartInfo
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    FileName = python,
                    Arguments = args3
                };

                publish.StartInfo = publishProcessStartInfo;
                publish.Start();
                publish.WaitForExit();
            }
            catch
            {
            }

            //This is the loop described above that creates the delay similiar to Thread.Sleep().
            while (DateTime.Now < nextPublish)
            {
                //  Create a loop
            }

        }


    }

    /*
     * Program - labEnviroController
     * 
     * 06/01/2021 - 1647 - Include try/catch in getClimate.
     * 06/01/2021 - 1400 - Add toggle buttons to show status of humidifier and heater.
     * 06/01/2021 - 1117 - Original version.
     */
}
