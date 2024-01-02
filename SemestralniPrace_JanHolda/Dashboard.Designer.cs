namespace SemestralniPrace_JanHolda
{
    partial class Dashboard
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
            this.roundedPanel1 = new SemestralniPrace_JanHolda.RoundedUI.RoundedPanel();
            this.roundedPanel2 = new SemestralniPrace_JanHolda.RoundedUI.RoundedPanel();
            this.roundedPanel3 = new SemestralniPrace_JanHolda.RoundedUI.RoundedPanel();
            this.PermiceStaticLabel = new System.Windows.Forms.Label();
            this.VstupyStaticLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.Controls.Add(this.PermiceStaticLabel);
            this.roundedPanel1.Location = new System.Drawing.Point(12, 22);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(257, 68);
            this.roundedPanel1.TabIndex = 0;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BorderRadius = 15;
            this.roundedPanel2.Controls.Add(this.VstupyStaticLabel);
            this.roundedPanel2.Location = new System.Drawing.Point(275, 22);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(257, 68);
            this.roundedPanel2.TabIndex = 1;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.White;
            this.roundedPanel3.BorderRadius = 15;
            this.roundedPanel3.Controls.Add(this.label2);
            this.roundedPanel3.Location = new System.Drawing.Point(538, 22);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(257, 68);
            this.roundedPanel3.TabIndex = 1;
            // 
            // PermiceStaticLabel
            // 
            this.PermiceStaticLabel.AutoSize = true;
            this.PermiceStaticLabel.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PermiceStaticLabel.Location = new System.Drawing.Point(136, 18);
            this.PermiceStaticLabel.Name = "PermiceStaticLabel";
            this.PermiceStaticLabel.Size = new System.Drawing.Size(118, 32);
            this.PermiceStaticLabel.TabIndex = 0;
            this.PermiceStaticLabel.Text = "Permice";
            // 
            // VstupyStaticLabel
            // 
            this.VstupyStaticLabel.AutoSize = true;
            this.VstupyStaticLabel.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VstupyStaticLabel.Location = new System.Drawing.Point(136, 18);
            this.VstupyStaticLabel.Name = "VstupyStaticLabel";
            this.VstupyStaticLabel.Size = new System.Drawing.Size(103, 32);
            this.VstupyStaticLabel.TabIndex = 1;
            this.VstupyStaticLabel.Text = "Vstupy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Permice";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::SemestralniPrace_JanHolda.Properties.Resources.Group_32;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.DoubleBuffered = true;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedUI.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label PermiceStaticLabel;
        private RoundedUI.RoundedPanel roundedPanel2;
        private RoundedUI.RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label VstupyStaticLabel;
        private System.Windows.Forms.Label label2;
    }
}