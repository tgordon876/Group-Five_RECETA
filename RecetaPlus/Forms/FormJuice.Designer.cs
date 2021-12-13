
namespace RecetaPlus.Forms
{
    partial class FormJuice
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
            this.txtBoxJuice = new System.Windows.Forms.RichTextBox();
            this.btnPreviousJuice = new System.Windows.Forms.Button();
            this.btnNextJuice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxJuice
            // 
            this.txtBoxJuice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxJuice.BackColor = System.Drawing.Color.LightYellow;
            this.txtBoxJuice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxJuice.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxJuice.Location = new System.Drawing.Point(12, 12);
            this.txtBoxJuice.Name = "txtBoxJuice";
            this.txtBoxJuice.ReadOnly = true;
            this.txtBoxJuice.Size = new System.Drawing.Size(826, 391);
            this.txtBoxJuice.TabIndex = 0;
            this.txtBoxJuice.Text = "";
            // 
            // btnPreviousJuice
            // 
            this.btnPreviousJuice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreviousJuice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousJuice.Location = new System.Drawing.Point(12, 409);
            this.btnPreviousJuice.Name = "btnPreviousJuice";
            this.btnPreviousJuice.Size = new System.Drawing.Size(89, 36);
            this.btnPreviousJuice.TabIndex = 1;
            this.btnPreviousJuice.Text = "Previous";
            this.btnPreviousJuice.UseVisualStyleBackColor = true;
            this.btnPreviousJuice.Click += new System.EventHandler(this.btnPreviousJuice_Click);
            // 
            // btnNextJuice
            // 
            this.btnNextJuice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextJuice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextJuice.Location = new System.Drawing.Point(747, 409);
            this.btnNextJuice.Name = "btnNextJuice";
            this.btnNextJuice.Size = new System.Drawing.Size(81, 36);
            this.btnNextJuice.TabIndex = 2;
            this.btnNextJuice.Text = "Next";
            this.btnNextJuice.UseVisualStyleBackColor = true;
            this.btnNextJuice.Click += new System.EventHandler(this.btnNextJuice_Click);
            // 
            // FormJuice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(840, 459);
            this.Controls.Add(this.btnNextJuice);
            this.Controls.Add(this.btnPreviousJuice);
            this.Controls.Add(this.txtBoxJuice);
            this.Name = "FormJuice";
            this.Text = "FormJuice";
            this.Load += new System.EventHandler(this.FormJuice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxJuice;
        private System.Windows.Forms.Button btnPreviousJuice;
        private System.Windows.Forms.Button btnNextJuice;
    }
}