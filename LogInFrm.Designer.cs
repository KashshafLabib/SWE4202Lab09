namespace SWE4202Lab09A
{
    partial class LogInFrm
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
            this.SignupLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignupLabel
            // 
            this.SignupLabel.AutoSize = true;
            this.SignupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupLabel.LinkColor = System.Drawing.Color.Red;
            this.SignupLabel.Location = new System.Drawing.Point(422, 390);
            this.SignupLabel.Name = "SignupLabel";
            this.SignupLabel.Size = new System.Drawing.Size(89, 25);
            this.SignupLabel.TabIndex = 21;
            this.SignupLabel.TabStop = true;
            this.SignupLabel.Text = "Sign Up";
            this.SignupLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignupLabel_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Don\'t have an account?";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(316, 284);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(131, 54);
            this.loginButton.TabIndex = 19;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(377, 173);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(198, 33);
            this.passwordtextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // userNametextBox
            // 
            this.userNametextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNametextBox.Location = new System.Drawing.Point(377, 104);
            this.userNametextBox.Name = "userNametextBox";
            this.userNametextBox.Size = new System.Drawing.Size(198, 33);
            this.userNametextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // LogInFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignupLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNametextBox);
            this.Controls.Add(this.label2);
            this.Name = "LogInFrm";
            this.Text = "LogInFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel SignupLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNametextBox;
        private System.Windows.Forms.Label label2;
    }
}