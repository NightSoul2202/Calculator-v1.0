namespace CalculatorSimple
{
    partial class Configcs
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
            this.trackBar_Blue1 = new System.Windows.Forms.TrackBar();
            this.trackBar_Green1 = new System.Windows.Forms.TrackBar();
            this.trackBar_Red1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Blue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Green1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Red1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar_Blue1);
            this.groupBox1.Controls.Add(this.trackBar_Green1);
            this.groupBox1.Controls.Add(this.trackBar_Red1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(-7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Системний колір";
            // 
            // trackBar_Blue1
            // 
            this.trackBar_Blue1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_Blue1.Location = new System.Drawing.Point(3, 106);
            this.trackBar_Blue1.Maximum = 255;
            this.trackBar_Blue1.Name = "trackBar_Blue1";
            this.trackBar_Blue1.Size = new System.Drawing.Size(349, 45);
            this.trackBar_Blue1.TabIndex = 2;
            this.trackBar_Blue1.Scroll += new System.EventHandler(this.trackBar_ColorChange_Scroll);
            // 
            // trackBar_Green1
            // 
            this.trackBar_Green1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_Green1.Location = new System.Drawing.Point(3, 61);
            this.trackBar_Green1.Maximum = 255;
            this.trackBar_Green1.Name = "trackBar_Green1";
            this.trackBar_Green1.Size = new System.Drawing.Size(349, 45);
            this.trackBar_Green1.TabIndex = 1;
            this.trackBar_Green1.Scroll += new System.EventHandler(this.trackBar_ColorChange_Scroll);
            // 
            // trackBar_Red1
            // 
            this.trackBar_Red1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_Red1.Location = new System.Drawing.Point(3, 16);
            this.trackBar_Red1.Maximum = 255;
            this.trackBar_Red1.Name = "trackBar_Red1";
            this.trackBar_Red1.Size = new System.Drawing.Size(349, 45);
            this.trackBar_Red1.TabIndex = 0;
            this.trackBar_Red1.Scroll += new System.EventHandler(this.trackBar_ColorChange_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "За замовчуванням";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Configcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Configcs";
            this.Text = "Configcs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configcs_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Blue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Green1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Red1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar_Blue1;
        private System.Windows.Forms.TrackBar trackBar_Green1;
        private System.Windows.Forms.TrackBar trackBar_Red1;
        private System.Windows.Forms.Button button1;
    }
}