
namespace Menu
{
    partial class Form1
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
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.passBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(480, 69);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(204, 59);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(478, 164);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(205, 47);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.UseWaitCursor = true;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(480, 255);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(202, 74);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Change password";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // nameBox1
            // 
            this.nameBox1.Location = new System.Drawing.Point(67, 73);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(181, 22);
            this.nameBox1.TabIndex = 3;
            // 
            // passBox2
            // 
            this.passBox2.Location = new System.Drawing.Point(65, 132);
            this.passBox2.Name = "passBox2";
            this.passBox2.Size = new System.Drawing.Size(182, 22);
            this.passBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passBox2);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.TextBox passBox2;
    }
}

