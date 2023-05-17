namespace New_Hello_World
{
    partial class ClickTheButton
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
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.NewHelloWorldLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ClickMeButton.Location = new System.Drawing.Point(479, 210);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(337, 96);
            this.ClickMeButton.TabIndex = 0;
            this.ClickMeButton.Text = "Click Me!";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewHelloWorldLabel
            // 
            this.NewHelloWorldLabel.AutoSize = true;
            this.NewHelloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.NewHelloWorldLabel.Location = new System.Drawing.Point(473, 75);
            this.NewHelloWorldLabel.Name = "NewHelloWorldLabel";
            this.NewHelloWorldLabel.Size = new System.Drawing.Size(698, 97);
            this.NewHelloWorldLabel.TabIndex = 3;
            this.NewHelloWorldLabel.Text = "Click The Button!";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AnswerLabel.Location = new System.Drawing.Point(479, 393);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(337, 96);
            this.AnswerLabel.TabIndex = 4;
            this.AnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ClearButton.Location = new System.Drawing.Point(300, 576);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(315, 90);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ExitButton.Location = new System.Drawing.Point(705, 576);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(315, 90);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClickTheButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1274, 729);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.NewHelloWorldLabel);
            this.Controls.Add(this.ClickMeButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "ClickTheButton";
            this.Text = "Click The Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.Label NewHelloWorldLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

