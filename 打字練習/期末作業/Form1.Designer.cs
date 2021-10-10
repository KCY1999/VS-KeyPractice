namespace 期末作業
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暫停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新挑戰ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.結束ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.簡單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中等ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.困難ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地獄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.闖關模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音效開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景音樂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.點擊音樂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部音效ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音效關ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景音樂ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.點擊音樂ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.全部音效ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.排行榜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.遊戲ToolStripMenuItem,
            this.模式ToolStripMenuItem,
            this.排行榜ToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.關於ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 遊戲ToolStripMenuItem
            // 
            this.遊戲ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開始ToolStripMenuItem,
            this.暫停ToolStripMenuItem,
            this.重新挑戰ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.結束ToolStripMenuItem1});
            this.遊戲ToolStripMenuItem.Name = "遊戲ToolStripMenuItem";
            this.遊戲ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.遊戲ToolStripMenuItem.Text = "遊戲";
            // 
            // 開始ToolStripMenuItem
            // 
            this.開始ToolStripMenuItem.Name = "開始ToolStripMenuItem";
            this.開始ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.開始ToolStripMenuItem.Text = "開始/繼續";
            this.開始ToolStripMenuItem.Click += new System.EventHandler(this.開始ToolStripMenuItem_Click);
            // 
            // 暫停ToolStripMenuItem
            // 
            this.暫停ToolStripMenuItem.Name = "暫停ToolStripMenuItem";
            this.暫停ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.暫停ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.暫停ToolStripMenuItem.Text = "暫停";
            this.暫停ToolStripMenuItem.Click += new System.EventHandler(this.暫停ToolStripMenuItem_Click);
            // 
            // 重新挑戰ToolStripMenuItem
            // 
            this.重新挑戰ToolStripMenuItem.Name = "重新挑戰ToolStripMenuItem";
            this.重新挑戰ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.重新挑戰ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.重新挑戰ToolStripMenuItem.Text = "重新挑戰";
            this.重新挑戰ToolStripMenuItem.Click += new System.EventHandler(this.重新挑戰ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // 結束ToolStripMenuItem1
            // 
            this.結束ToolStripMenuItem1.Name = "結束ToolStripMenuItem1";
            this.結束ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.結束ToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.結束ToolStripMenuItem1.Text = "結束";
            this.結束ToolStripMenuItem1.Click += new System.EventHandler(this.結束ToolStripMenuItem1_Click);
            // 
            // 模式ToolStripMenuItem
            // 
            this.模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.簡單ToolStripMenuItem,
            this.中等ToolStripMenuItem,
            this.困難ToolStripMenuItem,
            this.地獄ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.闖關模式ToolStripMenuItem});
            this.模式ToolStripMenuItem.Name = "模式ToolStripMenuItem";
            this.模式ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.模式ToolStripMenuItem.Text = "模式";
            // 
            // 簡單ToolStripMenuItem
            // 
            this.簡單ToolStripMenuItem.Name = "簡單ToolStripMenuItem";
            this.簡單ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.簡單ToolStripMenuItem.Text = "簡單";
            this.簡單ToolStripMenuItem.Click += new System.EventHandler(this.簡單ToolStripMenuItem_Click);
            // 
            // 中等ToolStripMenuItem
            // 
            this.中等ToolStripMenuItem.Name = "中等ToolStripMenuItem";
            this.中等ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.中等ToolStripMenuItem.Text = "中等";
            this.中等ToolStripMenuItem.Click += new System.EventHandler(this.中等ToolStripMenuItem_Click);
            // 
            // 困難ToolStripMenuItem
            // 
            this.困難ToolStripMenuItem.Name = "困難ToolStripMenuItem";
            this.困難ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.困難ToolStripMenuItem.Text = "困難";
            this.困難ToolStripMenuItem.Click += new System.EventHandler(this.困難ToolStripMenuItem_Click);
            // 
            // 地獄ToolStripMenuItem
            // 
            this.地獄ToolStripMenuItem.Name = "地獄ToolStripMenuItem";
            this.地獄ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.地獄ToolStripMenuItem.Text = "地獄";
            this.地獄ToolStripMenuItem.Click += new System.EventHandler(this.地獄ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // 闖關模式ToolStripMenuItem
            // 
            this.闖關模式ToolStripMenuItem.Name = "闖關模式ToolStripMenuItem";
            this.闖關模式ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.闖關模式ToolStripMenuItem.Text = "闖關模式";
            this.闖關模式ToolStripMenuItem.Click += new System.EventHandler(this.闖關模式ToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.音效開ToolStripMenuItem,
            this.音效關ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // 音效開ToolStripMenuItem
            // 
            this.音效開ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.背景音樂ToolStripMenuItem,
            this.點擊音樂ToolStripMenuItem,
            this.全部音效ToolStripMenuItem});
            this.音效開ToolStripMenuItem.Name = "音效開ToolStripMenuItem";
            this.音效開ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.音效開ToolStripMenuItem.Text = "音效(開)";
            // 
            // 背景音樂ToolStripMenuItem
            // 
            this.背景音樂ToolStripMenuItem.Name = "背景音樂ToolStripMenuItem";
            this.背景音樂ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.背景音樂ToolStripMenuItem.Text = "背景音樂";
            this.背景音樂ToolStripMenuItem.Click += new System.EventHandler(this.背景音樂ToolStripMenuItem_Click);
            // 
            // 點擊音樂ToolStripMenuItem
            // 
            this.點擊音樂ToolStripMenuItem.Name = "點擊音樂ToolStripMenuItem";
            this.點擊音樂ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.點擊音樂ToolStripMenuItem.Text = "點擊音樂";
            this.點擊音樂ToolStripMenuItem.Click += new System.EventHandler(this.點擊音樂ToolStripMenuItem_Click);
            // 
            // 全部音效ToolStripMenuItem
            // 
            this.全部音效ToolStripMenuItem.Name = "全部音效ToolStripMenuItem";
            this.全部音效ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.全部音效ToolStripMenuItem.Text = "全部音效";
            this.全部音效ToolStripMenuItem.Click += new System.EventHandler(this.全部音效ToolStripMenuItem_Click);
            // 
            // 音效關ToolStripMenuItem
            // 
            this.音效關ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.背景音樂ToolStripMenuItem1,
            this.點擊音樂ToolStripMenuItem1,
            this.全部音效ToolStripMenuItem1});
            this.音效關ToolStripMenuItem.Name = "音效關ToolStripMenuItem";
            this.音效關ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.音效關ToolStripMenuItem.Text = "音效(關)";
            // 
            // 背景音樂ToolStripMenuItem1
            // 
            this.背景音樂ToolStripMenuItem1.Name = "背景音樂ToolStripMenuItem1";
            this.背景音樂ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.背景音樂ToolStripMenuItem1.Text = "背景音樂";
            this.背景音樂ToolStripMenuItem1.Click += new System.EventHandler(this.背景音樂ToolStripMenuItem1_Click);
            // 
            // 點擊音樂ToolStripMenuItem1
            // 
            this.點擊音樂ToolStripMenuItem1.Name = "點擊音樂ToolStripMenuItem1";
            this.點擊音樂ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.點擊音樂ToolStripMenuItem1.Text = "點擊音樂";
            this.點擊音樂ToolStripMenuItem1.Click += new System.EventHandler(this.點擊音樂ToolStripMenuItem1_Click);
            // 
            // 全部音效ToolStripMenuItem1
            // 
            this.全部音效ToolStripMenuItem1.Name = "全部音效ToolStripMenuItem1";
            this.全部音效ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.全部音效ToolStripMenuItem1.Text = "全部音效";
            this.全部音效ToolStripMenuItem1.Click += new System.EventHandler(this.全部音效ToolStripMenuItem1_Click);
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.關於ToolStripMenuItem.Text = "關於";
            this.關於ToolStripMenuItem.Click += new System.EventHandler(this.關於ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(70, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(197, 111);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(332, 61);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(466, 88);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(592, 44);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(392, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "時間:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(455, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(230, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "分數:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(292, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "000";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 369);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(36, 35);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(12, 413);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(33, 35);
            this.axWindowsMediaPlayer2.TabIndex = 11;
            this.axWindowsMediaPlayer2.Visible = false;
            // 
            // 排行榜ToolStripMenuItem
            // 
            this.排行榜ToolStripMenuItem.Name = "排行榜ToolStripMenuItem";
            this.排行榜ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.排行榜ToolStripMenuItem.Text = "排行榜";
            this.排行榜ToolStripMenuItem.Click += new System.EventHandler(this.排行榜ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 460);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem 遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暫停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 重新挑戰ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 簡單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中等ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 困難ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地獄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ToolStripMenuItem 闖關模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem 音效開ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景音樂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 點擊音樂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部音效ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 音效關ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景音樂ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 點擊音樂ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 全部音效ToolStripMenuItem1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.ToolStripMenuItem 排行榜ToolStripMenuItem;
    }
}

