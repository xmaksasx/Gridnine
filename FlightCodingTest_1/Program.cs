using System;
using Gridnine.FlightCodingTest.Manager;
using Gridnine.FlightCodingTest.Manager.Filters;


namespace Gridnine.FlightCodingTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("1. Вылет до текущего момента времени");
			Console.WriteLine("2. Сегмент с датой прилёта раньше даты вылета");
			Console.WriteLine("3. Общее время, проведённое на земле превышает два часа");
			Console.WriteLine("-------------------------------------------------------");

			while (true)
			{
				FilterManager filterManager = new FilterManager();

				Console.WriteLine("Добавить номер фильтров через пробел или 0 для выбора всех фильтров");

				var commands = Console.ReadLine()?.Split(' ');

				foreach (var command in commands)
				{
					switch (command)
					{
						case "1":
							filterManager.AddFilter(new FilterNowTime(DateTime.Now));
							break;
						case "2":
							filterManager.AddFilter(new FilterDepartsBeforeArrives());
							break;
						case "3":
							filterManager.AddFilter(new FilterOverHoursOnGround(2));
							break;
						case "0":
							filterManager.AddFilter(new FilterNowTime(DateTime.Now));
							filterManager.AddFilter(new FilterDepartsBeforeArrives());
							filterManager.AddFilter(new FilterOverHoursOnGround(2));
							break;
					}
				}

				FlightBuilder flightBuilder = new FlightBuilder();
				var flights = flightBuilder.GetFlights();

				filterManager.Process(flights);
				Console.WriteLine("******************************************************\r\n");
			}
		}
	}
}
