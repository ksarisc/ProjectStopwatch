namespace ProjectStopwatch
{
    partial class ProjectTimer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.TimerBox = new System.Windows.Forms.TextBox();
            this.TimerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(14, 11);
            this.ProjectLabel.Margin = new System.Windows.Forms.Padding(5);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(71, 13);
            this.ProjectLabel.TabIndex = 0;
            this.ProjectLabel.Text = "Project Name";
            // 
            // TimerBox
            // 
            this.TimerBox.Location = new System.Drawing.Point(167, 8);
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(100, 20);
            this.TimerBox.TabIndex = 1;
            // 
            // TimerButton
            // 
            this.TimerButton.Location = new System.Drawing.Point(343, 6);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(75, 23);
            this.TimerButton.TabIndex = 2;
            this.TimerButton.Text = "Start";
            this.TimerButton.UseVisualStyleBackColor = true;
            this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // ProjectTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimerButton);
            this.Controls.Add(this.TimerBox);
            this.Controls.Add(this.ProjectLabel);
            this.Name = "ProjectTimer";
            this.Size = new System.Drawing.Size(730, 177);
            this.Load += new System.EventHandler(this.ProjectTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.TextBox TimerBox;
        private System.Windows.Forms.Button TimerButton;
    }
}
