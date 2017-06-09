/// <summary>
/// Commodity.
/// </summary>
using System;
/// <summary>
/// Сommodity.
/// </summary>
namespace Home
{
	/// <summary>
	/// Сommodity.
	/// </summary>
	public class Commodity
	{
	
		/// <summary>
		/// The _name.
		/// </summary>
		private string _name;
		/// <summary>
		/// The _cost.
		/// </summary>
		private double _cost;
		/// <summary>
		/// The _count.
		/// </summary>
		private Int32 _count;
		/// <summary>
		/// The _availability.
		/// </summary>
		private AvailabilityType _availability;

		/// <summary>
		/// Initializes a new instance of the <see cref="Home.Сommodity"/> class.
		/// </summary>
		public Commodity () : this("Some Commodity name")
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Home.Сommodity"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		public Commodity (string name) : this(name, 0.00)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Home.Сommodity"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="cost">Cost.</param>
		public Commodity (string name, double cost) : this(name, cost, 0)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Home.Сommodity"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="cost">Cost.</param>
		/// <param name="count">Count.</param>
		public Commodity (string name, double cost, Int32 count)
		{
			Name = name;
			Cost = cost;
			Count = count;
		}

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name {
			get {
				return _name;
			}
			set {
				_name = value;
			}
		}

		/// <summary>
		/// Gets or sets the cost.
		/// </summary>
		/// <value>The cost.</value>
		public double Cost {
			get {
				return _cost;
			}
			set {
				_cost = value;
			}
		}

		/// <summary>
		/// Gets or sets the count.
		/// </summary>
		/// <value>The count.</value>
		public Int32 Count {
			get {
				return _count;
			}
			set {
				_count = value;

				if (0 < _count) {
					Availability = AvailabilityType.InStock;
				} else if (0 > _count) {
					Availability = AvailabilityType.UnderTheOrder;
				} else {
					Availability = AvailabilityType.NotAvailable;
				}
			}
		}

		/// <summary>
		/// Gets or sets the availability.
		/// </summary>
		/// <value>The availability.</value>
		public AvailabilityType Availability {
			get {
				return _availability;
			}
			set {
				_availability = value;
			}
		}

		/// <summary>
		/// Returns a <see cref="System.String"/> that represents the current <see cref="Home.Сommodity"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="Home.Сommodity"/>.</returns>
		public override string ToString ()
		{
			return string.Format ("[Сommodity: Name={0}, Cost={1}, Count={2}, Availability={3}]", Name, Cost, Count, (AvailabilityType)Availability);
		}
	}
}

