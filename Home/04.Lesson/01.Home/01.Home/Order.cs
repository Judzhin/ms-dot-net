using System;
using System.Collections;

namespace Home
{
	public class Order
	{
		/// <summary>
		/// The _client.
		/// </summary>
		private Client _client;
		/// <summary>
		/// The _commodity.
		/// </summary>
		private CommodityList<Commodity> _commodities;
		/// <summary>
		/// The _count.
		/// </summary>
		private Int32 _count;

		/// <summary>
		/// Initializes a new instance of the <see cref="Home.Order"/> class.
		/// </summary>
		/// <param name="client">Client.</param>
		public Order (Client client)
		{
			//_commodities = new ArrayList ();
			_commodities = new CommodityList<Commodity> ();
			_client = client;	
		}

		/// <summary>
		/// Gets the cost.
		/// </summary>
		/// <value>The cost.</value>
		public double Cost {
			get {
				double result = 0;
				foreach (Commodity commodity in _commodities) {
					_count += commodity.Count;
					result += Convert.ToDouble (commodity.Count) * commodity.Cost;
				}
				return result;
			}
		}

		/// <summary>
		/// Add the specified commodity.
		/// </summary>
		/// <param name="commodity">Commodity.</param>
		public Order add (Commodity commodity)
		{
			_count += commodity.Count;
			_commodities.Add (commodity);
			return this;
		}

		/// <summary>
		/// Returns a <see cref="System.String"/> that represents the current <see cref="Home.Order"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="Home.Order"/>.</returns>
		public override string ToString ()
		{
			return string.Format ("[Order: Client={0}, Commodities={1}, Cost={2}X{3} ]", _client, _commodities.Count, _count, Cost);
		}
	}
}

