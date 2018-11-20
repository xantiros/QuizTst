namespace QuizTst
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_checkForUpdate = new System.Windows.Forms.Button();
            this.panel_StarWindow = new System.Windows.Forms.Panel();
            this.panel_Levels = new System.Windows.Forms.Panel();
            this.btn_Level1 = new System.Windows.Forms.Button();
            this.btn_Level2 = new System.Windows.Forms.Button();
            this.btn_Level3 = new System.Windows.Forms.Button();
            this.panel_StarWindow.SuspendLayout();
            this.panel_Levels.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Play.Location = new System.Drawing.Point(28, 14);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(130, 56);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_checkForUpdate
            // 
            this.btn_checkForUpdate.Location = new System.Drawing.Point(28, 191);
            this.btn_checkForUpdate.Name = "btn_checkForUpdate";
            this.btn_checkForUpdate.Size = new System.Drawing.Size(130, 56);
            this.btn_checkForUpdate.TabIndex = 1;
            this.btn_checkForUpdate.Text = "Check for update questions";
            this.btn_checkForUpdate.UseVisualStyleBackColor = true;
            this.btn_checkForUpdate.Click += new System.EventHandler(this.btn_CheckForUpdates_Click);
            // 
            // panel_StarWindow
            // 
            this.panel_StarWindow.Controls.Add(this.btn_Play);
            this.panel_StarWindow.Controls.Add(this.btn_checkForUpdate);
            this.panel_StarWindow.Location = new System.Drawing.Point(12, 12);
            this.panel_StarWindow.Name = "panel_StarWindow";
            this.panel_StarWindow.Size = new System.Drawing.Size(190, 270);
            this.panel_StarWindow.TabIndex = 2;
            // 
            // panel_Levels
            // 
            this.panel_Levels.Controls.Add(this.btn_Level3);
            this.panel_Levels.Controls.Add(this.btn_Level2);
            this.panel_Levels.Controls.Add(this.btn_Level1);
            this.panel_Levels.Location = new System.Drawing.Point(220, 12);
            this.panel_Levels.Name = "panel_Levels";
            this.panel_Levels.Size = new System.Drawing.Size(190, 270);
            this.panel_Levels.TabIndex = 3;
            // 
            // btn_Level1
            // 
            this.btn_Level1.Location = new System.Drawing.Point(27, 14);
            this.btn_Level1.Name = "btn_Level1";
            this.btn_Level1.Size = new System.Drawing.Size(130, 56);
            this.btn_Level1.TabIndex = 0;
            this.btn_Level1.Text = "Poziom 1";
            this.btn_Level1.UseVisualStyleBackColor = true;
            this.btn_Level1.Click += new System.EventHandler(this.btn_Level1_Click);
            // 
            // btn_Level2
            // 
            this.btn_Level2.Location = new System.Drawing.Point(27, 101);
            this.btn_Level2.Name = "btn_Level2";
            this.btn_Level2.Size = new System.Drawing.Size(130, 56);
            this.btn_Level2.TabIndex = 1;
            this.btn_Level2.Text = "Poziom 2";
            this.btn_Level2.UseVisualStyleBackColor = true;
            // 
            // btn_Level3
            // 
            this.btn_Level3.Location = new System.Drawing.Point(27, 191);
            this.btn_Level3.Name = "btn_Level3";
            this.btn_Level3.Size = new System.Drawing.Size(130, 56);
            this.btn_Level3.TabIndex = 2;
            this.btn_Level3.Text = "Poziom 3";
            this.btn_Level3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 294);
            this.Controls.Add(this.panel_Levels);
            this.Controls.Add(this.panel_StarWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_StarWindow.ResumeLayout(false);
            this.panel_Levels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_checkForUpdate;
        private System.Windows.Forms.Button btn_Level3;
        private System.Windows.Forms.Button btn_Level2;
        private System.Windows.Forms.Button btn_Level1;
        public System.Windows.Forms.Panel panel_StarWindow;
        public System.Windows.Forms.Panel panel_Levels;
    }
}

