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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSqlConStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDbVersion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clbDbList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.clbTableList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTableSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbSql = new System.Windows.Forms.RichTextBox();
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
            this.button1.Location = new System.Drawing.Point(405, 528);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSqlConStr
            // 
            this.txtSqlConStr.Location = new System.Drawing.Point(231, 49);
            this.txtSqlConStr.Margin = new System.Windows.Forms.Padding(4);
            this.txtSqlConStr.Name = "txtSqlConStr";
            this.txtSqlConStr.Size = new System.Drawing.Size(629, 25);
            this.txtSqlConStr.TabIndex = 1;
            this.txtSqlConStr.Text = "Initial Catalog=WalkerDB;Data Source=.;User ID =sa;password=123456";
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
            this.clbDbList.Location = new System.Drawing.Point(36, 120);
            this.clbDbList.Name = "clbDbList";
            this.clbDbList.Size = new System.Drawing.Size(202, 344);
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
            this.clbTableList.FormattingEnabled = true;
            this.clbTableList.Location = new System.Drawing.Point(347, 141);
            this.clbTableList.Name = "clbTableList";
            this.clbTableList.Size = new System.Drawing.Size(208, 344);
            this.clbTableList.TabIndex = 9;
            this.clbTableList.Click += new System.EventHandler(this.clbTableList_Click);
            this.clbTableList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clbTableList_MouseClick);
            this.clbTableList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clbTableList_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "表:";
            // 
            // txtTableSearch
            // 
            this.txtTableSearch.Location = new System.Drawing.Point(382, 99);
            this.txtTableSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtTableSearch.Name = "txtTableSearch";
            this.txtTableSearch.Size = new System.Drawing.Size(173, 25);
            this.txtTableSearch.TabIndex = 11;
            this.txtTableSearch.TextChanged += new System.EventHandler(this.txtTableSearch_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 28);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // rtbSql
            // 
            this.rtbSql.Location = new System.Drawing.Point(608, 165);
            this.rtbSql.Name = "rtbSql";
            this.rtbSql.Size = new System.Drawing.Size(365, 253);
            this.rtbSql.TabIndex = 13;
            this.rtbSql.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 641);
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
            this.Controls.Add(this.txtSqlConStr);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSqlConStr;
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
    }
}

