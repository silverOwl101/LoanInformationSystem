﻿
namespace LoanInformationSystemEmployee
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
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInFrm));
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameGroupBox = new System.Windows.Forms.GroupBox();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.userNameTextBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(64, 49);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(409, 37);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.userNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTxt_KeyPress);
            // 
            // usernameGroupBox
            // 
            this.usernameGroupBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameGroupBox.Location = new System.Drawing.Point(52, 20);
            this.usernameGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameGroupBox.Name = "usernameGroupBox";
            this.usernameGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameGroupBox.Size = new System.Drawing.Size(437, 81);
            this.usernameGroupBox.TabIndex = 2;
            this.usernameGroupBox.TabStop = false;
            this.usernameGroupBox.Text = "Username";
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordTextBox.Location = new System.Drawing.Point(64, 135);
            this.passWordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.PasswordChar = '*';
            this.passWordTextBox.Size = new System.Drawing.Size(409, 37);
            this.passWordTextBox.TabIndex = 1;
            this.passWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passWordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTxt_KeyPress);
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordGroupBox.Location = new System.Drawing.Point(52, 106);
            this.passwordGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordGroupBox.Size = new System.Drawing.Size(437, 80);
            this.passwordGroupBox.TabIndex = 4;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Password";
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(352, 206);
            this.logInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(137, 54);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log-in";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LogInFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(544, 273);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(this.passwordGroupBox);
            this.Controls.Add(this.usernameGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "LogInFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Information System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.GroupBox usernameGroupBox;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.Button logInButton;
    }
}

