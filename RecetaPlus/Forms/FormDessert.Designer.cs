
namespace RecetaPlus.Forms
{
    partial class FormDessert
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
            this.txtBoxDessert = new System.Windows.Forms.RichTextBox();
            this.btbPreviousDessert = new System.Windows.Forms.Button();
            this.btnNextDessert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxDessert
            // 
            this.txtBoxDessert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDessert.BackColor = System.Drawing.Color.LightYellow;
            this.txtBoxDessert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDessert.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDessert.Location = new System.Drawing.Point(20, 12);
            this.txtBoxDessert.Name = "txtBoxDessert";
            this.txtBoxDessert.ReadOnly = true;
            this.txtBoxDessert.Size = new System.Drawing.Size(821, 392);
            this.txtBoxDessert.TabIndex = 0;
            this.txtBoxDessert.Text = "";
            // 
            // btbPreviousDessert
            // 
            this.btbPreviousDessert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btbPreviousDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbPreviousDessert.Location = new System.Drawing.Point(20, 409);
            this.btbPreviousDessert.Name = "btbPreviousDessert";
            this.btbPreviousDessert.Size = new System.Drawing.Size(88, 37);
            this.btbPreviousDessert.TabIndex = 1;
            this.btbPreviousDessert.Text = "Previous";
            this.btbPreviousDessert.UseVisualStyleBackColor = true;
            this.btbPreviousDessert.Click += new System.EventHandler(this.btbPreviousDessert_Click);
            // 
            // btnNextDessert
            // 
            this.btnNextDessert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextDessert.Location = new System.Drawing.Point(744, 410);
            this.btnNextDessert.Name = "btnNextDessert";
            this.btnNextDessert.Size = new System.Drawing.Size(75, 35);
            this.btnNextDessert.TabIndex = 2;
            this.btnNextDessert.Text = "Next";
            this.btnNextDessert.UseVisualStyleBackColor = true;
            this.btnNextDessert.Click += new System.EventHandler(this.btnNextDessert_Click);
            // 
            // FormDessert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(841, 457);
            this.Controls.Add(this.btnNextDessert);
            this.Controls.Add(this.btbPreviousDessert);
            this.Controls.Add(this.txtBoxDessert);
            this.Name = "FormDessert";
            this.Text = "FormDessert";
            this.Load += new System.EventHandler(this.FormDessert_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxDessert;
        private System.Windows.Forms.Button btbPreviousDessert;
        private System.Windows.Forms.Button btnNextDessert;
    }
}