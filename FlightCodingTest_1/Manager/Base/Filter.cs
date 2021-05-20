namespace Gridnine.FlightCodingTest.Manager.Base
{
	public abstract class Filter: IFilter
	{
		public virtual bool Filtrate(Flight flight)
		{
			throw new System.NotImplementedException();
		}

	}
}
