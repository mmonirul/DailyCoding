﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem.Solutions.Common
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> left, Node<T> right): this(value)
        {
            Left = left;
            Right = right;
        }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }

        public T Value { get; set; }

    }
}
