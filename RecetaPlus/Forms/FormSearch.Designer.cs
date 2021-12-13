
namespace RecetaPlus.Forms
{
    partial class FormSearch
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
            this.txtBoxSearch = new System.Windows.Forms.RichTextBox();
            this.btnPreviousSearch = new System.Windows.Forms.Button();
            this.btnNextSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSearch.BackColor = System.Drawing.Color.LightYellow;
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSearch.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(14, 12);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(828, 391);
            this.txtBoxSearch.TabIndex = 0;
            this.txtBoxSearch.Text = "";
            // 
            // btnPreviousSearch
            // 
            this.btnPreviousSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreviousSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousSearch.Location = new System.Drawing.Point(11, 411);
            this.btnPreviousSearch.Name = "btnPreviousSearch";
            this.btnPreviousSearch.Size = new System.Drawing.Size(86, 45);
            this.btnPreviousSearch.TabIndex = 1;
            this.btnPreviousSearch.Text = "Previous";
            this.btnPreviousSearch.UseVisualStyleBackColor = true;
            this.btnPreviousSearch.Click += new System.EventHandler(this.btnPreviousSearch_Click);
            // 
            // btnNextSearch
            // 
            this.btnNextSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextSearch.Location = new System.Drawing.Point(742, 411);
            this.btnNextSearch.Name = "btnNextSearch";
            this.btnNextSearch.Size = new System.Drawing.Size(75, 45);
            this.btnNextSearch.TabIndex = 2;
            this.btnNextSearch.Text = "Next";
            this.btnNextSearch.UseVisualStyleBackColor = true;
            this.btnNextSearch.Click += new System.EventHandler(this.btnNextSearch_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(843, 466);
            this.Controls.Add(this.btnNextSearch);
            this.Controls.Add(this.btnPreviousSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxSearch;
        private System.Windows.Forms.Button btnPreviousSearch;
        private System.Windows.Forms.Button btnNextSearch;
    }
}