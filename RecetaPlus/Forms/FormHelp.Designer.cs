
namespace RecetaPlus.Forms
{
    partial class FormHelp
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
            this.lblHelpTitle = new System.Windows.Forms.Label();
            this.lblhelpNumber = new System.Windows.Forms.Label();
            this.lblHelpSupport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelpTitle
            // 
            this.lblHelpTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelpTitle.AutoSize = true;
            this.lblHelpTitle.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpTitle.Location = new System.Drawing.Point(229, 51);
            this.lblHelpTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelpTitle.Name = "lblHelpTitle";
            this.lblHelpTitle.Size = new System.Drawing.Size(233, 38);
            this.lblHelpTitle.TabIndex = 0;
            this.lblHelpTitle.Text = "Help Support";
            this.lblHelpTitle.Click += new System.EventHandler(this.lblHelpTitle_Click);
            // 
            // lblhelpNumber
            // 
            this.lblhelpNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblhelpNumber.AutoSize = true;
            this.lblhelpNumber.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhelpNumber.Location = new System.Drawing.Point(187, 147);
            this.lblhelpNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhelpNumber.Name = "lblhelpNumber";
            this.lblhelpNumber.Size = new System.Drawing.Size(323, 47);
            this.lblhelpNumber.TabIndex = 1;
            this.lblhelpNumber.Text = "1-403-432-1234";
            this.lblhelpNumber.Click += new System.EventHandler(this.lblhelpNumber_Click);
            // 
            // lblHelpSupport
            // 
            this.lblHelpSupport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelpSupport.AutoSize = true;
            this.lblHelpSupport.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpSupport.Location = new System.Drawing.Point(210, 207);
            this.lblHelpSupport.Name = "lblHelpSupport";
            this.lblHelpSupport.Size = new System.Drawing.Size(291, 35);
            this.lblHelpSupport.TabIndex = 2;
            this.lblHelpSupport.Text = "We are here to help";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(662, 398);
            this.Controls.Add(this.lblHelpSupport);
            this.Controls.Add(this.lblhelpNumber);
            this.Controls.Add(this.lblHelpTitle);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHelp";
            this.Text = "FormHelp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelpTitle;
        private System.Windows.Forms.Label lblhelpNumber;
        private System.Windows.Forms.Label lblHelpSupport;
    }
}