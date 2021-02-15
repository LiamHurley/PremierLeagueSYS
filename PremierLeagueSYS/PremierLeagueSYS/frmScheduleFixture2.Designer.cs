namespace PremierLeagueSYS
{
    partial class frmScheduleFixture2
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
            this.lblFixDate = new System.Windows.Forms.Label();
            this.txtFixDate = new System.Windows.Forms.TextBox();
            this.lblFixTime = new System.Windows.Forms.Label();
            this.txtFixTime = new System.Windows.Forms.TextBox();
            this.btnScheduleFix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFixDate
            // 
            this.lblFixDate.AutoSize = true;
            this.lblFixDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixDate.Location = new System.Drawing.Point(86, 72);
            this.lblFixDate.Name = "lblFixDate";
            this.lblFixDate.Size = new System.Drawing.Size(116, 24);
            this.lblFixDate.TabIndex = 0;
            this.lblFixDate.Text = "Fixture Date:";
            // 
            // txtFixDate
            // 
            this.txtFixDate.Location = new System.Drawing.Point(227, 76);
            this.txtFixDate.Name = "txtFixDate";
            this.txtFixDate.Size = new System.Drawing.Size(156, 20);
            this.txtFixDate.TabIndex = 1;
            this.txtFixDate.Text = "YYYY-MM-DD";
            // 
            // lblFixTime
            // 
            this.lblFixTime.AutoSize = true;
            this.lblFixTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixTime.Location = new System.Drawing.Point(86, 146);
            this.lblFixTime.Name = "lblFixTime";
            this.lblFixTime.Size = new System.Drawing.Size(121, 24);
            this.lblFixTime.TabIndex = 2;
            this.lblFixTime.Text = "Fixture Time:";
            // 
            // txtFixTime
            // 
            this.txtFixTime.Location = new System.Drawing.Point(227, 150);
            this.txtFixTime.Name = "txtFixTime";
            this.txtFixTime.Size = new System.Drawing.Size(156, 20);
            this.txtFixTime.TabIndex = 3;
            this.txtFixTime.Text = "HH:MM:SS";
            // 
            // btnScheduleFix
            // 
            this.btnScheduleFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleFix.ForeColor = System.Drawing.Color.Red;
            this.btnScheduleFix.Location = new System.Drawing.Point(393, 240);
            this.btnScheduleFix.Name = "btnScheduleFix";
            this.btnScheduleFix.Size = new System.Drawing.Size(198, 86);
            this.btnScheduleFix.TabIndex = 4;
            this.btnScheduleFix.Text = "Schedule Fixture";
            this.btnScheduleFix.UseVisualStyleBackColor = true;
            // 
            // frmScheduleFixture2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnScheduleFix);
            this.Controls.Add(this.txtFixTime);
            this.Controls.Add(this.lblFixTime);
            this.Controls.Add(this.txtFixDate);
            this.Controls.Add(this.lblFixDate);
            this.Name = "frmScheduleFixture2";
            this.Text = "PremierLeagueSYS - Fixture Scheduling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFixDate;
        private System.Windows.Forms.TextBox txtFixDate;
        private System.Windows.Forms.Label lblFixTime;
        private System.Windows.Forms.TextBox txtFixTime;
        private System.Windows.Forms.Button btnScheduleFix;
    }
}