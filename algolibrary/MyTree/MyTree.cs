using algolibrary.MyTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace algoLibrary.MyTree
{
	public class MyTree
	{
		public MyNode Root { get; set; }

		public bool Add(int value)
		{

			MyNode preservedNode = null, subNode = this.Root; // why do we even call this left and right since this look like temp variables.

			while (subNode != null)
			{
				preservedNode = subNode;

				if (value < subNode.Data)
				{
					subNode = subNode.Left;
				}
				else if (value > subNode.Data)
				{
					subNode = subNode.Right;
				}
				else return false;
			}

			MyNode newNode = new MyNode();
			newNode.Data = value;

			if (this.Root == null)
			{
				this.Root = newNode;
			}
			else
			{
				if (value < preservedNode.Data)
				{
					preservedNode.Left = newNode;
				}
				else if (value > preservedNode.Data)
				{
					preservedNode.Right = newNode;
				}
			}
			return true;
		}
	}
}
