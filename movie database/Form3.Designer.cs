namespace movie_database
{
    partial class Form3
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
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Label();
            this.RUsearch = new System.Windows.Forms.TextBox();
            this.myMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.watchToolStripMenuItem,
            this.myMoviesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.watchToolStripMenuItem.Text = "Watch Movies";
            this.watchToolStripMenuItem.Click += new System.EventHandler(this.watchToolStripMenuItem_Click);
            // 
            // DGV1
            // 
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(12, 173);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(776, 248);
            this.DGV1.TabIndex = 1;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.RUsearch);
            this.panel1.Controls.Add(this.search);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(225, 42);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(39, 13);
            this.search.TabIndex = 0;
            this.search.Text = "search";
            // 
            // RUsearch
            // 
            this.RUsearch.Location = new System.Drawing.Point(277, 42);
            this.RUsearch.Name = "RUsearch";
            this.RUsearch.Size = new System.Drawing.Size(285, 20);
            this.RUsearch.TabIndex = 1;
            this.RUsearch.TextChanged += new System.EventHandler(this.RUsearch_TextChanged);
            // 
            // myMoviesToolStripMenuItem
            // 
            this.myMoviesToolStripMenuItem.Name = "myMoviesToolStripMenuItem";
            this.myMoviesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.myMoviesToolStripMenuItem.Text = "My Movies";
            this.myMoviesToolStripMenuItem.Click += new System.EventHandler(this.myMoviesToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3";
            this.Text = "RU search";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RUsearch;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.ToolStripMenuItem myMoviesToolStripMenuItem;
    }
}