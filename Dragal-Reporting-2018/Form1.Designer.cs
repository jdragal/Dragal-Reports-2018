namespace Dragal_Reporting_2018
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lCtnrMain = new System.Windows.Forms.SplitContainer();
            this.lCtnrDataMessg = new System.Windows.Forms.SplitContainer();
            this.tcExplorer = new System.Windows.Forms.TabControl();
            this.tcTpDataExpl = new System.Windows.Forms.TabPage();
            this.tcDataRprtEdit = new System.Windows.Forms.TabControl();
            this.tcTpSQLData = new System.Windows.Forms.TabPage();
            this.tcTpRprtDesign = new System.Windows.Forms.TabPage();
            this.tcOutMessg = new System.Windows.Forms.TabControl();
            this.tcTpMessgs = new System.Windows.Forms.TabPage();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lCtnrMain)).BeginInit();
            this.lCtnrMain.Panel1.SuspendLayout();
            this.lCtnrMain.Panel2.SuspendLayout();
            this.lCtnrMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lCtnrDataMessg)).BeginInit();
            this.lCtnrDataMessg.Panel1.SuspendLayout();
            this.lCtnrDataMessg.Panel2.SuspendLayout();
            this.lCtnrDataMessg.SuspendLayout();
            this.tcExplorer.SuspendLayout();
            this.tcDataRprtEdit.SuspendLayout();
            this.tcOutMessg.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "V&iew";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "A&bout";
            // 
            // lCtnrMain
            // 
            this.lCtnrMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCtnrMain.Location = new System.Drawing.Point(0, 24);
            this.lCtnrMain.MaximumSize = new System.Drawing.Size(5000, 0);
            this.lCtnrMain.Name = "lCtnrMain";
            // 
            // lCtnrMain.Panel1
            // 
            this.lCtnrMain.Panel1.Controls.Add(this.tcExplorer);
            // 
            // lCtnrMain.Panel2
            // 
            this.lCtnrMain.Panel2.Controls.Add(this.lCtnrDataMessg);
            this.lCtnrMain.Size = new System.Drawing.Size(800, 426);
            this.lCtnrMain.SplitterDistance = 266;
            this.lCtnrMain.TabIndex = 1;
            // 
            // lCtnrDataMessg
            // 
            this.lCtnrDataMessg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCtnrDataMessg.Location = new System.Drawing.Point(0, 0);
            this.lCtnrDataMessg.Name = "lCtnrDataMessg";
            this.lCtnrDataMessg.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // lCtnrDataMessg.Panel1
            // 
            this.lCtnrDataMessg.Panel1.Controls.Add(this.tcDataRprtEdit);
            // 
            // lCtnrDataMessg.Panel2
            // 
            this.lCtnrDataMessg.Panel2.Controls.Add(this.tcOutMessg);
            this.lCtnrDataMessg.Size = new System.Drawing.Size(530, 426);
            this.lCtnrDataMessg.SplitterDistance = 237;
            this.lCtnrDataMessg.TabIndex = 0;
            // 
            // tcExplorer
            // 
            this.tcExplorer.Controls.Add(this.tcTpDataExpl);
            this.tcExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcExplorer.Location = new System.Drawing.Point(0, 0);
            this.tcExplorer.Name = "tcExplorer";
            this.tcExplorer.SelectedIndex = 0;
            this.tcExplorer.Size = new System.Drawing.Size(266, 426);
            this.tcExplorer.TabIndex = 0;
            // 
            // tcTpDataExpl
            // 
            this.tcTpDataExpl.Location = new System.Drawing.Point(4, 22);
            this.tcTpDataExpl.Name = "tcTpDataExpl";
            this.tcTpDataExpl.Padding = new System.Windows.Forms.Padding(3);
            this.tcTpDataExpl.Size = new System.Drawing.Size(258, 400);
            this.tcTpDataExpl.TabIndex = 0;
            this.tcTpDataExpl.Text = "Data explorer";
            this.tcTpDataExpl.UseVisualStyleBackColor = true;
            // 
            // tcDataRprtEdit
            // 
            this.tcDataRprtEdit.Controls.Add(this.tcTpSQLData);
            this.tcDataRprtEdit.Controls.Add(this.tcTpRprtDesign);
            this.tcDataRprtEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDataRprtEdit.Location = new System.Drawing.Point(0, 0);
            this.tcDataRprtEdit.Name = "tcDataRprtEdit";
            this.tcDataRprtEdit.SelectedIndex = 0;
            this.tcDataRprtEdit.Size = new System.Drawing.Size(530, 237);
            this.tcDataRprtEdit.TabIndex = 0;
            // 
            // tcTpSQLData
            // 
            this.tcTpSQLData.Location = new System.Drawing.Point(4, 22);
            this.tcTpSQLData.Name = "tcTpSQLData";
            this.tcTpSQLData.Padding = new System.Windows.Forms.Padding(3);
            this.tcTpSQLData.Size = new System.Drawing.Size(522, 211);
            this.tcTpSQLData.TabIndex = 0;
            this.tcTpSQLData.Text = "Raw Data";
            this.tcTpSQLData.UseVisualStyleBackColor = true;
            // 
            // tcTpRprtDesign
            // 
            this.tcTpRprtDesign.Location = new System.Drawing.Point(4, 22);
            this.tcTpRprtDesign.Name = "tcTpRprtDesign";
            this.tcTpRprtDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tcTpRprtDesign.Size = new System.Drawing.Size(522, 211);
            this.tcTpRprtDesign.TabIndex = 1;
            this.tcTpRprtDesign.Text = "Report Designer";
            this.tcTpRprtDesign.UseVisualStyleBackColor = true;
            // 
            // tcOutMessg
            // 
            this.tcOutMessg.Controls.Add(this.tcTpMessgs);
            this.tcOutMessg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcOutMessg.Location = new System.Drawing.Point(0, 0);
            this.tcOutMessg.Name = "tcOutMessg";
            this.tcOutMessg.SelectedIndex = 0;
            this.tcOutMessg.Size = new System.Drawing.Size(530, 185);
            this.tcOutMessg.TabIndex = 0;
            // 
            // tcTpMessgs
            // 
            this.tcTpMessgs.Location = new System.Drawing.Point(4, 22);
            this.tcTpMessgs.Name = "tcTpMessgs";
            this.tcTpMessgs.Padding = new System.Windows.Forms.Padding(3);
            this.tcTpMessgs.Size = new System.Drawing.Size(522, 159);
            this.tcTpMessgs.TabIndex = 0;
            this.tcTpMessgs.Text = "Messages";
            this.tcTpMessgs.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lCtnrMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.lCtnrMain.Panel1.ResumeLayout(false);
            this.lCtnrMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lCtnrMain)).EndInit();
            this.lCtnrMain.ResumeLayout(false);
            this.lCtnrDataMessg.Panel1.ResumeLayout(false);
            this.lCtnrDataMessg.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lCtnrDataMessg)).EndInit();
            this.lCtnrDataMessg.ResumeLayout(false);
            this.tcExplorer.ResumeLayout(false);
            this.tcDataRprtEdit.ResumeLayout(false);
            this.tcOutMessg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer lCtnrMain;
        private System.Windows.Forms.TabControl tcExplorer;
        private System.Windows.Forms.TabPage tcTpDataExpl;
        private System.Windows.Forms.SplitContainer lCtnrDataMessg;
        private System.Windows.Forms.TabControl tcDataRprtEdit;
        private System.Windows.Forms.TabPage tcTpSQLData;
        private System.Windows.Forms.TabPage tcTpRprtDesign;
        private System.Windows.Forms.TabControl tcOutMessg;
        private System.Windows.Forms.TabPage tcTpMessgs;
    }
}

