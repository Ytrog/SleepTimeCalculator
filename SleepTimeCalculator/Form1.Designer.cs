namespace SleepTimeCalculator
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
            this.dtpInput = new System.Windows.Forms.DateTimePicker();
            this.btnNow = new System.Windows.Forms.Button();
            this.rbSleep = new System.Windows.Forms.RadioButton();
            this.rbWake = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpInput
            // 
            this.dtpInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInput.CustomFormat = "HH:mm";
            this.dtpInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInput.Location = new System.Drawing.Point(13, 13);
            this.dtpInput.Name = "dtpInput";
            this.dtpInput.ShowUpDown = true;
            this.dtpInput.Size = new System.Drawing.Size(200, 20);
            this.dtpInput.TabIndex = 0;
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(220, 12);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(75, 23);
            this.btnNow.TabIndex = 1;
            this.btnNow.Text = "Now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // rbSleep
            // 
            this.rbSleep.AutoSize = true;
            this.rbSleep.Location = new System.Drawing.Point(302, 15);
            this.rbSleep.Name = "rbSleep";
            this.rbSleep.Size = new System.Drawing.Size(87, 17);
            this.rbSleep.TabIndex = 2;
            this.rbSleep.Text = "Fall asleep at";
            this.rbSleep.UseVisualStyleBackColor = true;
            // 
            // rbWake
            // 
            this.rbWake.AutoSize = true;
            this.rbWake.Checked = true;
            this.rbWake.Location = new System.Drawing.Point(396, 15);
            this.rbWake.Name = "rbWake";
            this.rbWake.Size = new System.Drawing.Size(81, 17);
            this.rbWake.TabIndex = 3;
            this.rbWake.TabStop = true;
            this.rbWake.Text = "Wake up at";
            this.rbWake.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(302, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 24);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Enabled = false;
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(13, 43);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(735, 353);
            this.rtbOutput.TabIndex = 5;
            this.rtbOutput.Text = "";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(510, 12);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 408);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rbWake);
            this.Controls.Add(this.rbSleep);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.dtpInput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SleepTime Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInput;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.RadioButton rbSleep;
        private System.Windows.Forms.RadioButton rbWake;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnCalc;
    }
}

