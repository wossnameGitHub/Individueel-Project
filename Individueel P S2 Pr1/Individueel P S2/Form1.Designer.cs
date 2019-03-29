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
            this.buttonGetDown = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
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
            this.buttonLeft.Location = new System.Drawing.Point(809, 315);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(100, 39);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "naar links";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Visible = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonJump
            // 
            this.buttonJump.Location = new System.Drawing.Point(915, 315);
            this.buttonJump.Name = "buttonJump";
            this.buttonJump.Size = new System.Drawing.Size(100, 39);
            this.buttonJump.TabIndex = 3;
            this.buttonJump.Text = "springen";
            this.buttonJump.UseVisualStyleBackColor = true;
            this.buttonJump.Visible = false;
            this.buttonJump.Click += new System.EventHandler(this.buttonJump_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(1021, 315);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(100, 39);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.Text = "naar rechts";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Visible = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonGetDown
            // 
            this.buttonGetDown.Location = new System.Drawing.Point(1179, 315);
            this.buttonGetDown.Name = "buttonGetDown";
            this.buttonGetDown.Size = new System.Drawing.Size(100, 39);
            this.buttonGetDown.TabIndex = 5;
            this.buttonGetDown.Text = "get down";
            this.buttonGetDown.UseVisualStyleBackColor = true;
            this.buttonGetDown.Visible = false;
            this.buttonGetDown.Click += new System.EventHandler(this.buttonGetDown_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 378);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonGetDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonJump);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonJump;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonGetDown;
        private System.Windows.Forms.Button buttonStart;
    }
}

