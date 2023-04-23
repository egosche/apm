namespace apm.Forms
{
    partial class Umbuchen
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
            this.lb_umBuchen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_umBuchen
            // 
            this.lb_umBuchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_umBuchen.AutoSize = true;
            this.lb_umBuchen.Location = new System.Drawing.Point(256, 176);
            this.lb_umBuchen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_umBuchen.Name = "lb_umBuchen";
            this.lb_umBuchen.Size = new System.Drawing.Size(69, 13);
            this.lb_umBuchen.TabIndex = 3;
            this.lb_umBuchen.Text = "(Um-)Buchen";
            // 
            // Umbuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lb_umBuchen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Umbuchen";
            this.Text = "Umbuchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_umBuchen;
    }
}