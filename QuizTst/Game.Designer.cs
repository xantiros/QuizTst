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
            this.Content = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rbAA = new System.Windows.Forms.RadioButton();
            this.rbBB = new System.Windows.Forms.RadioButton();
            this.rbCC = new System.Windows.Forms.RadioButton();
            this.rbDD = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.AutoSize = true;
            this.Content.Location = new System.Drawing.Point(109, 38);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(42, 13);
            this.Content.TabIndex = 0;
            this.Content.Text = "Pytanie";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(158, 284);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Odpowiedz";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(57, 342);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(302, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // rbAA
            // 
            this.rbAA.AutoSize = true;
            this.rbAA.Location = new System.Drawing.Point(88, 99);
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
            this.rbBB.Location = new System.Drawing.Point(88, 138);
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
            this.rbCC.Location = new System.Drawing.Point(88, 177);
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
            this.rbDD.Location = new System.Drawing.Point(88, 217);
            this.rbDD.Name = "rbDD";
            this.rbDD.Size = new System.Drawing.Size(89, 17);
            this.rbDD.TabIndex = 6;
            this.rbDD.TabStop = true;
            this.rbDD.Text = "Odpowiedz D";
            this.rbDD.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 428);
            this.Controls.Add(this.rbDD);
            this.Controls.Add(this.rbCC);
            this.Controls.Add(this.rbBB);
            this.Controls.Add(this.rbAA);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.Content);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Content;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rbAA;
        private System.Windows.Forms.RadioButton rbBB;
        private System.Windows.Forms.RadioButton rbCC;
        private System.Windows.Forms.RadioButton rbDD;
    }
}