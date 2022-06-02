using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork
{
	class Node<T> : IComparable<T>, IComparable
		  where T : IComparable<T>, IComparable
	{
		public T Data { get; private set; }
		public Node<T> Left { get; private set; }
		public Node<T> Right { get; private set; }

		public Node(T data)
		{
			Data = data;
		}
		public List<T> Preorder(Node<T> node)
		{

			var list = new List<T>();
			if (node != null)
			{
				list.Add(node.Data);

				if (node.Left != null)
				{
					list.AddRange(Preorder(node.Left));
				}

				if (node.Right != null)
				{
					list.AddRange(Preorder(node.Right));
				}
			}

			return list;
		}
		public Node<T> GetNodeByValuee(T data)
		{
			var list = new Node<T>(data);
			if (Data.CompareTo(data) == -1)
			{
				if (Right.Data.CompareTo(data) == 0)
				{
					foreach (var item in Preorder(Right))
					{

						if (item.CompareTo(Right.Data) == 0)
							continue;
						Console.Write(item + ", ");
					}

				}
				else
				{
					Right.GetNodeByValuee(data);
				}
			}

			else if (Data.CompareTo(data) == 1)
			{
				if (Left.Data.CompareTo(data) == 0)
				{
					foreach (var item in Preorder(Left))
					{

						if (item.CompareTo(Left.Data) == 0)
							continue;
						Console.Write(item + ", ");
					}

				}
				else
				{
					Left.GetNodeByValuee(data);
				}
			}
			else
			{
				if (Data.CompareTo(data) == 0)
				{
					Tree<T> tree = new Tree<T>();
					var lisst = new Node<T>(Data);

					foreach (var item in Preorder(Left))
					{
						Console.Write("Корен");
					}
				}
			}

			return list;
		}

		public void Add(T data)
		{

			var node = new Node<T>(data);

			if (node.Data.CompareTo(Data) == -1)
			{
				if (Left == null)
				{
					Left = node;
				}
				else
				{
					Left.Add(data);
				}
			}
			else
			{
				if (Right == null)
				{
					Right = node;
				}
				else
				{
					Right.Add(data);
				}
			}
		}

		public void Delete(T data)
		{

			if (Data.CompareTo(data) == -1)
			{
				if (Right.Data.CompareTo(data) == 0)
				{
					if (Right.Right == null && Right.Left == null)
					{
						Right = null;
					}
					else
					{
						Console.WriteLine("Нельзя удалит");
					}
				}
				else
				{
					Right.Delete(data);
				}
			}
			else if (Data.CompareTo(data) == 1)
			{

				if (Left.Data.CompareTo(data) == 0)
				{
					if (Left.Right == null && Left.Left == null)
					{
						Left = null;
					}
					else
					{
						Console.WriteLine("Нельзя удалит");
					}
				}
				else
				{
					Right.Delete(data);

				}
			}
			else
			{
				Console.WriteLine("Нелзя удалить корен ");
				return;
			}

		}

		public int CompareTo(object obj)
		{
			if (obj is Node<T> item)
			{
				return Data.CompareTo(item);
			}
			else
			{
				throw new ArgumentException("Не совпадение типов");
			}
		}

		public int CompareTo(T other)
		{
			return Data.CompareTo(other);
		}

		public override string ToString()
		{
			return Data.ToString();
		}
	}
}
