namespace VlcControlApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            Start = new Button();
            Connect = new Button();
            Stop = new Button();
            Seek = new Button();
            SeekTime = new TextBox();
            Pause = new Button();
            label1 = new Label();
            MovieFile = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // Start
            // 
            Start.Location = new Point(472, 172);
            Start.Name = "Start";
            Start.Size = new Size(140, 29);
            Start.TabIndex = 0;
            Start.Text = "動画開始";
            Start.UseVisualStyleBackColor = true;
            Start.Click += PlayVLCMovie;
            // 
            // Connect
            // 
            Connect.Location = new Point(472, 120);
            Connect.Name = "Connect";
            Connect.Size = new Size(140, 29);
            Connect.TabIndex = 1;
            Connect.Text = "Tcp接続、再生";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += ConnectClick;
            // 
            // Stop
            // 
            Stop.Location = new Point(472, 293);
            Stop.Name = "Stop";
            Stop.Size = new Size(140, 29);
            Stop.TabIndex = 2;
            Stop.Text = "動画終了";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += StopClick;
            // 
            // Seek
            // 
            Seek.Location = new Point(472, 235);
            Seek.Name = "Seek";
            Seek.Size = new Size(140, 29);
            Seek.TabIndex = 3;
            Seek.Text = "指定時間から開始";
            Seek.UseVisualStyleBackColor = true;
            Seek.Click += SeekClick;
            // 
            // SeekTime
            // 
            SeekTime.Location = new Point(268, 234);
            SeekTime.Name = "SeekTime";
            SeekTime.Size = new Size(125, 27);
            SeekTime.TabIndex = 4;
            // 
            // Pause
            // 
            Pause.Location = new Point(472, 351);
            Pause.Name = "Pause";
            Pause.Size = new Size(140, 29);
            Pause.TabIndex = 5;
            Pause.Text = "一時停止・再生";
            Pause.UseVisualStyleBackColor = true;
            Pause.Click += PauseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(417, 238);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 6;
            label1.Text = "秒";
            // 
            // MovieFile
            // 
            MovieFile.Location = new Point(247, 122);
            MovieFile.Name = "MovieFile";
            MovieFile.Size = new Size(194, 27);
            MovieFile.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 129);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 8;
            label2.Text = "音源ファイルパス";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(MovieFile);
            Controls.Add(label1);
            Controls.Add(Pause);
            Controls.Add(SeekTime);
            Controls.Add(Seek);
            Controls.Add(Stop);
            Controls.Add(Connect);
            Controls.Add(Start);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start;
        private Button Connect;
        private Button Stop;
        private Button Seek;
        private TextBox SeekTime;
        private Button Pause;
        private Label label1;
        private TextBox MovieFile;
        private Label label2;
    }
}
