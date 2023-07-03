using System;
using System.Windows.Forms;

namespace Flight_Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text);
            listBox1.Items.Add("Tarih ve Saat: " + dateTimePicker1.Text + "-" + maskedTextBox1.Text);
            listBox1.Items.Add("Yolcu Ad Soyad: " + textBox1.Text);

            listBox1.Items.Add("Yolcu Telefon ve TC :" + maskedTextBox3.Text + "-" + maskedTextBox2.Text);

            MessageBox.Show("Yolcu Başarıyla Kaydedildi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}