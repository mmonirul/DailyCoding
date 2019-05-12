using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem06
{
    public class InMemoryLinkedList<T>
    {
        private readonly IDictionary<int, Node> _memory = new Dictionary<int, Node>();
        private int _memoryAddress = 1;

        private class Node
        {
            public int Address { get; set; }

            public int Both { get; set; }

            public T Value { get; set; }
        }

        private Node _head;

        public void Add(T element)
        {
            if (_head == null)
            {
                _head = new Node
                {
                    Value = element,
                    Both = 0 ^ 0,
                    Address = _memoryAddress
                };

                _memory.Add(_head.Address, _head);
            }
            else
            {
                Node current = _head;
                Node previous = null;

                while (true)
                {
                    int currentAddress = (current.Both ^ (previous?.Address ?? 0));

                    if (currentAddress == 0)
                    {
                        break;
                    }

                    previous = current;
                    current = _memory[currentAddress];
                }

                Node node = new Node
                {
                    Value = element,
                    Both = 0 ^ current.Address,
                    Address = _memoryAddress
                };

                current.Both = (node.Address ^ (previous?.Address ?? 0));

                _memory.Add(node.Address, node);
            }

            _memoryAddress++;
        }

        public T Get(int index)
        {
            Node current = _head;
            Node previous = null;

            for (int i = 0; i < index; i++)
            {
                int nextAddress = (current.Both ^ (previous?.Address ?? 0));

                previous = current;

                if (!_memory.ContainsKey(nextAddress))
                {
                    return default(T);
                }

                current = _memory[nextAddress];
            }

            return current.Value;
        }
    }
}
