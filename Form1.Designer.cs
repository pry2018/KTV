namespace KTV
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.MediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.play_button = new System.Windows.Forms.Button();
            this.cut_button = new System.Windows.Forms.Button();
            this.relpay_button = new System.Windows.Forms.Button();
            this.select_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.ListBox();
            this.chooseBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderlist = new System.Windows.Forms.Label();
            this.deletebutton = new System.Windows.Forms.Button();
            this.topbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "正在播放";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MediaPlayer1
            // 
            this.MediaPlayer1.Enabled = true;
            this.MediaPlayer1.Location = new System.Drawing.Point(169, 70);
            this.MediaPlayer1.Name = "MediaPlayer1";
            this.MediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer1.OcxState")));
            this.MediaPlayer1.Size = new System.Drawing.Size(329, 96);
            this.MediaPlayer1.TabIndex = 3;
            this.MediaPlayer1.Enter += new System.EventHandler(this.MediaPlayer1_Enter);
            this.MediaPlayer1.Enter += new System.EventHandler(this.MediaPlayer1_StatusChange);
            // 
            // play_button
            // 
            this.play_button.Location = new System.Drawing.Point(64, 141);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(77, 34);
            this.play_button.TabIndex = 4;
            this.play_button.Text = "播放";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.playButton_Click);
            // 
            // cut_button
            // 
            this.cut_button.Location = new System.Drawing.Point(64, 193);
            this.cut_button.Name = "cut_button";
            this.cut_button.Size = new System.Drawing.Size(75, 30);
            this.cut_button.TabIndex = 5;
            this.cut_button.Text = "切歌";
            this.cut_button.UseVisualStyleBackColor = true;
            this.cut_button.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // relpay_button
            // 
            this.relpay_button.Location = new System.Drawing.Point(64, 238);
            this.relpay_button.Name = "relpay_button";
            this.relpay_button.Size = new System.Drawing.Size(75, 33);
            this.relpay_button.TabIndex = 6;
            this.relpay_button.Text = "重唱";
            this.relpay_button.UseVisualStyleBackColor = true;
            this.relpay_button.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(44, 95);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(97, 28);
            this.select_button.TabIndex = 7;
            this.select_button.Text = "选择歌曲";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 28);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchBox
            // 
            this.searchBox.FormattingEnabled = true;
            this.searchBox.ItemHeight = 18;
            this.searchBox.Location = new System.Drawing.Point(183, 256);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(120, 94);
            this.searchBox.TabIndex = 9;
            this.searchBox.SelectedIndexChanged += new System.EventHandler(this.searchBox_SelectedIndexChanged);
            // 
            // chooseBox
            // 
            this.chooseBox.FormattingEnabled = true;
            this.chooseBox.ItemHeight = 18;
            this.chooseBox.Location = new System.Drawing.Point(451, 256);
            this.chooseBox.Name = "chooseBox";
            this.chooseBox.Size = new System.Drawing.Size(120, 94);
            this.chooseBox.TabIndex = 10;
            this.chooseBox.SelectedIndexChanged += new System.EventHandler(this.chooseBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "搜索出的歌曲";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // orderlist
            // 
            this.orderlist.AutoSize = true;
            this.orderlist.Location = new System.Drawing.Point(474, 367);
            this.orderlist.Name = "orderlist";
            this.orderlist.Size = new System.Drawing.Size(80, 18);
            this.orderlist.TabIndex = 12;
            this.orderlist.Text = "已点歌曲";
            this.orderlist.Click += new System.EventHandler(this.label3_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(603, 256);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(122, 29);
            this.deletebutton.TabIndex = 13;
            this.deletebutton.Text = "删除所选歌曲";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // topbutton
            // 
            this.topbutton.Location = new System.Drawing.Point(602, 326);
            this.topbutton.Name = "topbutton";
            this.topbutton.Size = new System.Drawing.Size(123, 24);
            this.topbutton.TabIndex = 14;
            this.topbutton.Text = "顶歌";
            this.topbutton.UseVisualStyleBackColor = true;
            this.topbutton.Click += new System.EventHandler(this.topButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.topbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.orderlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.relpay_button);
            this.Controls.Add(this.cut_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.MediaPlayer1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Monitor_playState()
        {

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer1;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button cut_button;
        private System.Windows.Forms.Button relpay_button;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox searchBox;
        private System.Windows.Forms.ListBox chooseBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label orderlist;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button topbutton;
        private System.Windows.Forms.Timer timer1;
    }
}

