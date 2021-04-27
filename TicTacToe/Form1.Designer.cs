namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.R1C2 = new System.Windows.Forms.Button();
            this.R3C2 = new System.Windows.Forms.Button();
            this.R3C3 = new System.Windows.Forms.Button();
            this.R1C3 = new System.Windows.Forms.Button();
            this.R2C1 = new System.Windows.Forms.Button();
            this.R2C3 = new System.Windows.Forms.Button();
            this.R3C1 = new System.Windows.Forms.Button();
            this.R2C2 = new System.Windows.Forms.Button();
            this.R1C1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nEWGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Player O";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Player X";
            // 
            // R1C2
            // 
            this.R1C2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1C2.Location = new System.Drawing.Point(134, 129);
            this.R1C2.Name = "R1C2";
            this.R1C2.Size = new System.Drawing.Size(96, 96);
            this.R1C2.TabIndex = 26;
            this.R1C2.UseVisualStyleBackColor = true;
            this.R1C2.Click += new System.EventHandler(this.button_click);
            this.R1C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.R1C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // R3C2
            // 
            this.R3C2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R3C2.Location = new System.Drawing.Point(134, 333);
            this.R3C2.Name = "R3C2";
            this.R3C2.Size = new System.Drawing.Size(96, 96);
            this.R3C2.TabIndex = 25;
            this.R3C2.UseVisualStyleBackColor = true;
            this.R3C2.Click += new System.EventHandler(this.button_click);
            this.R3C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.R3C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // R3C3
            // 
            this.R3C3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R3C3.Location = new System.Drawing.Point(236, 333);
            this.R3C3.Name = "R3C3";
            this.R3C3.Size = new System.Drawing.Size(96, 96);
            this.R3C3.TabIndex = 24;
            this.R3C3.UseVisualStyleBackColor = true;
            this.R3C3.MouseCaptureChanged += new System.EventHandler(this.button_click);
            this.R3C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.R3C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // R1C3
            // 
            this.R1C3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1C3.Location = new System.Drawing.Point(236, 129);
            this.R1C3.Name = "R1C3";
            this.R1C3.Size = new System.Drawing.Size(96, 96);
            this.R1C3.TabIndex = 23;
            this.R1C3.UseVisualStyleBackColor = true;
            this.R1C3.Click += new System.EventHandler(this.button_click);
            this.R1C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.R1C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // R2C1
            // 
            this.R2C1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2C1.Location = new System.Drawing.Point(32, 231);
            this.R2C1.Name = "R2C1";
            this.R2C1.Size = new System.Drawing.Size(96, 96);
            this.R2C1.TabIndex = 22;
            this.R2C1.UseVisualStyleBackColor = true;
            this.R2C1.Click += new System.EventHandler(this.button_click);
            this.R2C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.R2C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // R2C3
            // 
            this.R2C3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2C3.Location = new System.Drawing.Point(236, 231);
            this.R2C3.Name = "R2C3";
            this.R2C3.Size = new System.Drawing.Size(96, 96);
            this.R2C3.TabIndex = 21;
            this.R2C3.UseVisualStyleBackColor = true;
            this.R2C3.Click += new System.EventHandler(this.button_click);
            this.R2C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.R2C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // R3C1
            // 
            this.R3C1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R3C1.Location = new System.Drawing.Point(32, 333);
            this.R3C1.Name = "R3C1";
            this.R3C1.Size = new System.Drawing.Size(96, 96);
            this.R3C1.TabIndex = 20;
            this.R3C1.UseVisualStyleBackColor = true;
            this.R3C1.Click += new System.EventHandler(this.button_click);
            this.R3C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.R3C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // R2C2
            // 
            this.R2C2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2C2.Location = new System.Drawing.Point(134, 231);
            this.R2C2.Name = "R2C2";
            this.R2C2.Size = new System.Drawing.Size(96, 96);
            this.R2C2.TabIndex = 19;
            this.R2C2.UseVisualStyleBackColor = true;
            this.R2C2.Click += new System.EventHandler(this.button_click);
            this.R2C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.R2C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // R1C1
            // 
            this.R1C1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1C1.Location = new System.Drawing.Point(32, 129);
            this.R1C1.Name = "R1C1";
            this.R1C1.Size = new System.Drawing.Size(96, 96);
            this.R1C1.TabIndex = 18;
            this.R1C1.UseVisualStyleBackColor = true;
            this.R1C1.Click += new System.EventHandler(this.button_click);
            this.R1C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.R1C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWGAMEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nEWGAMEToolStripMenuItem
            // 
            this.nEWGAMEToolStripMenuItem.Name = "nEWGAMEToolStripMenuItem";
            this.nEWGAMEToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.nEWGAMEToolStripMenuItem.Text = "NEW GAME";
            this.nEWGAMEToolStripMenuItem.Click += new System.EventHandler(this.nEWGAMEToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.R1C2);
            this.Controls.Add(this.R3C2);
            this.Controls.Add(this.R3C3);
            this.Controls.Add(this.R1C3);
            this.Controls.Add(this.R2C1);
            this.Controls.Add(this.R2C3);
            this.Controls.Add(this.R3C1);
            this.Controls.Add(this.R2C2);
            this.Controls.Add(this.R1C1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button R1C2;
        private System.Windows.Forms.Button R3C2;
        private System.Windows.Forms.Button R3C3;
        private System.Windows.Forms.Button R1C3;
        private System.Windows.Forms.Button R2C1;
        private System.Windows.Forms.Button R2C3;
        private System.Windows.Forms.Button R3C1;
        private System.Windows.Forms.Button R2C2;
        private System.Windows.Forms.Button R1C1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nEWGAMEToolStripMenuItem;
    }
}

