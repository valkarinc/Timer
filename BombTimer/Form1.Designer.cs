namespace BombTimer
{
    partial class Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.timerLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.bombTimer = new System.Windows.Forms.Timer(this.components);
            this.timeInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.timerLabel.Location = new System.Drawing.Point(46, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(98, 37);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "00:00";
            this.timerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.startButton.Location = new System.Drawing.Point(11, 49);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(166, 44);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Timer";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // bombTimer
            // 
            this.bombTimer.Interval = 1000;
            this.bombTimer.Tick += new System.EventHandler(this.bombTimer_Tick);
            // 
            // timeInputBox
            // 
            this.timeInputBox.Location = new System.Drawing.Point(11, 112);
            this.timeInputBox.Multiline = true;
            this.timeInputBox.Name = "timeInputBox";
            this.timeInputBox.Size = new System.Drawing.Size(166, 50);
            this.timeInputBox.TabIndex = 2;
            this.timeInputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desired Countdown (in sec):";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeInputBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Timer";
            this.Text = "Timer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer bombTimer;
        private System.Windows.Forms.TextBox timeInputBox;
        private System.Windows.Forms.Label label1;
    }
}

