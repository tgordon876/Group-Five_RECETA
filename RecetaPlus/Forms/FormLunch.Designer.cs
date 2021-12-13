
namespace RecetaPlus.Forms
{
    partial class FormLunch
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
            this.txtBoxLunch = new System.Windows.Forms.RichTextBox();
            this.btnPreviousLunch = new System.Windows.Forms.Button();
            this.btnNextLunch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxLunch
            // 
            this.txtBoxLunch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxLunch.BackColor = System.Drawing.Color.LightYellow;
            this.txtBoxLunch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxLunch.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLunch.Location = new System.Drawing.Point(11, 13);
            this.txtBoxLunch.Name = "txtBoxLunch";
            this.txtBoxLunch.ReadOnly = true;
            this.txtBoxLunch.Size = new System.Drawing.Size(828, 384);
            this.txtBoxLunch.TabIndex = 0;
            this.txtBoxLunch.Text = "";
            // 
            // btnPreviousLunch
            // 
            this.btnPreviousLunch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreviousLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousLunch.Location = new System.Drawing.Point(11, 405);
            this.btnPreviousLunch.Name = "btnPreviousLunch";
            this.btnPreviousLunch.Size = new System.Drawing.Size(87, 40);
            this.btnPreviousLunch.TabIndex = 1;
            this.btnPreviousLunch.Text = "Previous";
            this.btnPreviousLunch.UseVisualStyleBackColor = true;
            this.btnPreviousLunch.Click += new System.EventHandler(this.btnPreviousLunch_Click);
            // 
            // btnNextLunch
            // 
            this.btnNextLunch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextLunch.Location = new System.Drawing.Point(739, 405);
            this.btnNextLunch.Name = "btnNextLunch";
            this.btnNextLunch.Size = new System.Drawing.Size(75, 40);
            this.btnNextLunch.TabIndex = 2;
            this.btnNextLunch.Text = "Next";
            this.btnNextLunch.UseVisualStyleBackColor = true;
            this.btnNextLunch.Click += new System.EventHandler(this.btnNextLunch_Click);
            // 
            // FormLunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.btnNextLunch);
            this.Controls.Add(this.btnPreviousLunch);
            this.Controls.Add(this.txtBoxLunch);
            this.Name = "FormLunch";
            this.Text = "FormLunch";
            this.Load += new System.EventHandler(this.FormLunch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxLunch;
        private System.Windows.Forms.Button btnPreviousLunch;
        private System.Windows.Forms.Button btnNextLunch;
    }
}