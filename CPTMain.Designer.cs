namespace 欢乐五子棋
{
    partial class CPTMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPTMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHQ = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.History = new System.Windows.Forms.ListBox();
            this.pbDjs = new System.Windows.Forms.GroupBox();
            this.lblDjs = new System.Windows.Forms.Label();
            this.PBCB = new System.Windows.Forms.PictureBox();
            this.rcpt = new System.Windows.Forms.RadioButton();
            this.rplayer = new System.Windows.Forms.RadioButton();
            this.Djs = new System.Windows.Forms.Timer(this.components);
            this.gbhistory = new System.Windows.Forms.GroupBox();
            this.gbDY = new System.Windows.Forms.GroupBox();
            this.gbstonetype = new System.Windows.Forms.GroupBox();
            this.lblWhite = new System.Windows.Forms.Label();
            this.lblBlack = new System.Windows.Forms.Label();
            this.btnWhite = new System.Windows.Forms.Button();
            this.StoneType = new System.Windows.Forms.ImageList(this.components);
            this.btnBlack = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.返回上级菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.BtnRT = new System.Windows.Forms.Button();
            this.pbDjs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCB)).BeginInit();
            this.gbhistory.SuspendLayout();
            this.gbDY.SuspendLayout();
            this.gbstonetype.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("华文行楷", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(860, 234);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 61);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.btnHQ.Font = new System.Drawing.Font("华文行楷", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHQ.Location = new System.Drawing.Point(861, 309);
            this.btnHQ.Name = "btnHQ";
            this.btnHQ.Size = new System.Drawing.Size(200, 61);
            this.btnHQ.TabIndex = 2;
            this.btnHQ.Text = "悔棋";
            this.btnHQ.UseVisualStyleBackColor = false;
            this.btnHQ.Click += new System.EventHandler(this.btnHQ_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("华文行楷", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(860, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 61);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出游戏";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 退出游戏ToolStripMenuItem
            // 
            this.退出游戏ToolStripMenuItem.Name = "退出游戏ToolStripMenuItem";
            this.退出游戏ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出游戏ToolStripMenuItem.Text = "退出游戏";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.White;
            this.History.FormattingEnabled = true;
            this.History.ItemHeight = 22;
            this.History.Location = new System.Drawing.Point(8, 27);
            this.History.Margin = new System.Windows.Forms.Padding(2);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(168, 136);
            this.History.TabIndex = 17;
            // 
            // pbDjs
            // 
            this.pbDjs.BackColor = System.Drawing.Color.Transparent;
            this.pbDjs.Controls.Add(this.lblDjs);
            this.pbDjs.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pbDjs.Location = new System.Drawing.Point(653, 30);
            this.pbDjs.Margin = new System.Windows.Forms.Padding(2);
            this.pbDjs.Name = "pbDjs";
            this.pbDjs.Padding = new System.Windows.Forms.Padding(2);
            this.pbDjs.Size = new System.Drawing.Size(188, 56);
            this.pbDjs.TabIndex = 18;
            this.pbDjs.TabStop = false;
            this.pbDjs.Text = "倒计时";
            // 
            // lblDjs
            // 
            this.lblDjs.Font = new System.Drawing.Font("隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDjs.ForeColor = System.Drawing.Color.Black;
            this.lblDjs.Location = new System.Drawing.Point(20, 19);
            this.lblDjs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDjs.Name = "lblDjs";
            this.lblDjs.Size = new System.Drawing.Size(141, 29);
            this.lblDjs.TabIndex = 0;
            this.lblDjs.Text = "30";
            this.lblDjs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBCB
            // 
            this.PBCB.BackColor = System.Drawing.Color.Transparent;
            this.PBCB.Location = new System.Drawing.Point(14, 20);
            this.PBCB.Name = "PBCB";
            this.PBCB.Size = new System.Drawing.Size(601, 601);
            this.PBCB.TabIndex = 19;
            this.PBCB.TabStop = false;
            this.PBCB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBCB_MouseDown);
            // 
            // rcpt
            // 
            this.rcpt.AutoSize = true;
            this.rcpt.BackColor = System.Drawing.Color.Transparent;
            this.rcpt.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rcpt.Location = new System.Drawing.Point(917, 72);
            this.rcpt.Name = "rcpt";
            this.rcpt.Size = new System.Drawing.Size(94, 26);
            this.rcpt.TabIndex = 20;
            this.rcpt.Text = "电脑先";
            this.rcpt.UseVisualStyleBackColor = false;
            this.rcpt.CheckedChanged += new System.EventHandler(this.rcpt_CheckedChanged);
            // 
            // rplayer
            // 
            this.rplayer.AutoSize = true;
            this.rplayer.BackColor = System.Drawing.Color.Transparent;
            this.rplayer.Checked = true;
            this.rplayer.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rplayer.Location = new System.Drawing.Point(917, 43);
            this.rplayer.Name = "rplayer";
            this.rplayer.Size = new System.Drawing.Size(94, 26);
            this.rplayer.TabIndex = 20;
            this.rplayer.TabStop = true;
            this.rplayer.Text = "玩家先";
            this.rplayer.UseVisualStyleBackColor = false;
            this.rplayer.CheckedChanged += new System.EventHandler(this.rplayer_CheckedChanged);
            // 
            // Djs
            // 
            this.Djs.Interval = 1000;
            this.Djs.Tick += new System.EventHandler(this.Djs_Tick);
            // 
            // gbhistory
            // 
            this.gbhistory.BackColor = System.Drawing.Color.Transparent;
            this.gbhistory.Controls.Add(this.History);
            this.gbhistory.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbhistory.Location = new System.Drawing.Point(656, 97);
            this.gbhistory.Margin = new System.Windows.Forms.Padding(2);
            this.gbhistory.Name = "gbhistory";
            this.gbhistory.Padding = new System.Windows.Forms.Padding(2);
            this.gbhistory.Size = new System.Drawing.Size(185, 170);
            this.gbhistory.TabIndex = 22;
            this.gbhistory.TabStop = false;
            this.gbhistory.Text = "历史记录";
            // 
            // gbDY
            // 
            this.gbDY.BackColor = System.Drawing.Color.Transparent;
            this.gbDY.Controls.Add(this.PBCB);
            this.gbDY.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbDY.Location = new System.Drawing.Point(9, 10);
            this.gbDY.Margin = new System.Windows.Forms.Padding(2);
            this.gbDY.Name = "gbDY";
            this.gbDY.Padding = new System.Windows.Forms.Padding(2);
            this.gbDY.Size = new System.Drawing.Size(632, 642);
            this.gbDY.TabIndex = 23;
            this.gbDY.TabStop = false;
            this.gbDY.Text = "对弈";
            // 
            // gbstonetype
            // 
            this.gbstonetype.BackColor = System.Drawing.Color.Transparent;
            this.gbstonetype.Controls.Add(this.lblWhite);
            this.gbstonetype.Controls.Add(this.lblBlack);
            this.gbstonetype.Controls.Add(this.btnWhite);
            this.gbstonetype.Controls.Add(this.btnBlack);
            this.gbstonetype.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbstonetype.Location = new System.Drawing.Point(653, 291);
            this.gbstonetype.Margin = new System.Windows.Forms.Padding(2);
            this.gbstonetype.Name = "gbstonetype";
            this.gbstonetype.Padding = new System.Windows.Forms.Padding(2);
            this.gbstonetype.Size = new System.Drawing.Size(185, 126);
            this.gbstonetype.TabIndex = 24;
            this.gbstonetype.TabStop = false;
            this.gbstonetype.Text = "棋子类型";
            // 
            // lblWhite
            // 
            this.lblWhite.AutoSize = true;
            this.lblWhite.Font = new System.Drawing.Font("隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWhite.Location = new System.Drawing.Point(4, 79);
            this.lblWhite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(103, 30);
            this.lblWhite.TabIndex = 0;
            this.lblWhite.Text = "白棋：";
            // 
            // lblBlack
            // 
            this.lblBlack.AutoSize = true;
            this.lblBlack.Font = new System.Drawing.Font("隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBlack.Location = new System.Drawing.Point(4, 30);
            this.lblBlack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(103, 30);
            this.lblBlack.TabIndex = 0;
            this.lblBlack.Text = "黑棋：";
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.Transparent;
            this.btnWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhite.FlatAppearance.BorderSize = 0;
            this.btnWhite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWhite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWhite.ForeColor = System.Drawing.Color.Transparent;
            this.btnWhite.ImageKey = "白.png";
            this.btnWhite.ImageList = this.StoneType;
            this.btnWhite.Location = new System.Drawing.Point(108, 79);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(42, 39);
            this.btnWhite.TabIndex = 15;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.BtnWhite_Click);
            // 
            // StoneType
            // 
            this.StoneType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("StoneType.ImageStream")));
            this.StoneType.TransparentColor = System.Drawing.Color.Transparent;
            this.StoneType.Images.SetKeyName(0, "白.png");
            this.StoneType.Images.SetKeyName(1, "黑.png");
            this.StoneType.Images.SetKeyName(2, "黄.png");
            this.StoneType.Images.SetKeyName(3, "蓝.png");
            this.StoneType.Images.SetKeyName(4, "绿.png");
            this.StoneType.Images.SetKeyName(5, "青.png");
            this.StoneType.Images.SetKeyName(6, "橙.png");
            this.StoneType.Images.SetKeyName(7, "粉红.png");
            this.StoneType.Images.SetKeyName(8, "浅蓝.png");
            this.StoneType.Images.SetKeyName(9, "浅绿.png");
            this.StoneType.Images.SetKeyName(10, "紫.png");
            this.StoneType.Images.SetKeyName(11, "红.png");
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Transparent;
            this.btnBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlack.FlatAppearance.BorderSize = 0;
            this.btnBlack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBlack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBlack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBlack.ImageKey = "黑.png";
            this.btnBlack.ImageList = this.StoneType;
            this.btnBlack.Location = new System.Drawing.Point(108, 27);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(42, 46);
            this.btnBlack.TabIndex = 15;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.BtnBlack_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.返回上级菜单ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(149, 114);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.默认ToolStripMenuItem,
            this.自定义ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "背景";
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
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem4.Text = "退出游戏";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // 返回上级菜单ToolStripMenuItem
            // 
            this.返回上级菜单ToolStripMenuItem.Name = "返回上级菜单ToolStripMenuItem";
            this.返回上级菜单ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.返回上级菜单ToolStripMenuItem.Text = "返回上级菜单";
            this.返回上级菜单ToolStripMenuItem.Click += new System.EventHandler(this.返回上级菜单ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem2.Text = "关于";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem3.Text = "帮助";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::欢乐五子棋.Properties.Resources.close_default;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(1102, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 30);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
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
            this.BtnRT.Location = new System.Drawing.Point(861, 376);
            this.BtnRT.Name = "BtnRT";
            this.BtnRT.Size = new System.Drawing.Size(200, 61);
            this.BtnRT.TabIndex = 3;
            this.BtnRT.Text = "返回主界面";
            this.BtnRT.UseVisualStyleBackColor = false;
            this.BtnRT.Click += new System.EventHandler(this.BtnRT_Click);
            // 
            // CPTMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::欢乐五子棋.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1146, 710);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbstonetype);
            this.Controls.Add(this.gbDY);
            this.Controls.Add(this.gbhistory);
            this.Controls.Add(this.rplayer);
            this.Controls.Add(this.rcpt);
            this.Controls.Add(this.pbDjs);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnHQ);
            this.Controls.Add(this.BtnRT);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CPTMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人机对战";
            this.pbDjs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBCB)).EndInit();
            this.gbhistory.ResumeLayout(false);
            this.gbDY.ResumeLayout(false);
            this.gbstonetype.ResumeLayout(false);
            this.gbstonetype.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHQ;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ListBox History;
        private System.Windows.Forms.GroupBox pbDjs;
        private System.Windows.Forms.RadioButton rcpt;
        private System.Windows.Forms.RadioButton rplayer;
        private System.Windows.Forms.Timer Djs;
        private System.Windows.Forms.Label lblDjs;
        private System.Windows.Forms.GroupBox gbhistory;
        private System.Windows.Forms.GroupBox gbDY;
        private System.Windows.Forms.PictureBox PBCB;
        private System.Windows.Forms.GroupBox gbstonetype;
        private System.Windows.Forms.Label lblWhite;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.ImageList StoneType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 默认ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片14ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景图片10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 返回上级菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button BtnRT;
    }
}