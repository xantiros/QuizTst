namespace QuizTst
{
    partial class Game
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
            this.content = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rbAA = new System.Windows.Forms.RadioButton();
            this.rbBB = new System.Windows.Forms.RadioButton();
            this.rbCC = new System.Windows.Forms.RadioButton();
            this.rbDD = new System.Windows.Forms.RadioButton();
            this.panel_Game = new System.Windows.Forms.Panel();
            this.panel_1_100 = new System.Windows.Forms.Panel();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.panel_Game.SuspendLayout();
            this.panel_1_100.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Location = new System.Drawing.Point(10, 25);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(42, 13);
            this.content.TabIndex = 0;
            this.content.Text = "Pytanie";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(85, 216);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Odpowiedz";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 264);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(253, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // rbAA
            // 
            this.rbAA.AutoSize = true;
            this.rbAA.Location = new System.Drawing.Point(13, 59);
            this.rbAA.Name = "rbAA";
            this.rbAA.Size = new System.Drawing.Size(88, 17);
            this.rbAA.TabIndex = 3;
            this.rbAA.TabStop = true;
            this.rbAA.Text = "Odpowiedz A";
            this.rbAA.UseVisualStyleBackColor = true;
            // 
            // rbBB
            // 
            this.rbBB.AutoSize = true;
            this.rbBB.Location = new System.Drawing.Point(13, 98);
            this.rbBB.Name = "rbBB";
            this.rbBB.Size = new System.Drawing.Size(88, 17);
            this.rbBB.TabIndex = 4;
            this.rbBB.TabStop = true;
            this.rbBB.Text = "Odpowiedz B";
            this.rbBB.UseVisualStyleBackColor = true;
            // 
            // rbCC
            // 
            this.rbCC.AutoSize = true;
            this.rbCC.Location = new System.Drawing.Point(13, 137);
            this.rbCC.Name = "rbCC";
            this.rbCC.Size = new System.Drawing.Size(88, 17);
            this.rbCC.TabIndex = 5;
            this.rbCC.TabStop = true;
            this.rbCC.Text = "Odpowiedz C";
            this.rbCC.UseVisualStyleBackColor = true;
            // 
            // rbDD
            // 
            this.rbDD.AutoSize = true;
            this.rbDD.Location = new System.Drawing.Point(13, 177);
            this.rbDD.Name = "rbDD";
            this.rbDD.Size = new System.Drawing.Size(89, 17);
            this.rbDD.TabIndex = 6;
            this.rbDD.TabStop = true;
            this.rbDD.Text = "Odpowiedz D";
            this.rbDD.UseVisualStyleBackColor = true;
            // 
            // panel_Game
            // 
            this.panel_Game.Controls.Add(this.progressBar1);
            this.panel_Game.Controls.Add(this.rbDD);
            this.panel_Game.Controls.Add(this.content);
            this.panel_Game.Controls.Add(this.rbCC);
            this.panel_Game.Controls.Add(this.btnCheck);
            this.panel_Game.Controls.Add(this.rbBB);
            this.panel_Game.Controls.Add(this.rbAA);
            this.panel_Game.Location = new System.Drawing.Point(12, 12);
            this.panel_Game.Name = "panel_Game";
            this.panel_Game.Size = new System.Drawing.Size(294, 318);
            this.panel_Game.TabIndex = 8;
            // 
            // panel_1_100
            // 
            this.panel_1_100.Controls.Add(this.btn_2);
            this.panel_1_100.Controls.Add(this.btn_1);
            this.panel_1_100.Location = new System.Drawing.Point(12, 12);
            this.panel_1_100.Name = "panel_1_100";
            this.panel_1_100.Size = new System.Drawing.Size(294, 318);
            this.panel_1_100.TabIndex = 9;
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(42, 76);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 23);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(42, 25);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 25);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 362);
            this.Controls.Add(this.panel_1_100);
            this.Controls.Add(this.panel_Game);
            this.Name = "Game";
            this.Text = "Game";
            this.panel_Game.ResumeLayout(false);
            this.panel_Game.PerformLayout();
            this.panel_1_100.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label content;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rbAA;
        private System.Windows.Forms.RadioButton rbBB;
        private System.Windows.Forms.RadioButton rbCC;
        private System.Windows.Forms.RadioButton rbDD;
        private System.Windows.Forms.Panel panel_Game;
        private System.Windows.Forms.Panel panel_1_100;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
    }
}