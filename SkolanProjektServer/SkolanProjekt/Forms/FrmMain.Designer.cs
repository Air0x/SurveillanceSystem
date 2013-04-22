namespace SkolanProjekt
{
    partial class FrmMain
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
            this.DebugListBox = new System.Windows.Forms.ListBox();
            this.ConnectedPCS = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DebugListBox
            // 
            this.DebugListBox.FormattingEnabled = true;
            this.DebugListBox.Location = new System.Drawing.Point(12, 217);
            this.DebugListBox.Name = "DebugListBox";
            this.DebugListBox.Size = new System.Drawing.Size(373, 121);
            this.DebugListBox.TabIndex = 0;
            // 
            // ConnectedPCS
            // 
            this.ConnectedPCS.FormattingEnabled = true;
            this.ConnectedPCS.Location = new System.Drawing.Point(391, 217);
            this.ConnectedPCS.Name = "ConnectedPCS";
            this.ConnectedPCS.Size = new System.Drawing.Size(116, 121);
            this.ConnectedPCS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Av Martin Jakobsson 2013";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectedPCS);
            this.Controls.Add(this.DebugListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolCont - Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox DebugListBox;
        public System.Windows.Forms.ListBox ConnectedPCS;
        private System.Windows.Forms.Label label1;



    }
}