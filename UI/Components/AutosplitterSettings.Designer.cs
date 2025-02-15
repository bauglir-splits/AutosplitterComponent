namespace AutosplitterComponent.UI.Components
{
    partial class AutosplitterSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Level 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Level 2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Level 3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Splits", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.lblOptions = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblAdvanced = new System.Windows.Forms.Label();
            this.tvwSettings = new System.Windows.Forms.TreeView();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.cbxReset = new System.Windows.Forms.CheckBox();
            this.cbxSplit = new System.Windows.Forms.CheckBox();
            this.cbxStart = new System.Windows.Forms.CheckBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnResetToDefault = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOptions
            // 
            this.lblOptions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOptions.Location = new System.Drawing.Point(3, 13);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(64, 23);
            this.lblOptions.TabIndex = 0;
            this.lblOptions.Text = "Options:";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.lblOptions, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblAdvanced, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.tvwSettings, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.pnlOptions, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.pnlButtons, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(470, 550);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // lblAdvanced
            // 
            this.lblAdvanced.AutoSize = true;
            this.lblAdvanced.Location = new System.Drawing.Point(3, 55);
            this.lblAdvanced.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblAdvanced.Name = "lblAdvanced";
            this.lblAdvanced.Size = new System.Drawing.Size(59, 13);
            this.lblAdvanced.TabIndex = 1;
            this.lblAdvanced.Text = "Advanced:";
            // 
            // tvwSettings
            // 
            this.tvwSettings.CheckBoxes = true;
            this.tvwSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwSettings.Location = new System.Drawing.Point(73, 53);
            this.tvwSettings.Name = "tvwSettings";
            treeNode1.Checked = true;
            treeNode1.Name = "Level1";
            treeNode1.Text = "Level 1";
            treeNode2.Checked = true;
            treeNode2.Name = "Level2";
            treeNode2.Text = "Level 2";
            treeNode3.Name = "Level3";
            treeNode3.Text = "Level 3";
            treeNode4.Checked = true;
            treeNode4.Name = "Splits";
            treeNode4.Text = "Splits";
            this.tvwSettings.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tvwSettings.Size = new System.Drawing.Size(394, 444);
            this.tvwSettings.TabIndex = 3;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.cbxReset);
            this.pnlOptions.Controls.Add(this.cbxSplit);
            this.pnlOptions.Controls.Add(this.cbxStart);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.Location = new System.Drawing.Point(73, 3);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(394, 44);
            this.pnlOptions.TabIndex = 4;
            // 
            // cbxReset
            // 
            this.cbxReset.AutoSize = true;
            this.cbxReset.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxReset.Location = new System.Drawing.Point(94, 0);
            this.cbxReset.Name = "cbxReset";
            this.cbxReset.Size = new System.Drawing.Size(54, 44);
            this.cbxReset.TabIndex = 2;
            this.cbxReset.Text = "Reset";
            this.cbxReset.UseVisualStyleBackColor = true;
            // 
            // cbxSplit
            // 
            this.cbxSplit.AutoSize = true;
            this.cbxSplit.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxSplit.Location = new System.Drawing.Point(48, 0);
            this.cbxSplit.Name = "cbxSplit";
            this.cbxSplit.Size = new System.Drawing.Size(46, 44);
            this.cbxSplit.TabIndex = 1;
            this.cbxSplit.Text = "Split";
            this.cbxSplit.UseVisualStyleBackColor = true;
            // 
            // cbxStart
            // 
            this.cbxStart.AutoSize = true;
            this.cbxStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxStart.Location = new System.Drawing.Point(0, 0);
            this.cbxStart.Name = "cbxStart";
            this.cbxStart.Size = new System.Drawing.Size(48, 44);
            this.cbxStart.TabIndex = 0;
            this.cbxStart.Text = "Start";
            this.cbxStart.UseVisualStyleBackColor = true;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCheckAll);
            this.pnlButtons.Controls.Add(this.btnUncheckAll);
            this.pnlButtons.Controls.Add(this.btnResetToDefault);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(73, 503);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.pnlButtons.Size = new System.Drawing.Size(394, 44);
            this.pnlButtons.TabIndex = 5;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.AutoSize = true;
            this.btnCheckAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCheckAll.Location = new System.Drawing.Point(140, 10);
            this.btnCheckAll.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 24);
            this.btnCheckAll.TabIndex = 2;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.AutoSize = true;
            this.btnUncheckAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUncheckAll.Location = new System.Drawing.Point(215, 10);
            this.btnUncheckAll.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(75, 24);
            this.btnUncheckAll.TabIndex = 1;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnResetToDefault
            // 
            this.btnResetToDefault.AutoSize = true;
            this.btnResetToDefault.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnResetToDefault.Location = new System.Drawing.Point(290, 10);
            this.btnResetToDefault.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnResetToDefault.Name = "btnResetToDefault";
            this.btnResetToDefault.Size = new System.Drawing.Size(94, 24);
            this.btnResetToDefault.TabIndex = 0;
            this.btnResetToDefault.Text = "Reset to Default";
            this.btnResetToDefault.UseVisualStyleBackColor = true;
            this.btnResetToDefault.Click += new System.EventHandler(this.btnResetToDefault_Click);
            // 
            // AutosplitterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "AutosplitterSettings";
            this.Size = new System.Drawing.Size(470, 550);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblAdvanced;
        private System.Windows.Forms.TreeView tvwSettings;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.CheckBox cbxReset;
        private System.Windows.Forms.CheckBox cbxSplit;
        private System.Windows.Forms.CheckBox cbxStart;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnResetToDefault;
    }
}
