namespace SemestralniPrace_JanHolda.PopUps
{
    partial class Vstupy
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
            this.LabelVstupy = new System.Windows.Forms.Label();
            this.NormalRButt = new System.Windows.Forms.RadioButton();
            this.StudentRButt = new System.Windows.Forms.RadioButton();
            this.DuchodRButt = new System.Windows.Forms.RadioButton();
            this.roundedButton1 = new SemestralniPrace_JanHolda.RoundedUI.RoundedButton();
            this.SuspendLayout();
            // 
            // LabelVstupy
            // 
            this.LabelVstupy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelVstupy.AutoSize = true;
            this.LabelVstupy.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVstupy.Location = new System.Drawing.Point(312, 36);
            this.LabelVstupy.Name = "LabelVstupy";
            this.LabelVstupy.Size = new System.Drawing.Size(137, 38);
            this.LabelVstupy.TabIndex = 1;
            this.LabelVstupy.Text = "Permice";
            // 
            // NormalRButt
            // 
            this.NormalRButt.AutoSize = true;
            this.NormalRButt.Checked = true;
            this.NormalRButt.Location = new System.Drawing.Point(319, 142);
            this.NormalRButt.Name = "NormalRButt";
            this.NormalRButt.Size = new System.Drawing.Size(94, 17);
            this.NormalRButt.TabIndex = 4;
            this.NormalRButt.TabStop = true;
            this.NormalRButt.Text = "Klasický Vstup";
            this.NormalRButt.UseVisualStyleBackColor = true;
            this.NormalRButt.CheckedChanged += new System.EventHandler(this.NormalRButt_CheckedChanged);
            // 
            // StudentRButt
            // 
            this.StudentRButt.AutoSize = true;
            this.StudentRButt.Location = new System.Drawing.Point(319, 190);
            this.StudentRButt.Name = "StudentRButt";
            this.StudentRButt.Size = new System.Drawing.Size(108, 17);
            this.StudentRButt.TabIndex = 5;
            this.StudentRButt.Text = "Studentský Vstup";
            this.StudentRButt.UseVisualStyleBackColor = true;
            this.StudentRButt.CheckedChanged += new System.EventHandler(this.StudentRButt_CheckedChanged);
            // 
            // DuchodRButt
            // 
            this.DuchodRButt.AutoSize = true;
            this.DuchodRButt.Location = new System.Drawing.Point(319, 232);
            this.DuchodRButt.Name = "DuchodRButt";
            this.DuchodRButt.Size = new System.Drawing.Size(110, 17);
            this.DuchodRButt.TabIndex = 6;
            this.DuchodRButt.Text = "Důchodový Vstup";
            this.DuchodRButt.UseVisualStyleBackColor = true;
            this.DuchodRButt.CheckedChanged += new System.EventHandler(this.DuchodRButt_CheckedChanged);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.roundedButton1.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.roundedButton1.BorderColor = System.Drawing.Color.White;
            this.roundedButton1.BorderRadius = 40;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(305, 332);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(150, 40);
            this.roundedButton1.TabIndex = 8;
            this.roundedButton1.Text = "Potvrdit";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // Vstupy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DuchodRButt);
            this.Controls.Add(this.NormalRButt);
            this.Controls.Add(this.StudentRButt);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.LabelVstupy);
            this.Name = "Vstupy";
            this.Text = "Vstupy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelVstupy;
        private System.Windows.Forms.RadioButton NormalRButt;
        private System.Windows.Forms.RadioButton StudentRButt;
        private System.Windows.Forms.RadioButton DuchodRButt;
        private RoundedUI.RoundedButton roundedButton1;
    }
}