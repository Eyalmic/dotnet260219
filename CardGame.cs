using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2602
{
	class Program
	{
		static void Main(string[] args)
		{
			Random engine = new Random();
			int myscore = 0;
			int pcscore = 0;

			// get new card
			int mycard = engine.Next(2, 15);


			do
			{
				// print card
				switch (mycard)
				{
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
						Console.WriteLine(mycard);
						break;
					case 11:
						Console.WriteLine("J");
						break;
					case 12:
						Console.WriteLine("Q");
						break;
					case 13:
						Console.WriteLine("K");
						break;
					case 14:
						Console.WriteLine("A");
						break;
					default:
						Console.WriteLine("Bad card!!!!!!!!!!!");
						break;
				}

				Thread.Sleep(1000);

				// get new card
				int computercard = engine.Next(2, 15);
				// print card
				switch (computercard)
				{
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
						Console.WriteLine(computercard);
						break;
					case 11:
						Console.WriteLine("J");
						break;
					case 12:
						Console.WriteLine("Q");
						break;
					case 13:
						Console.WriteLine("K");
						break;
					case 14:
						Console.WriteLine("A");
						break;
					default:
						Console.WriteLine("Bad card!!!!!!!!!!!");
						break;
				}

				Thread.Sleep(500);

				if (mycard > computercard)
				{
					Console.WriteLine("I won this round!!!!");
					myscore++;
					Console.WriteLine($"PC: {pcscore} , Player: {myscore} ");
				}
				else if (computercard > mycard)
				{
					Console.WriteLine("Computer won ... booooo");
					pcscore++;
					Console.WriteLine($"PC: {pcscore} , Player: {myscore} ");
				}
				else
				{
					Console.WriteLine("Tie!");
					Console.WriteLine($"PC: {pcscore} , Player: {myscore} ");
				}
			}
			while (myscore < 5 && pcscore < 5);
			Console.WriteLine($"Game over! Player:{myscore} PC: {pcscore}");
			if(myscore>pcscore)
			{
				Console.WriteLine("YOU WIN!");
			}
			else
			{
				Console.WriteLine("PC WINS! boooooo!");
			}
		}

	}
}
