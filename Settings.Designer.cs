
namespace labEnviroController
{
    partial class Settings
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
            this.txtTempMin = new System.Windows.Forms.TextBox();
            this.txtTempMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHumidityMin = new System.Windows.Forms.TextBox();
            this.txtHumidityMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAndExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWithoutUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTempMin);
            this.groupBox1.Controls.Add(this.txtTempMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature";
            // 
            // txtTempMin
            // 
            this.txtTempMin.Location = new System.Drawing.Point(79, 65);
            this.txtTempMin.Name = "txtTempMin";
            this.txtTempMin.Size = new System.Drawing.Size(44, 20);
            this.txtTempMin.TabIndex = 3;
            this.txtTempMin.Text = "20";
            this.txtTempMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTempMax
            // 
            this.txtTempMax.Location = new System.Drawing.Point(79, 30);
            this.txtTempMax.Name = "txtTempMax";
            this.txtTempMax.Size = new System.Drawing.Size(44, 20);
            this.txtTempMax.TabIndex = 2;
            this.txtTempMax.Text = "30";
            this.txtTempMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minimum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHumidityMin);
            this.groupBox2.Controls.Add(this.txtHumidityMax);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(205, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Humidity";
            // 
            // txtHumidityMin
            // 
            this.txtHumidityMin.Location = new System.Drawing.Point(79, 65);
            this.txtHumidityMin.Name = "txtHumidityMin";
            this.txtHumidityMin.Size = new System.Drawing.Size(44, 20);
            this.txtHumidityMin.TabIndex = 3;
            this.txtHumidityMin.Text = "45";
            this.txtHumidityMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHumidityMax
            // 
            this.txtHumidityMax.Location = new System.Drawing.Point(79, 30);
            this.txtHumidityMax.Name = "txtHumidityMax";
            this.txtHumidityMax.Size = new System.Drawing.Size(44, 20);
            this.txtHumidityMax.TabIndex = 2;
            this.txtHumidityMax.Text = "55";
            this.txtHumidityMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Minimum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Maximum";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateSettingsToolStripMenuItem
            // 
            this.updateSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateAndExitToolStripMenuItem,
            this.exitWithoutUpdateToolStripMenuItem});
            this.updateSettingsToolStripMenuItem.Name = "updateSettingsToolStripMenuItem";
            this.updateSettingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.updateSettingsToolStripMenuItem.Text = "Settings";
            // 
            // updateAndExitToolStripMenuItem
            // 
            this.updateAndExitToolStripMenuItem.Name = "updateAndExitToolStripMenuItem";
            this.updateAndExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateAndExitToolStripMenuItem.Text = "Update  and Exit";
            this.updateAndExitToolStripMenuItem.Click += new System.EventHandler(this.updateAndExitToolStripMenuItem_Click);
            // 
            // exitWithoutUpdateToolStripMenuItem
            // 
            this.exitWithoutUpdateToolStripMenuItem.Name = "exitWithoutUpdateToolStripMenuItem";
            this.exitWithoutUpdateToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitWithoutUpdateToolStripMenuItem.Text = "Exit without update";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 180);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
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
        private System.Windows.Forms.TextBox txtTempMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHumidityMin;
        private System.Windows.Forms.TextBox txtHumidityMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAndExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitWithoutUpdateToolStripMenuItem;
        public System.Windows.Forms.TextBox txtTempMax;
    }
}