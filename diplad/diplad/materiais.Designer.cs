namespace diplad
{
    partial class materiais
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.notebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaDeSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notebookToolStripMenuItem,
            this.fonteToolStripMenuItem,
            this.caixaDeSomToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1179, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // notebookToolStripMenuItem
            // 
            this.notebookToolStripMenuItem.Name = "notebookToolStripMenuItem";
            this.notebookToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.notebookToolStripMenuItem.Text = "Notebook";
            this.notebookToolStripMenuItem.Click += new System.EventHandler(this.notebookToolStripMenuItem_Click);
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.fonteToolStripMenuItem.Text = "Fonte";
            // 
            // caixaDeSomToolStripMenuItem
            // 
            this.caixaDeSomToolStripMenuItem.Name = "caixaDeSomToolStripMenuItem";
            this.caixaDeSomToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.caixaDeSomToolStripMenuItem.Text = "Caixa de som";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1179, 533);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // materiais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 557);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "materiais";
            this.Text = "materiais";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem notebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaDeSomToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}