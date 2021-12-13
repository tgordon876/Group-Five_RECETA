
namespace RecetaPlus.Forms
{
    partial class FormDinner
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
            this.txtBoxDinner = new System.Windows.Forms.RichTextBox();
            this.btnPreviousDinner = new System.Windows.Forms.Button();
            this.btnNextDinner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxDinner
            // 
            this.txtBoxDinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDinner.BackColor = System.Drawing.Color.LightYellow;
            this.txtBoxDinner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDinner.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDinner.Location = new System.Drawing.Point(17, 12);
            this.txtBoxDinner.Name = "txtBoxDinner";
            this.txtBoxDinner.Size = new System.Drawing.Size(824, 385);
            this.txtBoxDinner.TabIndex = 0;
            this.txtBoxDinner.Text = "";
            // 
            // btnPreviousDinner
            // 
            this.btnPreviousDinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreviousDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousDinner.Location = new System.Drawing.Point(15, 404);
            this.btnPreviousDinner.Name = "btnPreviousDinner";
            this.btnPreviousDinner.Size = new System.Drawing.Size(88, 37);
            this.btnPreviousDinner.TabIndex = 1;
            this.btnPreviousDinner.Text = "Previous";
            this.btnPreviousDinner.UseVisualStyleBackColor = true;
            this.btnPreviousDinner.Click += new System.EventHandler(this.btnPreviousDinner_Click);
            // 
            // btnNextDinner
            // 
            this.btnNextDinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextDinner.Location = new System.Drawing.Point(742, 404);
            this.btnNextDinner.Name = "btnNextDinner";
            this.btnNextDinner.Size = new System.Drawing.Size(75, 37);
            this.btnNextDinner.TabIndex = 2;
            this.btnNextDinner.Text = "Next";
            this.btnNextDinner.UseVisualStyleBackColor = true;
            this.btnNextDinner.Click += new System.EventHandler(this.btnNextDinner_Click);
            // 
            // FormDinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(841, 455);
            this.Controls.Add(this.btnNextDinner);
            this.Controls.Add(this.btnPreviousDinner);
            this.Controls.Add(this.txtBoxDinner);
            this.Name = "FormDinner";
            this.Text = "FormDinner";
            this.Load += new System.EventHandler(this.FormDinner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxDinner;
        private System.Windows.Forms.Button btnPreviousDinner;
        private System.Windows.Forms.Button btnNextDinner;
    }
}