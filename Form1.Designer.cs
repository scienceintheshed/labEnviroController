
namespace labEnviroController
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDewpoint = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bwSystemTime = new System.ComponentModel.BackgroundWorker();
            this.lblSystemTime = new System.Windows.Forms.Label();
            this.bwGetClimate = new System.ComponentModel.BackgroundWorker();
            this.bwPublish2Adafruit = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picHumidifierOff = new System.Windows.Forms.PictureBox();
            this.picHeaterOff = new System.Windows.Forms.PictureBox();
            this.picHumidifierOn = new System.Windows.Forms.PictureBox();
            this.picHeaterOn = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHumidifierOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaterOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHumidifierOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaterOn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDewpoint);
            this.groupBox1.Controls.Add(this.txtHumidity);
            this.groupBox1.Controls.Add(this.txtTemperature);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atmospheric conditions";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dewpoint";
            // 
            // txtDewpoint
            // 
            this.txtDewpoint.Location = new System.Drawing.Point(80, 87);
            this.txtDewpoint.Name = "txtDewpoint";
            this.txtDewpoint.Size = new System.Drawing.Size(57, 20);
            this.txtDewpoint.TabIndex = 4;
            this.txtDewpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(80, 57);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(57, 20);
            this.txtHumidity.TabIndex = 3;
            this.txtHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(80, 27);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(57, 20);
            this.txtTemperature.TabIndex = 2;
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Humidity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature";
            // 
            // bwSystemTime
            // 
            this.bwSystemTime.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSystemTime_DoWork);
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.AutoSize = true;
            this.lblSystemTime.Location = new System.Drawing.Point(291, 192);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(74, 13);
            this.lblSystemTime.TabIndex = 1;
            this.lblSystemTime.Text = "lblSystemTime";
            this.lblSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bwGetClimate
            // 
            this.bwGetClimate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetClimate_DoWork);
            // 
            // bwPublish2Adafruit
            // 
            this.bwPublish2Adafruit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwPublish2Adafruit_DoWork);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Humidifier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Heater";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picHeaterOn);
            this.groupBox2.Controls.Add(this.picHumidifierOn);
            this.groupBox2.Controls.Add(this.picHeaterOff);
            this.groupBox2.Controls.Add(this.picHumidifierOff);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(214, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 129);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipment status";
            // 
            // picHumidifierOff
            // 
            this.picHumidifierOff.Image = ((System.Drawing.Image)(resources.GetObject("picHumidifierOff.Image")));
            this.picHumidifierOff.Location = new System.Drawing.Point(80, 25);
            this.picHumidifierOff.Name = "picHumidifierOff";
            this.picHumidifierOff.Size = new System.Drawing.Size(70, 35);
            this.picHumidifierOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHumidifierOff.TabIndex = 8;
            this.picHumidifierOff.TabStop = false;
            // 
            // picHeaterOff
            // 
            this.picHeaterOff.Image = ((System.Drawing.Image)(resources.GetObject("picHeaterOff.Image")));
            this.picHeaterOff.Location = new System.Drawing.Point(80, 75);
            this.picHeaterOff.Name = "picHeaterOff";
            this.picHeaterOff.Size = new System.Drawing.Size(70, 35);
            this.picHeaterOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeaterOff.TabIndex = 9;
            this.picHeaterOff.TabStop = false;
            // 
            // picHumidifierOn
            // 
            this.picHumidifierOn.Image = ((System.Drawing.Image)(resources.GetObject("picHumidifierOn.Image")));
            this.picHumidifierOn.Location = new System.Drawing.Point(80, 25);
            this.picHumidifierOn.Name = "picHumidifierOn";
            this.picHumidifierOn.Size = new System.Drawing.Size(70, 35);
            this.picHumidifierOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHumidifierOn.TabIndex = 11;
            this.picHumidifierOn.TabStop = false;
            this.picHumidifierOn.Visible = false;
            // 
            // picHeaterOn
            // 
            this.picHeaterOn.Image = ((System.Drawing.Image)(resources.GetObject("picHeaterOn.Image")));
            this.picHeaterOn.Location = new System.Drawing.Point(80, 75);
            this.picHeaterOn.Name = "picHeaterOn";
            this.picHeaterOn.Size = new System.Drawing.Size(70, 35);
            this.picHeaterOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeaterOn.TabIndex = 12;
            this.picHeaterOn.TabStop = false;
            this.picHeaterOn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 214);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSystemTime);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratory Environment Controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHumidifierOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaterOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHumidifierOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaterOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDewpoint;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker bwSystemTime;
        private System.Windows.Forms.Label lblSystemTime;
        private System.ComponentModel.BackgroundWorker bwGetClimate;
        private System.ComponentModel.BackgroundWorker bwPublish2Adafruit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picHeaterOn;
        private System.Windows.Forms.PictureBox picHumidifierOn;
        private System.Windows.Forms.PictureBox picHeaterOff;
        private System.Windows.Forms.PictureBox picHumidifierOff;
    }
}

