using System.Windows.Forms;

namespace BST
{
    public partial class Form1 : Form
    {
        private List.BinarySearchTree bst = new List.BinarySearchTree();
        private List list = new List();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                bst.Add(number);
                DisplayBST();
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                bst.Remove(number);
                DisplayBST();
            }
            textBox1.Clear();
        }
        private void DisplayBST()
        {
            listBox1.Items.Clear();
            DisplayBSTInOrder(bst.root);
        }
        private void DisplayBSTInOrder(List.NodeT node)
        {
            if (node != null)
            {
                DisplayBSTInOrder(node.left);
                listBox1.Items.Add(node.data);
                DisplayBSTInOrder(node.right);
            }
        }
    }
}
