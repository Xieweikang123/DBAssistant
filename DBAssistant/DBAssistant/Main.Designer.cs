namespace DBAssistant
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDbVersion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clbDbList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.clbTableList = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTableSearch = new System.Windows.Forms.TextBox();
            this.rtbSql = new System.Windows.Forms.RichTextBox();
            this.cmbSqlConStr = new System.Windows.Forms.ComboBox();
            this.btnConnConfig = new System.Windows.Forms.Button();
            this.txtBoxFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(864, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据库连接字符串";
            // 
            // lblDbVersion
            // 
            this.lblDbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDbVersion.AutoSize = true;
            this.lblDbVersion.Location = new System.Drawing.Point(820, 617);
            this.lblDbVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDbVersion.Name = "lblDbVersion";
            this.lblDbVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDbVersion.Size = new System.Drawing.Size(82, 15);
            this.lblDbVersion.TabIndex = 3;
            this.lblDbVersion.Text = "数据库信息";
            this.lblDbVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 26);
            this.toolStripMenuItem2.Text = "11";
            // 
            // clbDbList
            // 
            this.clbDbList.CheckOnClick = true;
            this.clbDbList.FormattingEnabled = true;
            this.clbDbList.HorizontalScrollbar = true;
            this.clbDbList.Location = new System.Drawing.Point(36, 141);
            this.clbDbList.Name = "clbDbList";
            this.clbDbList.Size = new System.Drawing.Size(202, 424);
            this.clbDbList.TabIndex = 6;
            this.clbDbList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.dbList_ItemCheck);
            this.clbDbList.SelectedIndexChanged += new System.EventHandler(this.clbDbList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "数据库列表:";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMsg.Location = new System.Drawing.Point(13, 606);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(37, 15);
            this.lblMsg.TabIndex = 8;
            this.lblMsg.Text = "消息";
            // 
            // clbTableList
            // 
            this.clbTableList.CheckOnClick = true;
            this.clbTableList.ContextMenuStrip = this.contextMenuStrip1;
            this.clbTableList.HorizontalScrollbar = true;
            this.clbTableList.Location = new System.Drawing.Point(294, 141);
            this.clbTableList.Name = "clbTableList";
            this.clbTableList.Size = new System.Drawing.Size(221, 424);
            this.clbTableList.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.备份表ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 52);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // 备份表ToolStripMenuItem
            // 
            this.备份表ToolStripMenuItem.Name = "备份表ToolStripMenuItem";
            this.备份表ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.备份表ToolStripMenuItem.Text = "备份表";
            this.备份表ToolStripMenuItem.Click += new System.EventHandler(this.备份表ToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "表:";
            // 
            // txtTableSearch
            // 
            this.txtTableSearch.Location = new System.Drawing.Point(329, 84);
            this.txtTableSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtTableSearch.Name = "txtTableSearch";
            this.txtTableSearch.Size = new System.Drawing.Size(173, 25);
            this.txtTableSearch.TabIndex = 11;
            this.txtTableSearch.TextChanged += new System.EventHandler(this.txtTableSearch_TextChanged);
            // 
            // rtbSql
            // 
            this.rtbSql.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtbSql.ForeColor = System.Drawing.SystemColors.Info;
            this.rtbSql.Location = new System.Drawing.Point(568, 141);
            this.rtbSql.Name = "rtbSql";
            this.rtbSql.Size = new System.Drawing.Size(462, 424);
            this.rtbSql.TabIndex = 13;
            this.rtbSql.Text = "";
            // 
            // cmbSqlConStr
            // 
            this.cmbSqlConStr.FormattingEnabled = true;
            this.cmbSqlConStr.Items.AddRange(new object[] {
            "Initial Catalog=WalkerDB;Data Source=.;User ID =sa;password=123456",
            "21"});
            this.cmbSqlConStr.Location = new System.Drawing.Point(229, 49);
            this.cmbSqlConStr.Name = "cmbSqlConStr";
            this.cmbSqlConStr.Size = new System.Drawing.Size(629, 23);
            this.cmbSqlConStr.TabIndex = 14;
            // 
            // btnConnConfig
            // 
            this.btnConnConfig.Location = new System.Drawing.Point(864, 42);
            this.btnConnConfig.Name = "btnConnConfig";
            this.btnConnConfig.Size = new System.Drawing.Size(88, 35);
            this.btnConnConfig.TabIndex = 15;
            this.btnConnConfig.Text = "配置";
            this.btnConnConfig.UseVisualStyleBackColor = true;
            this.btnConnConfig.Click += new System.EventHandler(this.btnConnConfig_Click);
            // 
            // txtBoxFile
            // 
            this.txtBoxFile.Location = new System.Drawing.Point(568, 84);
            this.txtBoxFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxFile.Name = "txtBoxFile";
            this.txtBoxFile.Size = new System.Drawing.Size(173, 25);
            this.txtBoxFile.TabIndex = 17;
            this.txtBoxFile.TextChanged += new System.EventHandler(this.txtBoxFile_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "字段:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 641);
            this.Controls.Add(this.txtBoxFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConnConfig);
            this.Controls.Add(this.cmbSqlConStr);
            this.Controls.Add(this.rtbSql);
            this.Controls.Add(this.txtTableSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbTableList);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clbDbList);
            this.Controls.Add(this.lblDbVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库帮助1.2";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.Main_Click);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDbVersion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.CheckedListBox clbDbList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.CheckedListBox clbTableList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTableSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbSql;
        private System.Windows.Forms.ComboBox cmbSqlConStr;
        private System.Windows.Forms.Button btnConnConfig;
        private System.Windows.Forms.ToolStripMenuItem 备份表ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBoxFile;
        private System.Windows.Forms.Label label4;
    }
}

