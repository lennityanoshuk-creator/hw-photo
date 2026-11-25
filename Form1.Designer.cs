namespace hw22
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
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            txtUsername = new TextBox();
            btnRegister = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(512, 256);
            button1.Name = "button1";
            button1.Size = new Size(170, 41);
            button1.TabIndex = 0;
            button1.Text = "Вибрати фото";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 1;
            label1.Text = "Введіть ім'я";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(471, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 222);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 54);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(324, 27);
            txtUsername.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(298, 376);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(170, 41);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Зареєструватись";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(324, 27);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 207);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(324, 27);
            txtPassword.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 7;
            label2.Text = "Введіть свій email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(163, 28);
            label3.TabIndex = 8;
            label3.Text = "Введіть пароль";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnRegister);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private TextBox txtUsername;
        private Button btnRegister;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
    }
}
