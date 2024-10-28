namespace making_list
{
    public partial class Form1 : Form
    {
        private List list;
        public Form1()
        {
            InitializeComponent();
            list = new List();
        }

        private void przycisk1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                list.addFirst(number);
                label1.Text = "Lista: {" + list.ToString() + "}";
            }
            else
            {
                MessageBox.Show("To nie jest liczba");
            }
            textBox1.Clear();
        }

        private void przycisk2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                list.addLast(number);
                label1.Text = "Lista: {" + list.ToString() + "}";
            }
            else
            {
                MessageBox.Show("To nie jest liczba");
            }
            textBox1.Clear();
        }

        private void przycisk3_Click(object sender, EventArgs e)
        {
            list.removeFirst();
            label1.Text = "Lista: {" + list.ToString() + "}";
        }

        private void przycisk4_Click(object sender, EventArgs e)
        {
            list.removeLast();
            label1.Text = "Lista: {" + list.ToString() + "}";
        }
    }
}
