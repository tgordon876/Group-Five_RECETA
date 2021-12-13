
namespace RecetaPlus.Forms
{
    partial class FormBreakFast
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
            this.txtBoxBreakfast = new System.Windows.Forms.RichTextBox();
            this.btnNextBreakfast = new System.Windows.Forms.Button();
            this.btnPreviousBreakfast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxBreakfast
            // 
            this.txtBoxBreakfast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxBreakfast.BackColor = System.Drawing.Color.LightYellow;
            this.txtBoxBreakfast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxBreakfast.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBreakfast.Location = new System.Drawing.Point(22, 12);
            this.txtBoxBreakfast.Name = "txtBoxBreakfast";
            this.txtBoxBreakfast.ReadOnly = true;
            this.txtBoxBreakfast.Size = new System.Drawing.Size(822, 380);
            this.txtBoxBreakfast.TabIndex = 0;
            this.txtBoxBreakfast.Text = "";
            // 
            // btnNextBreakfast
            // 
            this.btnNextBreakfast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextBreakfast.Location = new System.Drawing.Point(745, 405);
            this.btnNextBreakfast.Name = "btnNextBreakfast";
            this.btnNextBreakfast.Size = new System.Drawing.Size(75, 41);
            this.btnNextBreakfast.TabIndex = 1;
            this.btnNextBreakfast.Text = "Next";
            this.btnNextBreakfast.UseVisualStyleBackColor = true;
            this.btnNextBreakfast.Click += new System.EventHandler(this.btnNextBreakfast_Click);
            // 
            // btnPreviousBreakfast
            // 
            this.btnPreviousBreakfast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreviousBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousBreakfast.Location = new System.Drawing.Point(22, 405);
            this.btnPreviousBreakfast.Name = "btnPreviousBreakfast";
            this.btnPreviousBreakfast.Size = new System.Drawing.Size(87, 41);
            this.btnPreviousBreakfast.TabIndex = 2;
            this.btnPreviousBreakfast.Text = "Previous";
            this.btnPreviousBreakfast.UseVisualStyleBackColor = true;
            this.btnPreviousBreakfast.Click += new System.EventHandler(this.btnPreviousBreakfast_Click);
            // 
            // FormBreakFast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(843, 458);
            this.Controls.Add(this.btnPreviousBreakfast);
            this.Controls.Add(this.btnNextBreakfast);
            this.Controls.Add(this.txtBoxBreakfast);
            this.Name = "FormBreakFast";
            this.Text = "FormBreakFast";
            this.Load += new System.EventHandler(this.FormBreakFast_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxBreakfast;
        private System.Windows.Forms.Button btnNextBreakfast;
        private System.Windows.Forms.Button btnPreviousBreakfast;
    }
}