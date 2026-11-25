using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace hw22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyDesign();
        }

        private void ApplyDesign()
        {
            this.Text = "Реєстрація";
            this.BackColor = Color.FromArgb(241, 245, 249);
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            txtPassword.UseSystemPasswordChar = true;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.FromArgb(226, 232, 240);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;

            button1.BackColor = Color.FromArgb(37, 99, 235);
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            btnRegister.BackColor = Color.FromArgb(22, 163, 74);
            btnRegister.ForeColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Зображення (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.Title = "Оберіть фото профілю";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                    using (var img = Image.FromStream(fs))
                    {
                        pictureBox1.Image?.Dispose();
                        pictureBox1.Image = new Bitmap(img);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося відкрити фото: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Заповніть усі поля!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                $"Акаунт «{txtUsername.Text}» створено!" +
                (pictureBox1.Image != null ? "\nФото профілю додано." : "\nБез фото."),
                "Успіх",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}