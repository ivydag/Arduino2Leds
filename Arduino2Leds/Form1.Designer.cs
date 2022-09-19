namespace Arduino2Leds
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
            this.ButtonL1On = new System.Windows.Forms.Button();
            this.ButtonL1Off = new System.Windows.Forms.Button();
            this.ButtonL2On = new System.Windows.Forms.Button();
            this.ButtonL2Off = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonL1On
            // 
            this.ButtonL1On.Location = new System.Drawing.Point(22, 135);
            this.ButtonL1On.Name = "ButtonL1On";
            this.ButtonL1On.Size = new System.Drawing.Size(75, 23);
            this.ButtonL1On.TabIndex = 0;
            this.ButtonL1On.Text = "Led1 ON";
            this.ButtonL1On.UseVisualStyleBackColor = true;
            this.ButtonL1On.Click += new System.EventHandler(this.ButtonL1On_Click);
            // 
            // ButtonL1Off
            // 
            this.ButtonL1Off.Location = new System.Drawing.Point(22, 165);
            this.ButtonL1Off.Name = "ButtonL1Off";
            this.ButtonL1Off.Size = new System.Drawing.Size(75, 23);
            this.ButtonL1Off.TabIndex = 1;
            this.ButtonL1Off.Text = "Led1 OFF";
            this.ButtonL1Off.UseVisualStyleBackColor = true;
            this.ButtonL1Off.Click += new System.EventHandler(this.ButtonL1Off_Click);
            // 
            // ButtonL2On
            // 
            this.ButtonL2On.Location = new System.Drawing.Point(174, 134);
            this.ButtonL2On.Name = "ButtonL2On";
            this.ButtonL2On.Size = new System.Drawing.Size(75, 23);
            this.ButtonL2On.TabIndex = 2;
            this.ButtonL2On.Text = "Led2 ON";
            this.ButtonL2On.UseVisualStyleBackColor = true;
            this.ButtonL2On.Click += new System.EventHandler(this.ButtonL2On_Click);
            // 
            // ButtonL2Off
            // 
            this.ButtonL2Off.Location = new System.Drawing.Point(174, 164);
            this.ButtonL2Off.Name = "ButtonL2Off";
            this.ButtonL2Off.Size = new System.Drawing.Size(75, 23);
            this.ButtonL2Off.TabIndex = 3;
            this.ButtonL2Off.Text = "Led2 OFF";
            this.ButtonL2Off.UseVisualStyleBackColor = true;
            this.ButtonL2Off.Click += new System.EventHandler(this.ButtonL2Off_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Arduino2Leds.Properties.Resources.bulb;
            this.pictureBox2.Location = new System.Drawing.Point(174, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Arduino2Leds.Properties.Resources.bulb;
            this.pictureBox1.Location = new System.Drawing.Point(22, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonL2Off);
            this.Controls.Add(this.ButtonL2On);
            this.Controls.Add(this.ButtonL1Off);
            this.Controls.Add(this.ButtonL1On);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonL1On;
        private System.Windows.Forms.Button ButtonL1Off;
        private System.Windows.Forms.Button ButtonL2On;
        private System.Windows.Forms.Button ButtonL2Off;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

