
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.lblHeaterOff = new System.Windows.Forms.Label();
            this.lblHumidifierOff = new System.Windows.Forms.Label();
            this.lblHeaterOn = new System.Windows.Forms.Label();
            this.lblHumidifierOn = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bwCheckClimate = new System.ComponentModel.BackgroundWorker();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblDewPoint = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDewPoint);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblHumidity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTemperature);
            this.groupBox1.Location = new System.Drawing.Point(25, 51);
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
            this.lblSystemTime.Location = new System.Drawing.Point(267, 192);
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
            this.groupBox2.Controls.Add(this.lblHeaterOff);
            this.groupBox2.Controls.Add(this.lblHumidifierOff);
            this.groupBox2.Controls.Add(this.lblHeaterOn);
            this.groupBox2.Controls.Add(this.lblHumidifierOn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(227, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 129);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipment status";
            // 
            // lblHeaterOff
            // 
            this.lblHeaterOff.AutoSize = true;
            this.lblHeaterOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaterOff.ForeColor = System.Drawing.Color.Red;
            this.lblHeaterOff.Location = new System.Drawing.Point(94, 78);
            this.lblHeaterOff.Name = "lblHeaterOff";
            this.lblHeaterOff.Size = new System.Drawing.Size(65, 29);
            this.lblHeaterOff.TabIndex = 11;
            this.lblHeaterOff.Text = "OFF";
            // 
            // lblHumidifierOff
            // 
            this.lblHumidifierOff.AutoSize = true;
            this.lblHumidifierOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidifierOff.ForeColor = System.Drawing.Color.Red;
            this.lblHumidifierOff.Location = new System.Drawing.Point(94, 27);
            this.lblHumidifierOff.Name = "lblHumidifierOff";
            this.lblHumidifierOff.Size = new System.Drawing.Size(65, 29);
            this.lblHumidifierOff.TabIndex = 10;
            this.lblHumidifierOff.Text = "OFF";
            // 
            // lblHeaterOn
            // 
            this.lblHeaterOn.AutoSize = true;
            this.lblHeaterOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaterOn.ForeColor = System.Drawing.Color.Green;
            this.lblHeaterOn.Location = new System.Drawing.Point(100, 78);
            this.lblHeaterOn.Name = "lblHeaterOn";
            this.lblHeaterOn.Size = new System.Drawing.Size(52, 29);
            this.lblHeaterOn.TabIndex = 9;
            this.lblHeaterOn.Text = "ON";
            // 
            // lblHumidifierOn
            // 
            this.lblHumidifierOn.AutoSize = true;
            this.lblHumidifierOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidifierOn.ForeColor = System.Drawing.Color.Green;
            this.lblHumidifierOn.Location = new System.Drawing.Point(100, 27);
            this.lblHumidifierOn.Name = "lblHumidifierOn";
            this.lblHumidifierOn.Size = new System.Drawing.Size(52, 29);
            this.lblHumidifierOn.TabIndex = 8;
            this.lblHumidifierOn.Text = "ON";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // bwCheckClimate
            // 
            this.bwCheckClimate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCheckClimate_DoWork);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(80, 30);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(35, 13);
            this.lblTemperature.TabIndex = 12;
            this.lblTemperature.Text = "label5";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(80, 60);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(35, 13);
            this.lblHumidity.TabIndex = 13;
            this.lblHumidity.Text = "label5";
            // 
            // lblDewPoint
            // 
            this.lblDewPoint.AutoSize = true;
            this.lblDewPoint.Location = new System.Drawing.Point(80, 90);
            this.lblDewPoint.Name = "lblDewPoint";
            this.lblDewPoint.Size = new System.Drawing.Size(35, 13);
            this.lblDewPoint.TabIndex = 14;
            this.lblDewPoint.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 220);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSystemTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratory Environment Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Label lblHeaterOff;
        private System.Windows.Forms.Label lblHumidifierOff;
        private System.Windows.Forms.Label lblHeaterOn;
        private System.Windows.Forms.Label lblHumidifierOn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bwCheckClimate;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblDewPoint;
        private System.Windows.Forms.Label lblHumidity;
    }
}

