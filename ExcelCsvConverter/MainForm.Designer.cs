namespace ExcelCsvConverter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.CenterSplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.fileListView = new System.Windows.Forms.ListView();
            this.EventLstView = new System.Windows.Forms.ListView();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CenterSplitContainer1)).BeginInit();
            this.CenterSplitContainer1.Panel1.SuspendLayout();
            this.CenterSplitContainer1.Panel2.SuspendLayout();
            this.CenterSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.convertToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.MainStatusStrip.TabIndex = 1;
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.MainSplitContainer.Name = "MainSplitContainer";
            this.MainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.CenterSplitContainer1);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.EventLstView);
            this.MainSplitContainer.Size = new System.Drawing.Size(800, 404);
            this.MainSplitContainer.SplitterDistance = 296;
            this.MainSplitContainer.TabIndex = 2;
            // 
            // CenterSplitContainer1
            // 
            this.CenterSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.CenterSplitContainer1.Name = "CenterSplitContainer1";
            // 
            // CenterSplitContainer1.Panel1
            // 
            this.CenterSplitContainer1.Panel1.Controls.Add(this.fileListView);
            // 
            // CenterSplitContainer1.Panel2
            // 
            this.CenterSplitContainer1.Panel2.Controls.Add(this.MainPropertyGrid);
            this.CenterSplitContainer1.Size = new System.Drawing.Size(800, 296);
            this.CenterSplitContainer1.SplitterDistance = 600;
            this.CenterSplitContainer1.TabIndex = 0;
            // 
            // MainPropertyGrid
            // 
            this.MainPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.MainPropertyGrid.Name = "MainPropertyGrid";
            this.MainPropertyGrid.Size = new System.Drawing.Size(196, 296);
            this.MainPropertyGrid.TabIndex = 0;
            // 
            // fileListView
            // 
            this.fileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListView.HideSelection = false;
            this.fileListView.Location = new System.Drawing.Point(0, 0);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(600, 296);
            this.fileListView.TabIndex = 0;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            // 
            // EventLstView
            // 
            this.EventLstView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventLstView.HideSelection = false;
            this.EventLstView.Location = new System.Drawing.Point(0, 0);
            this.EventLstView.Name = "EventLstView";
            this.EventLstView.Size = new System.Drawing.Size(800, 104);
            this.EventLstView.TabIndex = 0;
            this.EventLstView.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Excel Csv Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.CenterSplitContainer1.Panel1.ResumeLayout(false);
            this.CenterSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CenterSplitContainer1)).EndInit();
            this.CenterSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.SplitContainer CenterSplitContainer1;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.PropertyGrid MainPropertyGrid;
        private System.Windows.Forms.ListView EventLstView;
    }
}

