using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopLight
{
	class Program
	{
		enum TrafficLight {
			Red,Green,Yellow
		};
		void DisplayTrafficLight(TrafficLight colorIdx)
		{
			switch (colorIdx) {
				case TrafficLight.Red:
					Console.WriteLine("Red");
					break;
				case TrafficLight.Green:
					Console.WriteLine("Green");
					break;
				case TrafficLight.Yellow:
					Console.WriteLine("Yellow");
					break;
			}
		}
		void run() {
			for (int idx = 0; idx < 3; idx++) {
				int colorIdx = 1;//red
				TrafficLight color = (TrafficLight)colorIdx;
				DisplayTrafficLight(color);
				color = (TrafficLight)(++colorIdx);
				DisplayTrafficLight(color);
				color = (TrafficLight)(++colorIdx);
				DisplayTrafficLight(color);
			}

		}

		static void Main(string[] args)
		{
			(new Program()).run();
		}
	}
}
