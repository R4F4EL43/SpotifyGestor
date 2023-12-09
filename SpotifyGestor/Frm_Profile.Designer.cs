namespace SpotifyGestor
{
    partial class Frm_Profile
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
            this.components = new System.ComponentModel.Container();
            this.pcb_ProfileIcon = new System.Windows.Forms.PictureBox();
            this.lbl_Playlists = new System.Windows.Forms.Label();
            this.lbl_ProfileName = new System.Windows.Forms.Label();
            this.lbl_ProfileText = new System.Windows.Forms.Label();
            this.pcb_ProfileImage = new System.Windows.Forms.PictureBox();
            this.lvw_PlayLists = new System.Windows.Forms.ListView();
            this.mns_Profile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_Conta = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Premium = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Definições = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_Separator = new System.Windows.Forms.ToolStripSeparator();
            this.mni_logOut = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ProfileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ProfileImage)).BeginInit();
            this.mns_Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcb_ProfileIcon
            // 
            this.pcb_ProfileIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb_ProfileIcon.Image = global::SpotifyGestor.Properties.Resources.User_Logo;
            this.pcb_ProfileIcon.Location = new System.Drawing.Point(758, 13);
            this.pcb_ProfileIcon.Name = "pcb_ProfileIcon";
            this.pcb_ProfileIcon.Size = new System.Drawing.Size(30, 30);
            this.pcb_ProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_ProfileIcon.TabIndex = 12;
            this.pcb_ProfileIcon.TabStop = false;
            this.pcb_ProfileIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pcb_ProfileIcon_MouseClick);
            // 
            // lbl_Playlists
            // 
            this.lbl_Playlists.AutoSize = true;
            this.lbl_Playlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Playlists.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Playlists.Location = new System.Drawing.Point(187, 136);
            this.lbl_Playlists.Name = "lbl_Playlists";
            this.lbl_Playlists.Size = new System.Drawing.Size(66, 16);
            this.lbl_Playlists.TabIndex = 11;
            this.lbl_Playlists.Text = "0 playlists";
            // 
            // lbl_ProfileName
            // 
            this.lbl_ProfileName.AutoSize = true;
            this.lbl_ProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProfileName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ProfileName.Location = new System.Drawing.Point(157, 50);
            this.lbl_ProfileName.Name = "lbl_ProfileName";
            this.lbl_ProfileName.Size = new System.Drawing.Size(281, 31);
            this.lbl_ProfileName.TabIndex = 10;
            this.lbl_ProfileName.Text = "*NOME DE PERFIL*";
            // 
            // lbl_ProfileText
            // 
            this.lbl_ProfileText.AutoSize = true;
            this.lbl_ProfileText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ProfileText.Location = new System.Drawing.Point(163, 13);
            this.lbl_ProfileText.Name = "lbl_ProfileText";
            this.lbl_ProfileText.Size = new System.Drawing.Size(30, 13);
            this.lbl_ProfileText.TabIndex = 9;
            this.lbl_ProfileText.Text = "Perfil";
            // 
            // pcb_ProfileImage
            // 
            this.pcb_ProfileImage.Image = global::SpotifyGestor.Properties.Resources.User_Logo;
            this.pcb_ProfileImage.Location = new System.Drawing.Point(13, 13);
            this.pcb_ProfileImage.Name = "pcb_ProfileImage";
            this.pcb_ProfileImage.Size = new System.Drawing.Size(120, 120);
            this.pcb_ProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_ProfileImage.TabIndex = 8;
            this.pcb_ProfileImage.TabStop = false;
            // 
            // lvw_PlayLists
            // 
            this.lvw_PlayLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvw_PlayLists.BackColor = System.Drawing.SystemColors.MenuText;
            this.lvw_PlayLists.ForeColor = System.Drawing.SystemColors.Window;
            this.lvw_PlayLists.HideSelection = false;
            this.lvw_PlayLists.Location = new System.Drawing.Point(13, 179);
            this.lvw_PlayLists.Name = "lvw_PlayLists";
            this.lvw_PlayLists.Size = new System.Drawing.Size(775, 259);
            this.lvw_PlayLists.TabIndex = 7;
            this.lvw_PlayLists.UseCompatibleStateImageBehavior = false;
            // 
            // mns_Profile
            // 
            this.mns_Profile.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mns_Profile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_Conta,
            this.mni_Profile,
            this.mni_Premium,
            this.mni_Definições,
            this.tss_Separator,
            this.mni_logOut});
            this.mns_Profile.Name = "mns_Profile";
            this.mns_Profile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mns_Profile.Size = new System.Drawing.Size(181, 142);
            // 
            // mni_Conta
            // 
            this.mni_Conta.Name = "mni_Conta";
            this.mni_Conta.Size = new System.Drawing.Size(180, 22);
            this.mni_Conta.Text = "Conta";
            this.mni_Conta.Click += new System.EventHandler(this.mni_Conta_Click);
            // 
            // mni_Profile
            // 
            this.mni_Profile.Name = "mni_Profile";
            this.mni_Profile.Size = new System.Drawing.Size(180, 22);
            this.mni_Profile.Text = "Perfil";
            this.mni_Profile.Click += new System.EventHandler(this.mni_Profile_Click);
            // 
            // mni_Premium
            // 
            this.mni_Premium.Name = "mni_Premium";
            this.mni_Premium.Size = new System.Drawing.Size(180, 22);
            this.mni_Premium.Text = "Premium";
            this.mni_Premium.Click += new System.EventHandler(this.mni_Premium_Click);
            // 
            // mni_Definições
            // 
            this.mni_Definições.Name = "mni_Definições";
            this.mni_Definições.Size = new System.Drawing.Size(180, 22);
            this.mni_Definições.Text = "Definições";
            this.mni_Definições.Click += new System.EventHandler(this.mni_Definições_Click);
            // 
            // tss_Separator
            // 
            this.tss_Separator.Name = "tss_Separator";
            this.tss_Separator.Size = new System.Drawing.Size(177, 6);
            // 
            // mni_logOut
            // 
            this.mni_logOut.Name = "mni_logOut";
            this.mni_logOut.Size = new System.Drawing.Size(180, 22);
            this.mni_logOut.Text = "Terminar Sessão";
            this.mni_logOut.Click += new System.EventHandler(this.mni_logOut_Click);
            // 
            // Frm_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcb_ProfileIcon);
            this.Controls.Add(this.lbl_Playlists);
            this.Controls.Add(this.lbl_ProfileName);
            this.Controls.Add(this.lbl_ProfileText);
            this.Controls.Add(this.pcb_ProfileImage);
            this.Controls.Add(this.lvw_PlayLists);
            this.Name = "Frm_Profile";
            this.Text = "Frm_Profile";
            this.Load += new System.EventHandler(this.Frm_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ProfileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ProfileImage)).EndInit();
            this.mns_Profile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_ProfileIcon;
        private System.Windows.Forms.Label lbl_Playlists;
        private System.Windows.Forms.Label lbl_ProfileName;
        private System.Windows.Forms.Label lbl_ProfileText;
        private System.Windows.Forms.PictureBox pcb_ProfileImage;
        private System.Windows.Forms.ListView lvw_PlayLists;
        private System.Windows.Forms.ContextMenuStrip mns_Profile;
        private System.Windows.Forms.ToolStripMenuItem mni_Conta;
        private System.Windows.Forms.ToolStripMenuItem mni_Profile;
        private System.Windows.Forms.ToolStripMenuItem mni_Premium;
        private System.Windows.Forms.ToolStripMenuItem mni_Definições;
        private System.Windows.Forms.ToolStripSeparator tss_Separator;
        private System.Windows.Forms.ToolStripMenuItem mni_logOut;
    }
}