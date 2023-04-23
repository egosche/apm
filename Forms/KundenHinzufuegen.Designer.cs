namespace apm.Forms
{
    partial class KundenHinzufuegen
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
            this.lb_kundenHinzufuegen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_kundenHinzufuegen
            // 
            this.lb_kundenHinzufuegen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_kundenHinzufuegen.AutoSize = true;
            this.lb_kundenHinzufuegen.Location = new System.Drawing.Point(255, 176);
            this.lb_kundenHinzufuegen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_kundenHinzufuegen.Name = "lb_kundenHinzufuegen";
            this.lb_kundenHinzufuegen.Size = new System.Drawing.Size(99, 13);
            this.lb_kundenHinzufuegen.TabIndex = 2;
            this.lb_kundenHinzufuegen.Text = "Kunden hinzufügen";
            // 
            // KundenHinzufuegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lb_kundenHinzufuegen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KundenHinzufuegen";
            this.Text = "KundenHinzufuegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_kundenHinzufuegen;
    }
}