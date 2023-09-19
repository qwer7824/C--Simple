namespace Simple
{
    partial class Form3
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
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPW = new TextBox();
            txtID = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(194, 167);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 33);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Sign-up";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.Location = new Point(100, 113);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 8;
            label2.Text = "PW";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(100, 56);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 7;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPW
            // 
            txtPW.Location = new Point(151, 113);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(224, 23);
            txtPW.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(151, 56);
            txtID.Name = "txtID";
            txtID.Size = new Size(224, 23);
            txtID.TabIndex = 5;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 257);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox txtPW;
        private TextBox txtID;
    }
}