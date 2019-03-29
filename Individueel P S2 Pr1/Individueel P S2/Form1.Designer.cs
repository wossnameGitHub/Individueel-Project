namespace Individueel_P_S2
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonJump = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonTimePasses = new System.Windows.Forms.Button();
            this.buttonRealTime = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(771, 304);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Location = new System.Drawing.Point(809, 15);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(512, 294);
            this.listBox2.TabIndex = 1;
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.LightGray;
            this.buttonLeft.Location = new System.Drawing.Point(809, 315);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(100, 39);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "naar links";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Visible = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonJump
            // 
            this.buttonJump.BackColor = System.Drawing.Color.LightGray;
            this.buttonJump.Location = new System.Drawing.Point(915, 315);
            this.buttonJump.Name = "buttonJump";
            this.buttonJump.Size = new System.Drawing.Size(100, 39);
            this.buttonJump.TabIndex = 3;
            this.buttonJump.Text = "springen";
            this.buttonJump.UseVisualStyleBackColor = false;
            this.buttonJump.Visible = false;
            this.buttonJump.Click += new System.EventHandler(this.buttonJump_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.LightGray;
            this.buttonRight.Location = new System.Drawing.Point(1021, 315);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(100, 39);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.Text = "naar rechts";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Visible = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 327);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(139, 39);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonTimePasses
            // 
            this.buttonTimePasses.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTimePasses.Location = new System.Drawing.Point(541, 327);
            this.buttonTimePasses.Name = "buttonTimePasses";
            this.buttonTimePasses.Size = new System.Drawing.Size(139, 39);
            this.buttonTimePasses.TabIndex = 7;
            this.buttonTimePasses.Text = "Time Passes";
            this.buttonTimePasses.UseVisualStyleBackColor = false;
            this.buttonTimePasses.Visible = false;
            this.buttonTimePasses.Click += new System.EventHandler(this.buttonTimePasses_Click);
            // 
            // buttonRealTime
            // 
            this.buttonRealTime.BackColor = System.Drawing.Color.Tomato;
            this.buttonRealTime.Location = new System.Drawing.Point(374, 327);
            this.buttonRealTime.Name = "buttonRealTime";
            this.buttonRealTime.Size = new System.Drawing.Size(139, 39);
            this.buttonRealTime.TabIndex = 8;
            this.buttonRealTime.Text = "Real-time: OFF";
            this.buttonRealTime.UseVisualStyleBackColor = false;
            this.buttonRealTime.Visible = false;
            this.buttonRealTime.Click += new System.EventHandler(this.buttonRealTime_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(700, 337);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(56, 17);
            this.labelTimer.TabIndex = 9;
            this.labelTimer.Text = "Time: X";
            this.labelTimer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 378);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonRealTime);
            this.Controls.Add(this.buttonTimePasses);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonJump);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonJump;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonTimePasses;
        private System.Windows.Forms.Button buttonRealTime;
        private System.Windows.Forms.Label labelTimer;
    }
}

