namespace 欢乐五子棋
{
    partial class EVWMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EVWMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHQ = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景图片1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景图片2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景图片3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景图片14ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景图片5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景图片6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景图片7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景图片8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景图片9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景图片10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.棋盘颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.灰色默认ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.红色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.白色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回上级菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.BtnRT = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("华文行楷", 22.2F);
            this.btnExit.Location = new System.Drawing.Point(691, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 61);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出游戏";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHQ
            // 
            this.btnHQ.BackColor = System.Drawing.Color.Transparent;
            this.btnHQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHQ.FlatAppearance.BorderSize = 0;
            this.btnHQ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHQ.Font = new System.Drawing.Font("华文行楷", 22.2F);
            this.btnHQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHQ.Location = new System.Drawing.Point(691, 259);
            this.btnHQ.Name = "btnHQ";
            this.btnHQ.Size = new System.Drawing.Size(200, 61);
            this.btnHQ.TabIndex = 2;
            this.btnHQ.Text = "悔棋";
            this.btnHQ.UseVisualStyleBackColor = false;
            this.btnHQ.Click += new System.EventHandler(this.btnHQ_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.棋盘颜色ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.返回上级菜单ToolStripMenuItem,
            this.退出游戏ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 136);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.默认ToolStripMenuItem,
            this.自定义ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.设置ToolStripMenuItem.Text = "背景";
            // 
            // 默认ToolStripMenuItem
            // 
            this.默认ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.背景图片1ToolStripMenuItem,
            this.背景图片2ToolStripMenuItem,
            this.背景图片3ToolStripMenuItem,
            this.背景图片14ToolStripMenuItem,
            this.背景图片5ToolStripMenuItem,
            this.背景图片6ToolStripMenuItem,
            this.背景图片7ToolStripMenuItem,
            this.背景图片8ToolStripMenuItem,
            this.背景图片9ToolStripMenuItem,
            this.背景图片10ToolStripMenuItem});
            this.默认ToolStripMenuItem.Name = "默认ToolStripMenuItem";
            this.默认ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.默认ToolStripMenuItem.Text = "默认";
            // 
            // 背景图片1ToolStripMenuItem
            // 
            this.背景图片1ToolStripMenuItem.Name = "背景图片1ToolStripMenuItem";
            this.背景图片1ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.背景图片1ToolStripMenuItem.Text = "背景图片1";
            this.背景图片1ToolStripMenuItem.Click += new System.EventHandler(this.背景图片1ToolStripMenuItem_Click);
            // 
            // 背景图片2ToolStripMenuItem
            // 
            this.背景图片2ToolStripMenuItem.Name = "背景图片2ToolStripMenuItem";
            this.背景图片2ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.背景图片2ToolStripMenuItem.Text = "背景图片2";
            this.背景图片2ToolStripMenuItem.Click += new System.EventHandler(this.背景图片2ToolStripMenuItem_Click);
            // 
            // 背景图片3ToolStripMenuItem
            // 
            this.背景图片3ToolStripMenuItem.Name = "背景图片3ToolStripMenuItem";
            this.背景图片3ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.背景图片3ToolStripMenuItem.Text = "背景图片3";
            this.背景图片3ToolStripMenuItem.Click += new System.EventHandler(this.背景图片3ToolStripMenuItem_Click);
            // 
            // 背景图片14ToolStripMenuItem
            // 
            this.背景图片14ToolStripMenuItem.Name = "背景图片14ToolStripMenuItem";
            this.背景图片14ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.背景图片14ToolStripMenuItem.Text = "背景图片4";
            this.背景图片14ToolStripMenuItem.Click += new System.EventHandler(this.背景图片14ToolStripMenuItem_Click);
            // 
            // 背景图片5ToolStripMenuItem
            // 
            this.背景图片5ToolStripMenuItem.Name = "背景图片5ToolStripMenuItem";
            this.背景图片5ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.背景图片5ToolStripMenuItem.Text = "背景图片5";
            this.背景图片5ToolStripMenuItem.Click += new System.EventHandler(this.背景图片5ToolStripMenuItem_Click);
            // 
            // 背景图片6ToolStripMenuItem
            // 
            this.背景图片6ToolStripMenuItem.Name = "背景图片6ToolStripMenuItem";
            this.背景图片6ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.背景图片6ToolStripMenuItem.Text = "背景图片6";
            this.背景图片6ToolStripMenuItem.Click += new System.EventHandler(this.背景图片6ToolStripMenuItem_Click);
            // 
            // 背景图片7ToolStripMenuItem
            // 
            this.背景图片7ToolStripMenuItem.Name = "背景图片7ToolStripMenuItem";
            this.背景图片7ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.背景图片7ToolStripMenuItem.Text = "背景图片7";
            this.背景图片7ToolStripMenuItem.Click += new System.EventHandler(this.背景图片7ToolStripMenuItem_Click);
            // 
            // 背景图片8ToolStripMenuItem
            // 
            this.背景图片8ToolStripMenuItem.Name = "背景图片8ToolStripMenuItem";
            this.背景图片8ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.背景图片8ToolStripMenuItem.Text = "背景图片8";
            this.背景图片8ToolStripMenuItem.Click += new System.EventHandler(this.背景图片8ToolStripMenuItem_Click);
            // 
            // 背景图片9ToolStripMenuItem
            // 
            this.背景图片9ToolStripMenuItem.Name = "背景图片9ToolStripMenuItem";
            this.背景图片9ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.背景图片9ToolStripMenuItem.Text = "背景图片9";
            this.背景图片9ToolStripMenuItem.Click += new System.EventHandler(this.背景图片9ToolStripMenuItem_Click);
            // 
            // 背景图片10ToolStripMenuItem
            // 
            this.背景图片10ToolStripMenuItem.Name = "背景图片10ToolStripMenuItem";
            this.背景图片10ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.背景图片10ToolStripMenuItem.Text = "背景图片10";
            this.背景图片10ToolStripMenuItem.Click += new System.EventHandler(this.背景图片10ToolStripMenuItem_Click);
            // 
            // 自定义ToolStripMenuItem
            // 
            this.自定义ToolStripMenuItem.Name = "自定义ToolStripMenuItem";
            this.自定义ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.自定义ToolStripMenuItem.Text = "自定义背景图片";
            this.自定义ToolStripMenuItem.Click += new System.EventHandler(this.自定义ToolStripMenuItem_Click);
            // 
            // 棋盘颜色ToolStripMenuItem
            // 
            this.棋盘颜色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.灰色默认ToolStripMenuItem,
            this.红色ToolStripMenuItem,
            this.白色ToolStripMenuItem,
            this.黑色ToolStripMenuItem,
            this.自定义颜色ToolStripMenuItem});
            this.棋盘颜色ToolStripMenuItem.Name = "棋盘颜色ToolStripMenuItem";
            this.棋盘颜色ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.棋盘颜色ToolStripMenuItem.Text = "棋盘颜色";
            // 
            // 灰色默认ToolStripMenuItem
            // 
            this.灰色默认ToolStripMenuItem.Name = "灰色默认ToolStripMenuItem";
            this.灰色默认ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.灰色默认ToolStripMenuItem.Text = "灰色（默认）";
            this.灰色默认ToolStripMenuItem.Click += new System.EventHandler(this.灰色默认ToolStripMenuItem_Click);
            // 
            // 红色ToolStripMenuItem
            // 
            this.红色ToolStripMenuItem.Name = "红色ToolStripMenuItem";
            this.红色ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.红色ToolStripMenuItem.Text = "红色";
            this.红色ToolStripMenuItem.Click += new System.EventHandler(this.红色ToolStripMenuItem_Click);
            // 
            // 白色ToolStripMenuItem
            // 
            this.白色ToolStripMenuItem.Name = "白色ToolStripMenuItem";
            this.白色ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.白色ToolStripMenuItem.Text = "蓝色";
            this.白色ToolStripMenuItem.Click += new System.EventHandler(this.白色ToolStripMenuItem_Click);
            // 
            // 黑色ToolStripMenuItem
            // 
            this.黑色ToolStripMenuItem.Name = "黑色ToolStripMenuItem";
            this.黑色ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.黑色ToolStripMenuItem.Text = "黑色";
            this.黑色ToolStripMenuItem.Click += new System.EventHandler(this.黑色ToolStripMenuItem_Click);
            // 
            // 自定义颜色ToolStripMenuItem
            // 
            this.自定义颜色ToolStripMenuItem.Name = "自定义颜色ToolStripMenuItem";
            this.自定义颜色ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.自定义颜色ToolStripMenuItem.Text = "自定义颜色";
            this.自定义颜色ToolStripMenuItem.Click += new System.EventHandler(this.自定义颜色ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 返回上级菜单ToolStripMenuItem
            // 
            this.返回上级菜单ToolStripMenuItem.Name = "返回上级菜单ToolStripMenuItem";
            this.返回上级菜单ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.返回上级菜单ToolStripMenuItem.Text = "返回上级菜单";
            this.返回上级菜单ToolStripMenuItem.Click += new System.EventHandler(this.返回上级菜单ToolStripMenuItem_Click);
            // 
            // 退出游戏ToolStripMenuItem
            // 
            this.退出游戏ToolStripMenuItem.Name = "退出游戏ToolStripMenuItem";
            this.退出游戏ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.退出游戏ToolStripMenuItem.Text = "退出游戏";
            this.退出游戏ToolStripMenuItem.Click += new System.EventHandler(this.退出游戏ToolStripMenuItem_Click);
            // 
            // btnRStart
            // 
            this.btnRStart.BackColor = System.Drawing.Color.Transparent;
            this.btnRStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRStart.FlatAppearance.BorderSize = 0;
            this.btnRStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRStart.Font = new System.Drawing.Font("华文行楷", 22.2F);
            this.btnRStart.Location = new System.Drawing.Point(691, 166);
            this.btnRStart.Name = "btnRStart";
            this.btnRStart.Size = new System.Drawing.Size(200, 61);
            this.btnRStart.TabIndex = 1;
            this.btnRStart.Text = "开始游戏";
            this.btnRStart.UseVisualStyleBackColor = false;
            this.btnRStart.Click += new System.EventHandler(this.btnRStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("隶书", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(707, 490);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "玩家一";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("隶书", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(707, 553);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "玩家二";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::欢乐五子棋.Properties.Resources.tx1;
            this.pictureBox1.Location = new System.Drawing.Point(827, 480);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::欢乐五子棋.Properties.Resources.tx2;
            this.pictureBox2.Location = new System.Drawing.Point(827, 553);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseClick);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::欢乐五子棋.Properties.Resources.close_default;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1108, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 30);
            this.btnClose.TabIndex = 19;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnRT
            // 
            this.BtnRT.BackColor = System.Drawing.Color.Transparent;
            this.BtnRT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRT.FlatAppearance.BorderSize = 0;
            this.BtnRT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnRT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRT.Font = new System.Drawing.Font("华文行楷", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRT.Location = new System.Drawing.Point(700, 326);
            this.BtnRT.Name = "BtnRT";
            this.BtnRT.Size = new System.Drawing.Size(200, 61);
            this.BtnRT.TabIndex = 20;
            this.BtnRT.Text = "返回主界面";
            this.BtnRT.UseVisualStyleBackColor = false;
            this.BtnRT.Click += new System.EventHandler(this.BtnRT_Click);
            // 
            // EVWMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1146, 710);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.BtnRT);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRStart);
            this.Controls.Add(this.btnHQ);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EVWMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "双人对战";
            this.Load += new System.EventHandler(this.EVWMain_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EVWMain_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHQ;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Button btnRStart;
        private System.Windows.Forms.ToolStripMenuItem 返回上级菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 默认ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片14ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 棋盘颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 灰色默认ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 红色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 白色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义颜色ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnRT;
    }
}