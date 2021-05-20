using System;
using System.Collections.Generic;
using Gridnine.FlightCodingTest.Manager.Base;

namespace Gridnine.FlightCodingTest.Manager
{
	class FilterManager
	{
		private List<IFilter> Filters { get; set; }

		public FilterManager()
		{
			Filters = new List<IFilter>();
		}

		public void Process(IList<Flight> flights)
		{
			foreach (var flight in flights)
			{
				bool result = true;
				foreach (var filter in Filters)
					if (!filter.Filtrate(flight))
						result = false;
				if (result)

					Console.WriteLine("Отправление - " + flight.Segments[0].DepartureDate + " : " + "Прибытие - " +
					                  flight.Segments[0].ArrivalDate);
			}
		}

		public void AddFilter(IFilter filter)
		{
			Filters.Add(filter);
		}
	}
}