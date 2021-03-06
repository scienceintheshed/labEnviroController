﻿using System;
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
            

            
        }

        private void bwSystemTime_DoWork(object sender, DoWorkEventArgs e)
        {
            //  Backgroundworker 2 is used to update the system time on the form.  System time is used both as a check that the 
            //  program has not been caught in an unresponsive loop but also as the source of the timestamp information for
            //  writing to the datafile.  The timestamp for publishing to the cloud is derived from the called python script
            //
            //  We use the InvokeRequired method to prevent a  "Cross thread operation not valid".This error occurs when we try to
            //  call a Windows Forms control from a thread that didn't create that control.  

            //  This thread is started at form_load and doesn't have a stop function.
            Thread.Sleep(2000);
            while (true)
            {
                lblSystemTime.Invoke(new MethodInvoker(delegate { lblSystemTime.Text = DateTime.Now.ToString(); }));
                Thread.Sleep(100);                
            }
        }

        private void bwGetClimate_DoWork(object sender, DoWorkEventArgs e)
        {
            //  Background worker bwGetClimate is used to update the climate information on the form.  The getClimate() method handles
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
                lblTemperature.Invoke(new MethodInvoker(delegate { lblTemperature.Text = _temp; }));
                lblHumidity.Invoke(new MethodInvoker(delegate { lblHumidity.Text = _humid; }));
                lblDewPoint.Invoke(new MethodInvoker(delegate { lblDewPoint.Text = _dewpoint; }));

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
            //  Background worker bwPublish2Adafruit is used to publish laboratory environment data to io.adafruit.com.

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
            string args3 = string.Format(@"/home/pi/Programs/pythonScripts/publish2Cloud/publish2Cloud.py {0} {1} {2}", lblTemperature.Text, lblHumidity.Text, lblDewPoint.Text);

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


        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Displays the About form.
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            bwSystemTime.RunWorkerAsync();
            bwGetClimate.RunWorkerAsync();
            bwPublish2Adafruit.RunWorkerAsync();
            bwCheckClimate.RunWorkerAsync();
            

        }

        private void bwCheckClimate_DoWork(object sender, DoWorkEventArgs e)
        {
            /*  In this function, we compare the actual temperature and humidity readings from the SHT21
             *  sensor to the preset maximum and minimum set values.  If the values are out of set range,
             *  the function runPythonScript() is called and parameters to identify the approprite relay and 
             *  gpio state are passed.
             */

            Thread.Sleep(5000);
            string relayAction = "Programs/pythonScripts/relayState";

            while (true)
            {

                try
                {
                    double labTemperature = Convert.ToDouble(lblTemperature.Text);
                    double labHumidity = Convert.ToDouble(lblHumidity.Text);

                    if (labTemperature < Convert.ToDouble(Properties.Settings.Default.minTemp))
                    {
                        //  Switch on the heater
                        runPythonScript(relayAction, 20, 0);
                        lblHeaterOff.Visible = false;
                        lblHeaterOn.Visible = true;

                    }
                    if (labTemperature > Convert.ToDouble(Properties.Settings.Default.maxTemp))
                    {
                        //  Switch off the heater.
                        runPythonScript(relayAction, 20, 1);
                        lblHeaterOff.Visible = true;
                        lblHeaterOn.Visible = false;
                    }
                    if (labHumidity < Convert.ToDouble(Properties.Settings.Default.minHumidity))
                    {
                        //  Switch on the humidifier.
                        runPythonScript(relayAction, 21, 0);
                        lblHumidifierOff.Visible = false;
                        lblHumidifierOn.Visible = true;

                    }
                    if (labHumidity > Convert.ToDouble(Properties.Settings.Default.maxHumidity))
                    {
                        //  Switch off the humidifier.
                        runPythonScript(relayAction, 21, 1);
                        lblHumidifierOff.Visible = true;
                        lblHumidifierOn.Visible = false;
                    }
                }
                catch
                {
                    //
                }
                Thread.Sleep(5000);
            }
                
        }

        private void runPythonScript(string fileName, int myPin, int gpioState)
        {
            /*  This function is based on the one used in the Atmos series of programs.  It's purpose is to combine all the other 
             *  functions that call python scripts into one main piece of code.  Variables need to be defined for each application.
            */

            /*  Define where the python complier is located and which script we are going to run.  All the scripts needed for the 
             *  operation of the program should be stored the /home/pi/Programs/pythonScripts/ folder and identified by the 
             *  fileName variable, without the .py extension.
            */
            string python = @"/usr/bin/python3";
            string runPythonScript = string.Format(@"/home/pi/" + fileName + ".py {0} {1} {2} {3} {4}", fileName, myPin, gpioState);

            try
            {
                Process pythonScript = new Process();
                ProcessStartInfo pythonScriptStartInfo = new ProcessStartInfo
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    FileName = python,
                    Arguments = runPythonScript
                };

                pythonScript.StartInfo = pythonScriptStartInfo;
                pythonScript.Start();

            }
            catch
            {
            }
        }
    }

    /*
     *  THINGS TO DO.
     *  1. Change getClimate aquisition interval to 60 seconds.
     *  2. Change publish2Adafruit update interval to 60 seconds.
     *  3. Use Round function on SHT21 data to 1 decimal place.
     */


    /*
     * Program - labEnviroController
     * 10/01/2021 1100 - Include bwCheckClimate() and runPythonScript().
     * 06/01/2021 1846 - Remove if loops in bwSystemTime and use Invoke directly.
     * 06/01/2021 1834 - Eliminate if loops in getClimate.
     * 06/01/2021 1647 - Include try/catch in getClimate.
     * 06/01/2021 1400 - Add toggle buttons to show status of humidifier and heater.
     * 06/01/2021 1117 - Original version.
     */
}
