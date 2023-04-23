namespace apm
{
    partial class Startfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startfenster));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pn_CheckIn = new System.Windows.Forms.Panel();
            this.tb_scan = new System.Windows.Forms.TextBox();
            this.lb_checkIn = new System.Windows.Forms.Label();
            this.btn_startManuell = new FontAwesome.Sharp.IconButton();
            this.btn_checkIn = new FontAwesome.Sharp.IconButton();
            this.btn_umbuchen = new FontAwesome.Sharp.IconButton();
            this.btn_informationenAbrufen = new FontAwesome.Sharp.IconButton();
            this.btn_passagiere = new FontAwesome.Sharp.IconButton();
            this.btn_entfernen = new FontAwesome.Sharp.IconButton();
            this.btn_bearbeiten = new FontAwesome.Sharp.IconButton();
            this.btn_hinzufuegen = new FontAwesome.Sharp.IconButton();
            this.btn_kunden = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pn_Kunden = new System.Windows.Forms.Panel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.pn_header = new System.Windows.Forms.Panel();
            this.lb_formtitel = new System.Windows.Forms.Label();
            this.ipb_seite = new FontAwesome.Sharp.IconPictureBox();
            this.pn_shadow = new System.Windows.Forms.Panel();
            this.pn_form = new System.Windows.Forms.Panel();
            this.llb_sprache = new System.Windows.Forms.LinkLabel();
            this.llb_anmelden = new System.Windows.Forms.LinkLabel();
            this.panelMenu.SuspendLayout();
            this.pn_CheckIn.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.pn_Kunden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.pn_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipb_seite)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.panelMenu.Controls.Add(this.pn_CheckIn);
            this.panelMenu.Controls.Add(this.btn_startManuell);
            this.panelMenu.Controls.Add(this.btn_checkIn);
            this.panelMenu.Controls.Add(this.btn_umbuchen);
            this.panelMenu.Controls.Add(this.btn_informationenAbrufen);
            this.panelMenu.Controls.Add(this.btn_passagiere);
            this.panelMenu.Controls.Add(this.btn_entfernen);
            this.panelMenu.Controls.Add(this.btn_bearbeiten);
            this.panelMenu.Controls.Add(this.btn_hinzufuegen);
            this.panelMenu.Controls.Add(this.btn_kunden);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 559);
            this.panelMenu.TabIndex = 0;
            // 
            // pn_CheckIn
            // 
            this.pn_CheckIn.Controls.Add(this.tb_scan);
            this.pn_CheckIn.Controls.Add(this.lb_checkIn);
            this.pn_CheckIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_CheckIn.Location = new System.Drawing.Point(0, 450);
            this.pn_CheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.pn_CheckIn.Name = "pn_CheckIn";
            this.pn_CheckIn.Size = new System.Drawing.Size(165, 102);
            this.pn_CheckIn.TabIndex = 10;
            // 
            // tb_scan
            // 
            this.tb_scan.Location = new System.Drawing.Point(17, 48);
            this.tb_scan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_scan.Name = "tb_scan";
            this.tb_scan.Size = new System.Drawing.Size(139, 20);
            this.tb_scan.TabIndex = 1;
            // 
            // lb_checkIn
            // 
            this.lb_checkIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_checkIn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_checkIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.lb_checkIn.Location = new System.Drawing.Point(15, 9);
            this.lb_checkIn.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.lb_checkIn.Name = "lb_checkIn";
            this.lb_checkIn.Size = new System.Drawing.Size(140, 29);
            this.lb_checkIn.TabIndex = 0;
            this.lb_checkIn.Text = "Scanne Ticket";
            this.lb_checkIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_startManuell
            // 
            this.btn_startManuell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_startManuell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_startManuell.FlatAppearance.BorderSize = 0;
            this.btn_startManuell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startManuell.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_startManuell.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startManuell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_startManuell.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.btn_startManuell.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_startManuell.IconSize = 32;
            this.btn_startManuell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_startManuell.Location = new System.Drawing.Point(0, 409);
            this.btn_startManuell.Margin = new System.Windows.Forms.Padding(2);
            this.btn_startManuell.Name = "btn_startManuell";
            this.btn_startManuell.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_startManuell.Rotation = 0D;
            this.btn_startManuell.Size = new System.Drawing.Size(165, 41);
            this.btn_startManuell.TabIndex = 9;
            this.btn_startManuell.Text = "Start manuell";
            this.btn_startManuell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_startManuell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_startManuell.UseVisualStyleBackColor = true;
            this.btn_startManuell.Click += new System.EventHandler(this.btn_startManuell_Click);
            // 
            // btn_checkIn
            // 
            this.btn_checkIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_checkIn.Enabled = false;
            this.btn_checkIn.FlatAppearance.BorderSize = 0;
            this.btn_checkIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkIn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_checkIn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_checkIn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_checkIn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_checkIn.IconSize = 32;
            this.btn_checkIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_checkIn.Location = new System.Drawing.Point(0, 368);
            this.btn_checkIn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_checkIn.Name = "btn_checkIn";
            this.btn_checkIn.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_checkIn.Rotation = 0D;
            this.btn_checkIn.Size = new System.Drawing.Size(165, 41);
            this.btn_checkIn.TabIndex = 8;
            this.btn_checkIn.Text = "Check-In";
            this.btn_checkIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_checkIn.UseVisualStyleBackColor = true;
            // 
            // btn_umbuchen
            // 
            this.btn_umbuchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_umbuchen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_umbuchen.FlatAppearance.BorderSize = 0;
            this.btn_umbuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_umbuchen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_umbuchen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_umbuchen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_umbuchen.IconChar = FontAwesome.Sharp.IconChar.Plane;
            this.btn_umbuchen.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_umbuchen.IconSize = 32;
            this.btn_umbuchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_umbuchen.Location = new System.Drawing.Point(0, 327);
            this.btn_umbuchen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_umbuchen.Name = "btn_umbuchen";
            this.btn_umbuchen.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_umbuchen.Rotation = 0D;
            this.btn_umbuchen.Size = new System.Drawing.Size(165, 41);
            this.btn_umbuchen.TabIndex = 7;
            this.btn_umbuchen.Text = "(Um-)Buchen";
            this.btn_umbuchen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_umbuchen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_umbuchen.UseVisualStyleBackColor = true;
            this.btn_umbuchen.Click += new System.EventHandler(this.btn_umbuchen_Click);
            // 
            // btn_informationenAbrufen
            // 
            this.btn_informationenAbrufen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_informationenAbrufen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_informationenAbrufen.FlatAppearance.BorderSize = 0;
            this.btn_informationenAbrufen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_informationenAbrufen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_informationenAbrufen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_informationenAbrufen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_informationenAbrufen.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btn_informationenAbrufen.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_informationenAbrufen.IconSize = 32;
            this.btn_informationenAbrufen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_informationenAbrufen.Location = new System.Drawing.Point(0, 286);
            this.btn_informationenAbrufen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_informationenAbrufen.Name = "btn_informationenAbrufen";
            this.btn_informationenAbrufen.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_informationenAbrufen.Rotation = 0D;
            this.btn_informationenAbrufen.Size = new System.Drawing.Size(165, 41);
            this.btn_informationenAbrufen.TabIndex = 6;
            this.btn_informationenAbrufen.Text = "Informationen abrufen";
            this.btn_informationenAbrufen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_informationenAbrufen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_informationenAbrufen.UseVisualStyleBackColor = true;
            this.btn_informationenAbrufen.Click += new System.EventHandler(this.btn_informationenAbrufen_Click);
            // 
            // btn_passagiere
            // 
            this.btn_passagiere.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_passagiere.Enabled = false;
            this.btn_passagiere.FlatAppearance.BorderSize = 0;
            this.btn_passagiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_passagiere.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_passagiere.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_passagiere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_passagiere.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_passagiere.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_passagiere.IconSize = 32;
            this.btn_passagiere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_passagiere.Location = new System.Drawing.Point(0, 245);
            this.btn_passagiere.Margin = new System.Windows.Forms.Padding(2);
            this.btn_passagiere.Name = "btn_passagiere";
            this.btn_passagiere.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_passagiere.Rotation = 0D;
            this.btn_passagiere.Size = new System.Drawing.Size(165, 41);
            this.btn_passagiere.TabIndex = 5;
            this.btn_passagiere.Text = "Passagiere";
            this.btn_passagiere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_passagiere.UseVisualStyleBackColor = true;
            // 
            // btn_entfernen
            // 
            this.btn_entfernen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entfernen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_entfernen.FlatAppearance.BorderSize = 0;
            this.btn_entfernen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entfernen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_entfernen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entfernen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_entfernen.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btn_entfernen.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_entfernen.IconSize = 32;
            this.btn_entfernen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_entfernen.Location = new System.Drawing.Point(0, 204);
            this.btn_entfernen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_entfernen.Name = "btn_entfernen";
            this.btn_entfernen.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_entfernen.Rotation = 0D;
            this.btn_entfernen.Size = new System.Drawing.Size(165, 41);
            this.btn_entfernen.TabIndex = 4;
            this.btn_entfernen.Text = "Entfernen";
            this.btn_entfernen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_entfernen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_entfernen.UseVisualStyleBackColor = true;
            this.btn_entfernen.Click += new System.EventHandler(this.btn_entfernen_Click);
            // 
            // btn_bearbeiten
            // 
            this.btn_bearbeiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bearbeiten.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bearbeiten.FlatAppearance.BorderSize = 0;
            this.btn_bearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bearbeiten.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_bearbeiten.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bearbeiten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_bearbeiten.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btn_bearbeiten.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_bearbeiten.IconSize = 32;
            this.btn_bearbeiten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bearbeiten.Location = new System.Drawing.Point(0, 163);
            this.btn_bearbeiten.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bearbeiten.Name = "btn_bearbeiten";
            this.btn_bearbeiten.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_bearbeiten.Rotation = 0D;
            this.btn_bearbeiten.Size = new System.Drawing.Size(165, 41);
            this.btn_bearbeiten.TabIndex = 3;
            this.btn_bearbeiten.Text = "Bearbeiten";
            this.btn_bearbeiten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bearbeiten.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bearbeiten.UseVisualStyleBackColor = true;
            this.btn_bearbeiten.Click += new System.EventHandler(this.btn_bearbeiten_Click);
            // 
            // btn_hinzufuegen
            // 
            this.btn_hinzufuegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hinzufuegen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hinzufuegen.FlatAppearance.BorderSize = 0;
            this.btn_hinzufuegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hinzufuegen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_hinzufuegen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hinzufuegen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_hinzufuegen.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_hinzufuegen.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_hinzufuegen.IconSize = 32;
            this.btn_hinzufuegen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hinzufuegen.Location = new System.Drawing.Point(0, 122);
            this.btn_hinzufuegen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hinzufuegen.Name = "btn_hinzufuegen";
            this.btn_hinzufuegen.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_hinzufuegen.Rotation = 0D;
            this.btn_hinzufuegen.Size = new System.Drawing.Size(165, 41);
            this.btn_hinzufuegen.TabIndex = 2;
            this.btn_hinzufuegen.Text = "Hinzufügen";
            this.btn_hinzufuegen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hinzufuegen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hinzufuegen.UseVisualStyleBackColor = true;
            this.btn_hinzufuegen.Click += new System.EventHandler(this.btn_hinzufuegen_Click);
            // 
            // btn_kunden
            // 
            this.btn_kunden.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_kunden.Enabled = false;
            this.btn_kunden.FlatAppearance.BorderSize = 0;
            this.btn_kunden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kunden.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_kunden.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kunden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_kunden.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_kunden.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btn_kunden.IconSize = 32;
            this.btn_kunden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kunden.Location = new System.Drawing.Point(0, 81);
            this.btn_kunden.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kunden.Name = "btn_kunden";
            this.btn_kunden.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btn_kunden.Rotation = 0D;
            this.btn_kunden.Size = new System.Drawing.Size(165, 41);
            this.btn_kunden.TabIndex = 1;
            this.btn_kunden.Text = "Kunden";
            this.btn_kunden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kunden.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pn_Kunden);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(165, 81);
            this.panelLogo.TabIndex = 0;
            // 
            // pn_Kunden
            // 
            this.pn_Kunden.Controls.Add(this.pb_Logo);
            this.pn_Kunden.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Kunden.Location = new System.Drawing.Point(0, 0);
            this.pn_Kunden.Margin = new System.Windows.Forms.Padding(2);
            this.pn_Kunden.Name = "pn_Kunden";
            this.pn_Kunden.Size = new System.Drawing.Size(165, 81);
            this.pn_Kunden.TabIndex = 1;
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_Logo.Image = global::apm.Properties.Resources.apm;
            this.pb_Logo.Location = new System.Drawing.Point(18, 11);
            this.pb_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(124, 53);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.pn_header.Controls.Add(this.llb_anmelden);
            this.pn_header.Controls.Add(this.llb_sprache);
            this.pn_header.Controls.Add(this.lb_formtitel);
            this.pn_header.Controls.Add(this.ipb_seite);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(165, 0);
            this.pn_header.Margin = new System.Windows.Forms.Padding(2);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(834, 37);
            this.pn_header.TabIndex = 1;
            // 
            // lb_formtitel
            // 
            this.lb_formtitel.AutoSize = true;
            this.lb_formtitel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_formtitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.lb_formtitel.Location = new System.Drawing.Point(34, 11);
            this.lb_formtitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_formtitel.Name = "lb_formtitel";
            this.lb_formtitel.Size = new System.Drawing.Size(96, 19);
            this.lb_formtitel.TabIndex = 3;
            this.lb_formtitel.Text = "Hinzufügen";
            // 
            // ipb_seite
            // 
            this.ipb_seite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ipb_seite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.ipb_seite.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.ipb_seite.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.ipb_seite.IconSize = 24;
            this.ipb_seite.Location = new System.Drawing.Point(4, 2);
            this.ipb_seite.Margin = new System.Windows.Forms.Padding(2);
            this.ipb_seite.Name = "ipb_seite";
            this.ipb_seite.Size = new System.Drawing.Size(24, 26);
            this.ipb_seite.TabIndex = 2;
            this.ipb_seite.TabStop = false;
            // 
            // pn_shadow
            // 
            this.pn_shadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.pn_shadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_shadow.Location = new System.Drawing.Point(165, 37);
            this.pn_shadow.Margin = new System.Windows.Forms.Padding(2);
            this.pn_shadow.Name = "pn_shadow";
            this.pn_shadow.Size = new System.Drawing.Size(834, 7);
            this.pn_shadow.TabIndex = 2;
            // 
            // pn_form
            // 
            this.pn_form.Location = new System.Drawing.Point(165, 44);
            this.pn_form.Margin = new System.Windows.Forms.Padding(2);
            this.pn_form.Name = "pn_form";
            this.pn_form.Size = new System.Drawing.Size(834, 515);
            this.pn_form.TabIndex = 3;
            // 
            // llb_sprache
            // 
            this.llb_sprache.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(119)))), ((int)(((byte)(128)))));
            this.llb_sprache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_sprache.AutoSize = true;
            this.llb_sprache.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_sprache.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llb_sprache.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.llb_sprache.Location = new System.Drawing.Point(659, 12);
            this.llb_sprache.Name = "llb_sprache";
            this.llb_sprache.Size = new System.Drawing.Size(56, 16);
            this.llb_sprache.TabIndex = 4;
            this.llb_sprache.TabStop = true;
            this.llb_sprache.Text = "Sprache";
            this.llb_sprache.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            // 
            // llb_anmelden
            // 
            this.llb_anmelden.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(119)))), ((int)(((byte)(128)))));
            this.llb_anmelden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_anmelden.AutoSize = true;
            this.llb_anmelden.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_anmelden.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llb_anmelden.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.llb_anmelden.Location = new System.Drawing.Point(738, 12);
            this.llb_anmelden.Name = "llb_anmelden";
            this.llb_anmelden.Size = new System.Drawing.Size(71, 16);
            this.llb_anmelden.TabIndex = 5;
            this.llb_anmelden.TabStop = true;
            this.llb_anmelden.Text = "Anmelden";
            this.llb_anmelden.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            // 
            // Startfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 559);
            this.Controls.Add(this.pn_form);
            this.Controls.Add(this.pn_shadow);
            this.Controls.Add(this.pn_header);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1015, 598);
            this.Name = "Startfenster";
            this.Text = "Startfenster";
            this.panelMenu.ResumeLayout(false);
            this.pn_CheckIn.ResumeLayout(false);
            this.pn_CheckIn.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.pn_Kunden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipb_seite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btn_informationenAbrufen;
        private FontAwesome.Sharp.IconButton btn_passagiere;
        private FontAwesome.Sharp.IconButton btn_entfernen;
        private FontAwesome.Sharp.IconButton btn_bearbeiten;
        private FontAwesome.Sharp.IconButton btn_hinzufuegen;
        private FontAwesome.Sharp.IconButton btn_kunden;
        private System.Windows.Forms.Panel pn_Kunden;
        private FontAwesome.Sharp.IconButton btn_umbuchen;
        private FontAwesome.Sharp.IconButton btn_checkIn;
        private FontAwesome.Sharp.IconButton btn_startManuell;
        private System.Windows.Forms.Panel pn_CheckIn;
        private System.Windows.Forms.TextBox tb_scan;
        private System.Windows.Forms.Label lb_checkIn;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Panel pn_header;
        private FontAwesome.Sharp.IconPictureBox ipb_seite;
        private System.Windows.Forms.Label lb_formtitel;
        private System.Windows.Forms.Panel pn_shadow;
        private System.Windows.Forms.Panel pn_form;
        private System.Windows.Forms.LinkLabel llb_sprache;
        private System.Windows.Forms.LinkLabel llb_anmelden;
    }
}

