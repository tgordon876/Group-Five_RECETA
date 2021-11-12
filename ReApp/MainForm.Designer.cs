
namespace ReApp
{
    partial class MainForm
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
            this.pnlSideNavBar = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtBSearch = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideNavBar
            // 
            this.pnlSideNavBar.BackColor = System.Drawing.Color.Black;
            this.pnlSideNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideNavBar.Name = "pnlSideNavBar";
            this.pnlSideNavBar.Size = new System.Drawing.Size(250, 633);
            this.pnlSideNavBar.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.txtBSearch);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(250, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(795, 76);
            this.pnlTop.TabIndex = 1;
            // 
            // txtBSearch
            // 
            this.txtBSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBSearch.ForeColor = System.Drawing.Color.Olive;
            this.txtBSearch.Location = new System.Drawing.Point(105, 27);
            this.txtBSearch.Name = "txtBSearch";
            this.txtBSearch.Size = new System.Drawing.Size(578, 27);
            this.txtBSearch.TabIndex = 0;
            this.txtBSearch.Text = " Search Recipe";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 633);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSideNavBar);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "RECETA";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideNavBar;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtBSearch;
    }
}

