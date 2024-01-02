namespace SemestralniPrace_JanHolda
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.NavbarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.NavContainer = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.CardContainer = new SemestralniPrace_JanHolda.RoundedUI.RoundedPanel();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.ButtonLogin = new SemestralniPrace_JanHolda.RoundedUI.RoundedButton();
            this.BoxUserPass = new System.Windows.Forms.TextBox();
            this.HesloLabel = new System.Windows.Forms.Label();
            this.BoxUserName = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NavContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.CardContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavbarContainer
            // 
            this.NavbarContainer.AutoSize = true;
            this.NavbarContainer.BackColor = System.Drawing.Color.Transparent;
            this.NavbarContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavbarContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.NavbarContainer.Location = new System.Drawing.Point(0, 0);
            this.NavbarContainer.Name = "NavbarContainer";
            this.NavbarContainer.Size = new System.Drawing.Size(704, 0);
            this.NavbarContainer.TabIndex = 0;
            this.NavbarContainer.WrapContents = false;
            // 
            // NavContainer
            // 
            this.NavContainer.BackColor = System.Drawing.Color.Silver;
            this.NavContainer.Controls.Add(this.Logo);
            this.NavContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavContainer.Location = new System.Drawing.Point(0, 0);
            this.NavContainer.Name = "NavContainer";
            this.NavContainer.Size = new System.Drawing.Size(704, 50);
            this.NavContainer.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logo.Image = global::SemestralniPrace_JanHolda.Properties.Resources.Logo__1_;
            this.Logo.Location = new System.Drawing.Point(276, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(149, 33);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // CardContainer
            // 
            this.CardContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardContainer.AutoSize = true;
            this.CardContainer.BackColor = System.Drawing.Color.White;
            this.CardContainer.BorderRadius = 30;
            this.CardContainer.Controls.Add(this.HeadingLabel);
            this.CardContainer.Controls.Add(this.ButtonLogin);
            this.CardContainer.Controls.Add(this.BoxUserPass);
            this.CardContainer.Controls.Add(this.HesloLabel);
            this.CardContainer.Controls.Add(this.BoxUserName);
            this.CardContainer.Controls.Add(this.NameLabel);
            this.CardContainer.Location = new System.Drawing.Point(222, 106);
            this.CardContainer.Name = "CardContainer";
            this.CardContainer.Size = new System.Drawing.Size(256, 258);
            this.CardContainer.TabIndex = 2;
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(48, 24);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(104, 35);
            this.HeadingLabel.TabIndex = 5;
            this.HeadingLabel.Text = "Vítejte";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ButtonLogin.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.ButtonLogin.BorderColor = System.Drawing.Color.White;
            this.ButtonLogin.BorderRadius = 16;
            this.ButtonLogin.BorderSize = 0;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(74, 183);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(112, 24);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Přihlásit se";
            this.ButtonLogin.TextColor = System.Drawing.Color.White;
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // BoxUserPass
            // 
            this.BoxUserPass.Location = new System.Drawing.Point(50, 146);
            this.BoxUserPass.Name = "BoxUserPass";
            this.BoxUserPass.Size = new System.Drawing.Size(136, 20);
            this.BoxUserPass.TabIndex = 3;
            // 
            // HesloLabel
            // 
            this.HesloLabel.AutoSize = true;
            this.HesloLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HesloLabel.Location = new System.Drawing.Point(50, 124);
            this.HesloLabel.Name = "HesloLabel";
            this.HesloLabel.Size = new System.Drawing.Size(52, 19);
            this.HesloLabel.TabIndex = 2;
            this.HesloLabel.Text = "Heslo";
            // 
            // BoxUserName
            // 
            this.BoxUserName.Location = new System.Drawing.Point(50, 101);
            this.BoxUserName.Name = "BoxUserName";
            this.BoxUserName.Size = new System.Drawing.Size(136, 20);
            this.BoxUserName.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(50, 79);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 19);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Jméno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::SemestralniPrace_JanHolda.Properties.Resources.Group_31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.CardContainer);
            this.Controls.Add(this.NavContainer);
            this.Controls.Add(this.NavbarContainer);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikace";
            this.NavContainer.ResumeLayout(false);
            this.NavContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.CardContainer.ResumeLayout(false);
            this.CardContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel NavbarContainer;
        private System.Windows.Forms.Panel NavContainer;
        private System.Windows.Forms.PictureBox Logo;
        private RoundedUI.RoundedPanel CardContainer;
        private System.Windows.Forms.Label HesloLabel;
        private System.Windows.Forms.TextBox BoxUserName;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox BoxUserPass;
        private RoundedUI.RoundedButton ButtonLogin;
        private System.Windows.Forms.Label HeadingLabel;
    }
}

