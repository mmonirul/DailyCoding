using System;
using System.Collections.Generic;
using System.Threading;

namespace DailyCodingProblem.Solutions.Problem11
{
    public class Trie
    {
        private class Node
        {
            public Node()
            {
                Children = new Dictionary<char, Node>();
            }

            public Node(char value): this()
            {
                Character = value;
            }

            public Dictionary<char, Node> Children { get; private set; }
            public char? Character { get; set; }
            public string Text { get; set; }
        }
        private readonly Node root = new Node();

        public void Add(string text)
        {
            var currentNode = root;
            foreach (var current in text)
            {
                if (!currentNode.Children.ContainsKey(current))
                {
                    var newNode = new Node(current);
                    currentNode.Children.Add(current, newNode);
                }

                currentNode = currentNode.Children[current];
            }

            currentNode.Text = text;
        }
        public IEnumerable<string> Search(string queryString)
        {
            var node = this.Find(queryString);

            var result = this.GetTexts(node);

            return result;
        }

        private IEnumerable<string> GetTexts(Node node)
        {
            var result = new List<string>();

            if (node == null) return result;

            if (!string.IsNullOrEmpty(node.Text))
            {
                result.Add(node.Text);
            }

            foreach (var kvp in node.Children)
            {
                result.AddRange(GetTexts(kvp.Value));
            }
            return result;
        }

        private Node Find(string queryString)
        {
            var currentNode = root;

            foreach (var current in queryString)
            {
                if (currentNode.Children.ContainsKey(current))
                {
                    currentNode = currentNode.Children[current];
                }
                else
                {
                    return null;
                }
            }

            return currentNode;
        }
    }
}
