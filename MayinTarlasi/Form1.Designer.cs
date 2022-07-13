
namespace MayinTarlasi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmYeniOyun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKolay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOrta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmZor = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmYeniOyun});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmYeniOyun
            // 
            this.tsmYeniOyun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKolay,
            this.tsmOrta,
            this.tsmZor});
            this.tsmYeniOyun.Name = "tsmYeniOyun";
            this.tsmYeniOyun.Size = new System.Drawing.Size(73, 20);
            this.tsmYeniOyun.Text = "Yeni Oyun";
            // 
            // tsmKolay
            // 
            this.tsmKolay.Name = "tsmKolay";
            this.tsmKolay.Size = new System.Drawing.Size(180, 22);
            this.tsmKolay.Text = "Kolay";
            this.tsmKolay.Click += new System.EventHandler(this.tsmKolay_Click);
            // 
            // tsmOrta
            // 
            this.tsmOrta.Name = "tsmOrta";
            this.tsmOrta.Size = new System.Drawing.Size(180, 22);
            this.tsmOrta.Text = "Orta";
            this.tsmOrta.Click += new System.EventHandler(this.tsmOrta_Click);
            // 
            // tsmZor
            // 
            this.tsmZor.Name = "tsmZor";
            this.tsmZor.Size = new System.Drawing.Size(180, 22);
            this.tsmZor.Text = "Zor";
            this.tsmZor.Click += new System.EventHandler(this.tsmZor_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(775, 399);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmYeniOyun;
        private System.Windows.Forms.ToolStripMenuItem tsmKolay;
        private System.Windows.Forms.ToolStripMenuItem tsmOrta;
        private System.Windows.Forms.ToolStripMenuItem tsmZor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

