namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Butonun üzerine gelindi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona Tıklandı");
        }

       
    }
}