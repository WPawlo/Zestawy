using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace huffman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            var frequencyMap = inputText.GroupBy(ch => ch).ToDictionary(group => group.Key, group => group.Count());
            var rootNode = HuffmanTree.BuildTree(frequencyMap);
            var codeMap = new Dictionary<char, string>();
            HuffmanTree.GenerateCodes(rootNode, "", codeMap);
            var encodedText = HuffmanTree.Encode(inputText, codeMap);
            label2.Text = string.Join("\n", codeMap.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
            var decodedText = HuffmanTree.Decode(encodedText, rootNode);
            label3.Text = decodedText;
        }
    }

    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int data;
        public char? symbol;
    }

    public static class HuffmanTree
    {
        public static TreeNode BuildTree(Dictionary<char, int> frequencyMap)
        {
            var nodeList = frequencyMap.Select(kvp => new TreeNode { symbol = kvp.Key, data = kvp.Value }).ToList();

            while (nodeList.Count > 1)
            {
                nodeList = nodeList.OrderBy(node => node.data).ToList();
                var leftNode = nodeList[0];
                var rightNode = nodeList[1];

                var parentNode = new TreeNode
                {
                    left = leftNode,
                    right = rightNode,
                    data = leftNode.data + rightNode.data,
                    symbol = null
                };

                nodeList.RemoveRange(0, 2);
                nodeList.Add(parentNode);
            }

            return nodeList[0];
        }

        public static void GenerateCodes(TreeNode node, string currentCode, Dictionary<char, string> codeMap)
        {
            if (node == null) return;

            if (node.symbol != null)
            {
                codeMap[node.symbol.Value] = currentCode;
            }

            GenerateCodes(node.left, currentCode + "0", codeMap);
            GenerateCodes(node.right, currentCode + "1", codeMap);
        }

        public static string Encode(string input, Dictionary<char, string> codeMap)
        {
            return string.Concat(input.Select(ch => codeMap[ch]));
        }

        public static string Decode(string encodedText, TreeNode rootNode)
        {
            var decodedText = "";
            var currentNode = rootNode;

            foreach (var bit in encodedText)
            {
                currentNode = bit == '0' ? currentNode.left : currentNode.right;

                if (currentNode.symbol != null)
                {
                    decodedText += currentNode.symbol;
                    currentNode = rootNode;
                }
            }

            return decodedText;
        }
    }
}
