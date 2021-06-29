namespace algolibrary.MyTree
{
	public class MyNode
	{
		public MyNode left;
		public MyNode right;

		public MyNode()
		{
			left = new MyNode();
			right = new MyNode();
		}
	}
}
