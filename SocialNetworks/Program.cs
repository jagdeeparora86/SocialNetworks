using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworks
{
	class Program
	{
		static void Main(string[] args)
		{

			QuickFind qf = new QuickFind(5);

			int frd1, frd2;
			frd1 = 1;
			frd2 = 4;
			qf.connect(frd1, frd2);
			if (qf.isOneGrandRoot())
				Console.Write("All frds were now connected at timestamp equivalence to " + frd1 + ", " + frd2 + "Friendship");

			frd1 = 0; frd2 = 2;
			qf.connect(frd1, frd2);
			if (qf.isOneGrandRoot())
				Console.Write("All frds were now connected at timestamp equivalence to " + frd1 + ", " + frd2 + "Friendship");

			frd1 = 0; frd2 = 3;
			qf.connect(frd1, frd2);
			if (qf.isOneGrandRoot())
				Console.Write("All frds were now connected at timestamp equivalence to " + frd1 + ", " + frd2 + "Friendship");

			frd1 = 2; frd2 = 4;
			qf.connect(frd1, frd2);
			if (qf.isOneGrandRoot())
				Console.Write("All frds were now connected at timestamp equivalence to " + frd1 + ", " + frd2 + "Friendship");

		}
	}
}
