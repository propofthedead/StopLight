using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopLight
{
	class Program
	{
		void DisplayTrafficLight(int color)
		{
			switch (color) {
				case 1:
					Console.WriteLine("Red");
					break;
				case 2:
					Console.WriteLine("Green");
					break;
				case 3:
					Console.WriteLine("Yellow");
					break;
			}
		}
		void run() {
			for (int idx = 0; idx < 3; idx++) {
				int color = 1;//red
				DisplayTrafficLight(color);
				DisplayTrafficLight(++color);
			}

		}

		static void Main(string[] args)
		{
			(new Program()).run();
		}
	}
}
