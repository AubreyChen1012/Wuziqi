namespace 欢乐五子棋
{
    partial class OLMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OLMain));
            this.ChessBoard = new System.Windows.Forms.Panel();
            this.pnContent = new System.Windows.Forms.Panel();
            this.lblFirst = new System.Windows.Forms.Label();
            this.gbMsg = new System.Windows.Forms.GroupBox();
            this.btnRT = new System.Windows.Forms.Button();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.pbW = new System.Windows.Forms.PictureBox();
            this.pbShow = new System.Windows.Forms.PictureBox();
            this.pbB = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblShowIP = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.StoneType = new System.Windows.Forms.ImageList(this.components);
            this.pnContent.SuspendLayout();
            this.gbMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).BeginInit();
            this.SuspendLayout();
            // 
            // ChessBoard
            // 
            this.ChessBoard.BackColor = System.Drawing.Color.Transparent;
            this.ChessBoard.Location = new System.Drawing.Point(27, 26);
            this.ChessBoard.Name = "ChessBoard";
            this.ChessBoard.Size = new System.Drawing.Size(600, 600);
            this.ChessBoard.TabIndex = 1;
            this.ChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.ChessBoard1_Paint);
            this.ChessBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChessBoard1_MouseClick);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.Transparent;
            this.pnContent.Controls.Add(this.lblFirst);
            this.pnContent.Controls.Add(this.gbMsg);
            this.pnContent.Controls.Add(this.lblMsg1);
            this.pnContent.Controls.Add(this.pbW);
            this.pnContent.Controls.Add(this.pbShow);
            this.pnContent.Controls.Add(this.pbB);
            this.pnContent.Location = new System.Drawing.Point(648, 26);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(376, 615);
            this.pnContent.TabIndex = 3;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("隶书", 22.2F);
            this.lblFirst.Location = new System.Drawing.Point(134, 38);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 30);
            this.lblFirst.TabIndex = 16;
            // 
            // gbMsg
            // 
            this.gbMsg.BackColor = System.Drawing.Color.Transparent;
            this.gbMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbMsg.Controls.Add(this.btnRT);
            this.gbMsg.Controls.Add(this.rtbShow);
            this.gbMsg.Controls.Add(this.btnSend);
            this.gbMsg.Controls.Add(this.rtbInput);
            this.gbMsg.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbMsg.Location = new System.Drawing.Point(23, 88);
            this.gbMsg.Name = "gbMsg";
            this.gbMsg.Size = new System.Drawing.Size(299, 474);
            this.gbMsg.TabIndex = 15;
            this.gbMsg.TabStop = false;
            this.gbMsg.Text = "聊天消息";
            // 
            // btnRT
            // 
            this.btnRT.BackColor = System.Drawing.Color.Transparent;
            this.btnRT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRT.FlatAppearance.BorderSize = 0;
            this.btnRT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRT.Font = new System.Drawing.Font("华文行楷", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRT.Location = new System.Drawing.Point(47, 405);
            this.btnRT.Name = "btnRT";
            this.btnRT.Size = new System.Drawing.Size(200, 61);
            this.btnRT.TabIndex = 7;
            this.btnRT.Text = "返回主界面";
            this.btnRT.UseVisualStyleBackColor = false;
            this.btnRT.Click += new System.EventHandler(this.BtnRT_Click);
            // 
            // rtbShow
            // 
            this.rtbShow.BackColor = System.Drawing.Color.White;
            this.rtbShow.Location = new System.Drawing.Point(11, 26);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.ReadOnly = true;
            this.rtbShow.Size = new System.Drawing.Size(279, 300);
            this.rtbShow.TabIndex = 0;
            this.rtbShow.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Location = new System.Drawing.Point(230, 340);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(60, 58);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // rtbInput
            // 
            this.rtbInput.BackColor = System.Drawing.Color.White;
            this.rtbInput.Location = new System.Drawing.Point(11, 340);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(219, 59);
            this.rtbInput.TabIndex = 11;
            this.rtbInput.Text = "";
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.Font = new System.Drawing.Font("隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg1.Location = new System.Drawing.Point(124, 32);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(193, 30);
            this.lblMsg1.TabIndex = 2;
            this.lblMsg1.Text = "等待黑棋下棋";
            // 
            // pbW
            // 
            this.pbW.BackgroundImage = global::欢乐五子棋.Properties.Resources.白;
            this.pbW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbW.Location = new System.Drawing.Point(78, 24);
            this.pbW.Name = "pbW";
            this.pbW.Size = new System.Drawing.Size(40, 44);
            this.pbW.TabIndex = 0;
            this.pbW.TabStop = false;
            // 
            // pbShow
            // 
            this.pbShow.BackgroundImage = global::欢乐五子棋.Properties.Resources.黑;
            this.pbShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbShow.Location = new System.Drawing.Point(32, 24);
            this.pbShow.Name = "pbShow";
            this.pbShow.Size = new System.Drawing.Size(40, 44);
            this.pbShow.TabIndex = 0;
            this.pbShow.TabStop = false;
            // 
            // pbB
            // 
            this.pbB.BackgroundImage = global::欢乐五子棋.Properties.Resources.黑;
            this.pbB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbB.Location = new System.Drawing.Point(78, 24);
            this.pbB.Name = "pbB";
            this.pbB.Size = new System.Drawing.Size(40, 44);
            this.pbB.TabIndex = 0;
            this.pbB.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::欢乐五子棋.Properties.Resources.close_default;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1103, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblShowIP
            // 
            this.lblShowIP.AutoSize = true;
            this.lblShowIP.BackColor = System.Drawing.Color.Transparent;
            this.lblShowIP.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowIP.Location = new System.Drawing.Point(506, 661);
            this.lblShowIP.Name = "lblShowIP";
            this.lblShowIP.Size = new System.Drawing.Size(34, 22);
            this.lblShowIP.TabIndex = 6;
            this.lblShowIP.Text = "IP";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.BackColor = System.Drawing.Color.Transparent;
            this.lblHost.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHost.Location = new System.Drawing.Point(403, 660);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(103, 22);
            this.lblHost.TabIndex = 6;
            this.lblHost.Text = "本机IP：";
            // 
            // StoneType
            // 
            this.StoneType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("StoneType.ImageStream")));
            this.StoneType.TransparentColor = System.Drawing.Color.Transparent;
            this.StoneType.Images.SetKeyName(0, "白.png");
            this.StoneType.Images.SetKeyName(1, "黑.png");
            // 
            // OLMain
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::欢乐五子棋.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1146, 710);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblShowIP);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ChessBoard);
            this.Controls.Add(this.pnContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OLMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "联网对战";
            this.Load += new System.EventHandler(this.OLMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OLMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OLMain_MouseMove);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.gbMsg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel ChessBoard;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbW;
        private System.Windows.Forms.PictureBox pbB;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.GroupBox gbMsg;
        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblShowIP;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.PictureBox pbShow;
		private System.Windows.Forms.ImageList StoneType;
		private System.Windows.Forms.Button btnRT;
	}
}