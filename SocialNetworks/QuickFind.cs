using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworks
{
	class QuickFind
	{
		int[] id;
		int[] sz;
		int numberOfRoots;

		//constructor to create the array with value of it's own index
		public QuickFind(int N)
		{
			id = new int[N];
			sz = new int[N];

			for (int i = 0; i < N; i++)
			{
				id[i] = i;
				sz[i] = 1;
			}

			numberOfRoots = N;
		}

		//Method to check if it's connected
		public bool connected(int p, int q)
		{
			return root(p) == root(q);
		}

		//Method to create roots in the array
		private int root(int value)
		{
			while (value != id[value])
			{
				// this is making the value to connect to the grandparent of root so the tree is not too big
				id[value] = id[id[value]];
				value = id[value];
			}
			return value;

		}

		public bool isOneGrandRoot()
		{
			return numberOfRoots == 1;
		}

		public void connect(int p, int q)
		{
			int rootp = root(p);
			int rootq = root(q);

			if (rootp == rootq)
				return;

			if (sz[p] <= sz[q])
			{
				id[p] = id[q];
				sz[q] += sz[p];
				numberOfRoots--;
			}
			else
			{
				id[q] = id[p];
				sz[p] += sz[q];
				numberOfRoots--;
			}

		}


	
	}
}
