namespace DesktopClock
{
    partial class Clock
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
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelColon = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHour
            // 
            this.labelHour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.Location = new System.Drawing.Point(12, 9);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(151, 108);
            this.labelHour.TabIndex = 0;
            this.labelHour.Text = "12";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinute.Location = new System.Drawing.Point(181, 9);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(151, 108);
            this.labelMinute.TabIndex = 1;
            this.labelMinute.Text = "12";
            // 
            // labelColon
            // 
            this.labelColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon.Location = new System.Drawing.Point(140, 0);
            this.labelColon.Name = "labelColon";
            this.labelColon.Size = new System.Drawing.Size(58, 108);
            this.labelColon.TabIndex = 2;
            this.labelColon.Text = ":";
            // 
            // labelSecond
            // 
            this.labelSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecond.Location = new System.Drawing.Point(315, 53);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(78, 55);
            this.labelSecond.TabIndex = 3;
            this.labelSecond.Text = "12";
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 125);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelColon);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Name = "Clock";
            this.Text = "Desktop Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelColon;
        private System.Windows.Forms.Label labelSecond;
    }
}

