namespace CalculatorSimple
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограміToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Ravno = new System.Windows.Forms.Button();
            this.button_Dot = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_PlusMinus = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_Mult = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_Slash = new System.Windows.Forms.Button();
            this.button_Sqrt = new System.Windows.Forms.Button();
            this.button_Pow = new System.Windows.Forms.Button();
            this.button_1x = new System.Windows.Forms.Button();
            this.button_Backspace = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_Persent = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(356, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограміToolStripMenuItem});
            this.видToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.видToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.видToolStripMenuItem.Text = "Налаштування";
            // 
            // оПрограміToolStripMenuItem
            // 
            this.оПрограміToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.оПрограміToolStripMenuItem.Name = "оПрограміToolStripMenuItem";
            this.оПрограміToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограміToolStripMenuItem.Text = "О програмі";
            this.оПрограміToolStripMenuItem.Click += new System.EventHandler(this.оПрограміToolStripMenuItem_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.BackColor = System.Drawing.Color.White;
            this.textBox_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Result.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Result.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_Result.Location = new System.Drawing.Point(3, 35);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Result.Size = new System.Drawing.Size(349, 60);
            this.textBox_Result.TabIndex = 1;
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button_Ravno);
            this.panel1.Controls.Add(this.button_Dot);
            this.panel1.Controls.Add(this.button_0);
            this.panel1.Controls.Add(this.button_PlusMinus);
            this.panel1.Controls.Add(this.button_Plus);
            this.panel1.Controls.Add(this.button_3);
            this.panel1.Controls.Add(this.button_2);
            this.panel1.Controls.Add(this.button_1);
            this.panel1.Controls.Add(this.button_Minus);
            this.panel1.Controls.Add(this.button_6);
            this.panel1.Controls.Add(this.button_5);
            this.panel1.Controls.Add(this.button_4);
            this.panel1.Controls.Add(this.button_Mult);
            this.panel1.Controls.Add(this.button_9);
            this.panel1.Controls.Add(this.button_8);
            this.panel1.Controls.Add(this.button_7);
            this.panel1.Controls.Add(this.button_Slash);
            this.panel1.Controls.Add(this.button_Sqrt);
            this.panel1.Controls.Add(this.button_Pow);
            this.panel1.Controls.Add(this.button_1x);
            this.panel1.Controls.Add(this.button_Backspace);
            this.panel1.Controls.Add(this.button_C);
            this.panel1.Controls.Add(this.button_CE);
            this.panel1.Controls.Add(this.button_Persent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 436);
            this.panel1.TabIndex = 2;
            // 
            // button_Ravno
            // 
            this.button_Ravno.BackColor = System.Drawing.Color.Gray;
            this.button_Ravno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Ravno.FlatAppearance.BorderSize = 0;
            this.button_Ravno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Ravno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Ravno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ravno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Ravno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Ravno.Location = new System.Drawing.Point(267, 364);
            this.button_Ravno.Name = "button_Ravno";
            this.button_Ravno.Size = new System.Drawing.Size(85, 69);
            this.button_Ravno.TabIndex = 27;
            this.button_Ravno.Text = "=";
            this.button_Ravno.UseVisualStyleBackColor = false;
            this.button_Ravno.Click += new System.EventHandler(this.button_Ravno_Click);
            // 
            // button_Dot
            // 
            this.button_Dot.AutoEllipsis = true;
            this.button_Dot.BackColor = System.Drawing.Color.DarkGray;
            this.button_Dot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Dot.FlatAppearance.BorderSize = 0;
            this.button_Dot.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Dot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Dot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Dot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Dot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Dot.Location = new System.Drawing.Point(179, 364);
            this.button_Dot.Name = "button_Dot";
            this.button_Dot.Size = new System.Drawing.Size(85, 69);
            this.button_Dot.TabIndex = 26;
            this.button_Dot.Text = ",";
            this.button_Dot.UseVisualStyleBackColor = false;
            this.button_Dot.Click += new System.EventHandler(this.button_Dot_Click);
            // 
            // button_0
            // 
            this.button_0.AutoEllipsis = true;
            this.button_0.BackColor = System.Drawing.Color.DarkGray;
            this.button_0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_0.FlatAppearance.BorderSize = 0;
            this.button_0.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_0.Location = new System.Drawing.Point(91, 364);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(85, 69);
            this.button_0.TabIndex = 25;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.button_Click);
            // 
            // button_PlusMinus
            // 
            this.button_PlusMinus.AutoEllipsis = true;
            this.button_PlusMinus.BackColor = System.Drawing.Color.DarkGray;
            this.button_PlusMinus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_PlusMinus.FlatAppearance.BorderSize = 0;
            this.button_PlusMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_PlusMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_PlusMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_PlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PlusMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_PlusMinus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_PlusMinus.Location = new System.Drawing.Point(3, 364);
            this.button_PlusMinus.Name = "button_PlusMinus";
            this.button_PlusMinus.Size = new System.Drawing.Size(85, 69);
            this.button_PlusMinus.TabIndex = 24;
            this.button_PlusMinus.Text = "+/-";
            this.button_PlusMinus.UseVisualStyleBackColor = false;
            this.button_PlusMinus.Click += new System.EventHandler(this.button_PlusMinus_Click);
            // 
            // button_Plus
            // 
            this.button_Plus.BackColor = System.Drawing.Color.DimGray;
            this.button_Plus.FlatAppearance.BorderSize = 0;
            this.button_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Plus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Plus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Plus.Location = new System.Drawing.Point(267, 292);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(85, 69);
            this.button_Plus.TabIndex = 23;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = false;
            this.button_Plus.Click += new System.EventHandler(this.button_Symbol_Click);
            // 
            // button_3
            // 
            this.button_3.AutoEllipsis = true;
            this.button_3.BackColor = System.Drawing.Color.DarkGray;
            this.button_3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_3.FlatAppearance.BorderSize = 0;
            this.button_3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_3.Location = new System.Drawing.Point(179, 292);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(85, 69);
            this.button_3.TabIndex = 22;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_Click);
            // 
            // button_2
            // 
            this.button_2.AutoEllipsis = true;
            this.button_2.BackColor = System.Drawing.Color.DarkGray;
            this.button_2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_2.FlatAppearance.BorderSize = 0;
            this.button_2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_2.Location = new System.Drawing.Point(91, 292);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(85, 69);
            this.button_2.TabIndex = 21;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_Click);
            // 
            // button_1
            // 
            this.button_1.AutoEllipsis = true;
            this.button_1.BackColor = System.Drawing.Color.DarkGray;
            this.button_1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_1.FlatAppearance.BorderSize = 0;
            this.button_1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_1.Location = new System.Drawing.Point(3, 292);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(85, 69);
            this.button_1.TabIndex = 20;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.BackColor = System.Drawing.Color.DimGray;
            this.button_Minus.FlatAppearance.BorderSize = 0;
            this.button_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Minus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Minus.Location = new System.Drawing.Point(267, 220);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(85, 69);
            this.button_Minus.TabIndex = 19;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = false;
            this.button_Minus.Click += new System.EventHandler(this.button_Symbol_Click);
            // 
            // button_6
            // 
            this.button_6.AutoEllipsis = true;
            this.button_6.BackColor = System.Drawing.Color.DarkGray;
            this.button_6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_6.FlatAppearance.BorderSize = 0;
            this.button_6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_6.Location = new System.Drawing.Point(179, 220);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(85, 69);
            this.button_6.TabIndex = 18;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button_Click);
            // 
            // button_5
            // 
            this.button_5.AutoEllipsis = true;
            this.button_5.BackColor = System.Drawing.Color.DarkGray;
            this.button_5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_5.FlatAppearance.BorderSize = 0;
            this.button_5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_5.Location = new System.Drawing.Point(91, 220);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(85, 69);
            this.button_5.TabIndex = 17;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button_Click);
            // 
            // button_4
            // 
            this.button_4.AutoEllipsis = true;
            this.button_4.BackColor = System.Drawing.Color.DarkGray;
            this.button_4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_4.FlatAppearance.BorderSize = 0;
            this.button_4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_4.Location = new System.Drawing.Point(3, 220);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(85, 69);
            this.button_4.TabIndex = 16;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_Click);
            // 
            // button_Mult
            // 
            this.button_Mult.BackColor = System.Drawing.Color.DimGray;
            this.button_Mult.FlatAppearance.BorderSize = 0;
            this.button_Mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Mult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Mult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Mult.Location = new System.Drawing.Point(267, 148);
            this.button_Mult.Name = "button_Mult";
            this.button_Mult.Size = new System.Drawing.Size(85, 69);
            this.button_Mult.TabIndex = 15;
            this.button_Mult.Text = "*";
            this.button_Mult.UseVisualStyleBackColor = false;
            this.button_Mult.Click += new System.EventHandler(this.button_Symbol_Click);
            // 
            // button_9
            // 
            this.button_9.AutoEllipsis = true;
            this.button_9.BackColor = System.Drawing.Color.DarkGray;
            this.button_9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_9.FlatAppearance.BorderSize = 0;
            this.button_9.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_9.Location = new System.Drawing.Point(179, 148);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(85, 69);
            this.button_9.TabIndex = 14;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button_Click);
            // 
            // button_8
            // 
            this.button_8.AutoEllipsis = true;
            this.button_8.BackColor = System.Drawing.Color.DarkGray;
            this.button_8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_8.FlatAppearance.BorderSize = 0;
            this.button_8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_8.Location = new System.Drawing.Point(91, 148);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(85, 69);
            this.button_8.TabIndex = 13;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button_Click);
            // 
            // button_7
            // 
            this.button_7.AutoEllipsis = true;
            this.button_7.BackColor = System.Drawing.Color.DarkGray;
            this.button_7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_7.FlatAppearance.BorderSize = 0;
            this.button_7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_7.Location = new System.Drawing.Point(3, 148);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(85, 69);
            this.button_7.TabIndex = 12;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_Click);
            // 
            // button_Slash
            // 
            this.button_Slash.BackColor = System.Drawing.Color.DimGray;
            this.button_Slash.FlatAppearance.BorderSize = 0;
            this.button_Slash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Slash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Slash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Slash.Location = new System.Drawing.Point(267, 76);
            this.button_Slash.Name = "button_Slash";
            this.button_Slash.Size = new System.Drawing.Size(85, 69);
            this.button_Slash.TabIndex = 11;
            this.button_Slash.Text = "/";
            this.button_Slash.UseVisualStyleBackColor = false;
            this.button_Slash.Click += new System.EventHandler(this.button_Symbol_Click);
            // 
            // button_Sqrt
            // 
            this.button_Sqrt.BackColor = System.Drawing.Color.DimGray;
            this.button_Sqrt.FlatAppearance.BorderSize = 0;
            this.button_Sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sqrt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Sqrt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Sqrt.Location = new System.Drawing.Point(179, 76);
            this.button_Sqrt.Name = "button_Sqrt";
            this.button_Sqrt.Size = new System.Drawing.Size(85, 69);
            this.button_Sqrt.TabIndex = 10;
            this.button_Sqrt.Text = "√";
            this.button_Sqrt.UseVisualStyleBackColor = false;
            this.button_Sqrt.Click += new System.EventHandler(this.button_1x_Pow_Sqrt_Click);
            // 
            // button_Pow
            // 
            this.button_Pow.BackColor = System.Drawing.Color.DimGray;
            this.button_Pow.FlatAppearance.BorderSize = 0;
            this.button_Pow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pow.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Pow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Pow.Location = new System.Drawing.Point(91, 76);
            this.button_Pow.Name = "button_Pow";
            this.button_Pow.Size = new System.Drawing.Size(85, 69);
            this.button_Pow.TabIndex = 9;
            this.button_Pow.Text = "x²";
            this.button_Pow.UseVisualStyleBackColor = false;
            this.button_Pow.Click += new System.EventHandler(this.button_1x_Pow_Sqrt_Click);
            // 
            // button_1x
            // 
            this.button_1x.BackColor = System.Drawing.Color.DimGray;
            this.button_1x.FlatAppearance.BorderSize = 0;
            this.button_1x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1x.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_1x.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_1x.Location = new System.Drawing.Point(3, 76);
            this.button_1x.Name = "button_1x";
            this.button_1x.Size = new System.Drawing.Size(85, 69);
            this.button_1x.TabIndex = 8;
            this.button_1x.Text = "1/x";
            this.button_1x.UseVisualStyleBackColor = false;
            this.button_1x.Click += new System.EventHandler(this.button_1x_Pow_Sqrt_Click);
            // 
            // button_Backspace
            // 
            this.button_Backspace.BackColor = System.Drawing.Color.DimGray;
            this.button_Backspace.FlatAppearance.BorderSize = 0;
            this.button_Backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Backspace.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Backspace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Backspace.Location = new System.Drawing.Point(267, 4);
            this.button_Backspace.Name = "button_Backspace";
            this.button_Backspace.Size = new System.Drawing.Size(85, 69);
            this.button_Backspace.TabIndex = 7;
            this.button_Backspace.Text = "←";
            this.button_Backspace.UseVisualStyleBackColor = false;
            this.button_Backspace.Click += new System.EventHandler(this.button_Backspace_Click);
            // 
            // button_C
            // 
            this.button_C.BackColor = System.Drawing.Color.DimGray;
            this.button_C.FlatAppearance.BorderSize = 0;
            this.button_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_C.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_C.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_C.Location = new System.Drawing.Point(179, 4);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(85, 69);
            this.button_C.TabIndex = 6;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = false;
            this.button_C.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_CE
            // 
            this.button_CE.BackColor = System.Drawing.Color.DimGray;
            this.button_CE.FlatAppearance.BorderSize = 0;
            this.button_CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_CE.Location = new System.Drawing.Point(91, 4);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(85, 69);
            this.button_CE.TabIndex = 5;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = false;
            this.button_CE.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Persent
            // 
            this.button_Persent.BackColor = System.Drawing.Color.DimGray;
            this.button_Persent.FlatAppearance.BorderSize = 0;
            this.button_Persent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Persent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Persent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Persent.Location = new System.Drawing.Point(3, 4);
            this.button_Persent.Name = "button_Persent";
            this.button_Persent.Size = new System.Drawing.Size(85, 69);
            this.button_Persent.TabIndex = 4;
            this.button_Persent.Text = "%";
            this.button_Persent.UseVisualStyleBackColor = false;
            this.button_Persent.Click += new System.EventHandler(this.button_Symbol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(356, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Backspace;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_Persent;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_Mult;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_Slash;
        private System.Windows.Forms.Button button_Sqrt;
        private System.Windows.Forms.Button button_Pow;
        private System.Windows.Forms.Button button_1x;
        private System.Windows.Forms.Button button_Ravno;
        private System.Windows.Forms.Button button_Dot;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_PlusMinus;
        private System.Windows.Forms.ToolStripMenuItem оПрограміToolStripMenuItem;
    }
}

