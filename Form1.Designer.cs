namespace Metronome
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            Beat = new PictureBox();
            PlayPause = new PictureBox();
            Bpm = new NumericUpDown();
            label1 = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            BeatChanger = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Beat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayPause).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bpm).BeginInit();
            SuspendLayout();
            // 
            // Beat
            // 
            Beat.Image = Properties.Resources.BlackBeat;
            Beat.Location = new Point(142, 21);
            Beat.Name = "Beat";
            Beat.Size = new Size(150, 150);
            Beat.SizeMode = PictureBoxSizeMode.AutoSize;
            Beat.TabIndex = 0;
            Beat.TabStop = false;
            // 
            // PlayPause
            // 
            PlayPause.Image = Properties.Resources.Play;
            PlayPause.Location = new Point(142, 353);
            PlayPause.Name = "PlayPause";
            PlayPause.Size = new Size(150, 150);
            PlayPause.SizeMode = PictureBoxSizeMode.Zoom;
            PlayPause.TabIndex = 1;
            PlayPause.TabStop = false;
            PlayPause.Click += PlayPause_Click;
            // 
            // Bpm
            // 
            Bpm.BackColor = Color.FromArgb(94, 94, 94);
            Bpm.BorderStyle = BorderStyle.None;
            Bpm.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bpm.ForeColor = SystemColors.InactiveBorder;
            Bpm.Location = new Point(142, 236);
            Bpm.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            Bpm.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            Bpm.Name = "Bpm";
            Bpm.Size = new Size(150, 52);
            Bpm.TabIndex = 1;
            Bpm.TextAlign = HorizontalAlignment.Center;
            Bpm.Value = new decimal(new int[] { 100, 0, 0, 0 });
            Bpm.ValueChanged += Bpm_ValueChanged;
            Bpm.KeyDown += Window_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(298, 238);
            label1.Name = "label1";
            label1.Size = new Size(91, 48);
            label1.TabIndex = 3;
            label1.Text = "BPM";
            // 
            // Timer
            // 
            Timer.Interval = 600;
            Timer.Tick += Timer_Tick;
            // 
            // BeatChanger
            // 
            BeatChanger.Tick += BeatChanger_Tick;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(94, 94, 94);
            ClientSize = new Size(415, 553);
            Controls.Add(label1);
            Controls.Add(Bpm);
            Controls.Add(PlayPause);
            Controls.Add(Beat);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Window";
            Text = "Metronome";
            KeyDown += Window_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Beat).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayPause).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bpm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Beat;
        private PictureBox PlayPause;
        private NumericUpDown Bpm;
        private Label label1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer BeatChanger;
    }
}
