namespace DrawStar
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.outsideRadiusTextBox = new System.Windows.Forms.TextBox();
            this.insideRadiusTextBox = new System.Windows.Forms.TextBox();
            this.pointNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buildStarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // outsideRadiusTextBox
            // 
            this.outsideRadiusTextBox.Location = new System.Drawing.Point(696, 15);
            this.outsideRadiusTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outsideRadiusTextBox.Name = "outsideRadiusTextBox";
            this.outsideRadiusTextBox.Size = new System.Drawing.Size(132, 22);
            this.outsideRadiusTextBox.TabIndex = 0;
            // 
            // insideRadiusTextBox
            // 
            this.insideRadiusTextBox.Location = new System.Drawing.Point(696, 60);
            this.insideRadiusTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insideRadiusTextBox.Name = "insideRadiusTextBox";
            this.insideRadiusTextBox.Size = new System.Drawing.Size(132, 22);
            this.insideRadiusTextBox.TabIndex = 1;
            // 
            // pointNumberTextBox
            // 
            this.pointNumberTextBox.Location = new System.Drawing.Point(696, 105);
            this.pointNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pointNumberTextBox.Name = "pointNumberTextBox";
            this.pointNumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.pointNumberTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Outside Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inside Radius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "#  Of Points";
            // 
            // buildStarButton
            // 
            this.buildStarButton.Location = new System.Drawing.Point(696, 165);
            this.buildStarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buildStarButton.Name = "buildStarButton";
            this.buildStarButton.Size = new System.Drawing.Size(133, 49);
            this.buildStarButton.TabIndex = 6;
            this.buildStarButton.Text = "Build Star";
            this.buildStarButton.UseVisualStyleBackColor = true;
            this.buildStarButton.Click += new System.EventHandler(this.buildStarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 481);
            this.Controls.Add(this.buildStarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pointNumberTextBox);
            this.Controls.Add(this.insideRadiusTextBox);
            this.Controls.Add(this.outsideRadiusTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "DrawStar";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TextBox outsideRadiusTextBox;
        private System.Windows.Forms.TextBox insideRadiusTextBox;
        private System.Windows.Forms.TextBox pointNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buildStarButton;
    }
}

