﻿namespace practic_avtoriz_win_forms
{
    partial class FormAvtoriz
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.buttonRegistr = new System.Windows.Forms.Button();
            this.labelRegistr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(265, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(265, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Логин";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(270, 230);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(242, 20);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(270, 170);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(242, 20);
            this.textBoxLogin.TabIndex = 10;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(780, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(22, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // buttonRegistr
            // 
            this.buttonRegistr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistr.Location = new System.Drawing.Point(270, 273);
            this.buttonRegistr.Name = "buttonRegistr";
            this.buttonRegistr.Size = new System.Drawing.Size(242, 41);
            this.buttonRegistr.TabIndex = 8;
            this.buttonRegistr.Text = "Войти";
            this.buttonRegistr.UseVisualStyleBackColor = false;
            this.buttonRegistr.Click += new System.EventHandler(this.buttonAvtoriz_Click);
            // 
            // labelRegistr
            // 
            this.labelRegistr.AutoSize = true;
            this.labelRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistr.Location = new System.Drawing.Point(309, 328);
            this.labelRegistr.Name = "labelRegistr";
            this.labelRegistr.Size = new System.Drawing.Size(171, 20);
            this.labelRegistr.TabIndex = 15;
            this.labelRegistr.Text = "Еще нет аккаунта?";
            this.labelRegistr.Click += new System.EventHandler(this.labelRegistr_Click);
            // 
            // FormAvtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRegistr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.buttonRegistr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAvtoriz";
            this.Text = "FormAvtoriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button buttonRegistr;
        private System.Windows.Forms.Label labelRegistr;
    }
}