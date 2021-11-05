namespace SystemMonitor
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
            this.cpuTempLabel = new System.Windows.Forms.Label();
            this.gpuTempLabel = new System.Windows.Forms.Label();
            this.cpuTemp = new System.Windows.Forms.Label();
            this.gpuTemp = new System.Windows.Forms.Label();
            this.systemTimeDateLabel = new System.Windows.Forms.Label();
            this.systemTimeDate = new System.Windows.Forms.Label();
            this.gpuLoad = new System.Windows.Forms.Label();
            this.cpuLoad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpuTempLabel
            // 
            this.cpuTempLabel.AutoSize = true;
            this.cpuTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTempLabel.Location = new System.Drawing.Point(12, 9);
            this.cpuTempLabel.Name = "cpuTempLabel";
            this.cpuTempLabel.Size = new System.Drawing.Size(138, 29);
            this.cpuTempLabel.TabIndex = 0;
            this.cpuTempLabel.Text = "CPU temp:";
            // 
            // gpuTempLabel
            // 
            this.gpuTempLabel.AutoSize = true;
            this.gpuTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTempLabel.Location = new System.Drawing.Point(149, 9);
            this.gpuTempLabel.Name = "gpuTempLabel";
            this.gpuTempLabel.Size = new System.Drawing.Size(139, 29);
            this.gpuTempLabel.TabIndex = 1;
            this.gpuTempLabel.Text = "GPU temp:";
            // 
            // cpuTemp
            // 
            this.cpuTemp.AutoSize = true;
            this.cpuTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTemp.Location = new System.Drawing.Point(12, 38);
            this.cpuTemp.Name = "cpuTemp";
            this.cpuTemp.Size = new System.Drawing.Size(53, 29);
            this.cpuTemp.TabIndex = 2;
            this.cpuTemp.Text = "N/A";
            // 
            // gpuTemp
            // 
            this.gpuTemp.AutoSize = true;
            this.gpuTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTemp.Location = new System.Drawing.Point(149, 38);
            this.gpuTemp.Name = "gpuTemp";
            this.gpuTemp.Size = new System.Drawing.Size(53, 29);
            this.gpuTemp.TabIndex = 3;
            this.gpuTemp.Text = "N/A";
            // 
            // systemTimeDateLabel
            // 
            this.systemTimeDateLabel.AutoSize = true;
            this.systemTimeDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemTimeDateLabel.Location = new System.Drawing.Point(466, 9);
            this.systemTimeDateLabel.Name = "systemTimeDateLabel";
            this.systemTimeDateLabel.Size = new System.Drawing.Size(234, 29);
            this.systemTimeDateLabel.TabIndex = 4;
            this.systemTimeDateLabel.Text = "System Time/Date:";
            // 
            // systemTimeDate
            // 
            this.systemTimeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemTimeDate.Location = new System.Drawing.Point(315, 38);
            this.systemTimeDate.Name = "systemTimeDate";
            this.systemTimeDate.Size = new System.Drawing.Size(385, 29);
            this.systemTimeDate.TabIndex = 5;
            this.systemTimeDate.Text = "N/A";
            this.systemTimeDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpuLoad
            // 
            this.gpuLoad.AutoSize = true;
            this.gpuLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuLoad.Location = new System.Drawing.Point(149, 113);
            this.gpuLoad.Name = "gpuLoad";
            this.gpuLoad.Size = new System.Drawing.Size(53, 29);
            this.gpuLoad.TabIndex = 9;
            this.gpuLoad.Text = "N/A";
            // 
            // cpuLoad
            // 
            this.cpuLoad.AutoSize = true;
            this.cpuLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLoad.Location = new System.Drawing.Point(12, 113);
            this.cpuLoad.Name = "cpuLoad";
            this.cpuLoad.Size = new System.Drawing.Size(53, 29);
            this.cpuLoad.TabIndex = 8;
            this.cpuLoad.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "GPU load:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPU load:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 171);
            this.Controls.Add(this.gpuLoad);
            this.Controls.Add(this.cpuLoad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.systemTimeDate);
            this.Controls.Add(this.systemTimeDateLabel);
            this.Controls.Add(this.gpuTemp);
            this.Controls.Add(this.cpuTemp);
            this.Controls.Add(this.gpuTempLabel);
            this.Controls.Add(this.cpuTempLabel);
            this.Name = "Form1";
            this.Text = "System Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpuTempLabel;
        private System.Windows.Forms.Label gpuTempLabel;
        private System.Windows.Forms.Label cpuTemp;
        private System.Windows.Forms.Label gpuTemp;
        private System.Windows.Forms.Label systemTimeDateLabel;
        private System.Windows.Forms.Label systemTimeDate;
        private System.Windows.Forms.Label gpuLoad;
        private System.Windows.Forms.Label cpuLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

