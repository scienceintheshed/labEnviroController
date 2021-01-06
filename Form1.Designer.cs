
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.txtDewpoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bwSystemTime = new System.ComponentModel.BackgroundWorker();
            this.lblSystemTime = new System.Windows.Forms.Label();
            this.bwGetClimate = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSystemStatus = new System.Windows.Forms.Label();
            this.bwPublish2Adafruit = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Humidity";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(80, 27);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(57, 20);
            this.txtTemperature.TabIndex = 2;
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(80, 57);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(57, 20);
            this.txtHumidity.TabIndex = 3;
            this.txtHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDewpoint
            // 
            this.txtDewpoint.Location = new System.Drawing.Point(80, 87);
            this.txtDewpoint.Name = "txtDewpoint";
            this.txtDewpoint.Size = new System.Drawing.Size(57, 20);
            this.txtDewpoint.TabIndex = 4;
            this.txtDewpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // bwSystemTime
            // 
            this.bwSystemTime.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSystemTime_DoWork);
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.AutoSize = true;
            this.lblSystemTime.Location = new System.Drawing.Point(248, 190);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "System status : ";
            // 
            // lblSystemStatus
            // 
            this.lblSystemStatus.AutoSize = true;
            this.lblSystemStatus.Location = new System.Drawing.Point(113, 160);
            this.lblSystemStatus.Name = "lblSystemStatus";
            this.lblSystemStatus.Size = new System.Drawing.Size(81, 13);
            this.lblSystemStatus.TabIndex = 3;
            this.lblSystemStatus.Text = "lblSystemStatus";
            // 
            // bwPublish2Adafruit
            // 
            this.bwPublish2Adafruit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwPublish2Adafruit_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 212);
            this.Controls.Add(this.lblSystemStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSystemTime);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratory Environment Controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSystemStatus;
        private System.ComponentModel.BackgroundWorker bwPublish2Adafruit;
    }
}

