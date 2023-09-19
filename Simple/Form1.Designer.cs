namespace Simple
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPW = new TextBox();
            txtID = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPW);
            panel1.Controls.Add(txtID);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 213);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(237, 156);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 5;
            button1.Text = "signup";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(107, 155);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 33);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // label2
            // 
            label2.Location = new Point(56, 104);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 3;
            label2.Text = "PW";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(56, 47);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 2;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPW
            // 
            txtPW.Location = new Point(107, 104);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(224, 23);
            txtPW.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(107, 47);
            txtID.Name = "txtID";
            txtID.Size = new Size(224, 23);
            txtID.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 213);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox txtPW;
        private TextBox txtID;
        private Button button1;
    }
}