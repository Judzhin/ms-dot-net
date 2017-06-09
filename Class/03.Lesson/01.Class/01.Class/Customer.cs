using System;

namespace Class
{
	class Customer
	{
		#region Fileds
		public string lastname;
		private string firstname;
		protected byte age;
		public static int count;
		#endregion
		#region Properties
		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		/// <value>The last name.</value>
		public string LastName {
			get {
				return lastname;
			}
			set {
				lastname = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the firs.
		/// </summary>
		/// <value>The name of the firs.</value>
		public string FirsName {
			get {
				return firstname;
			}
			set {
				firstname = value;
			}
		}

		/// <summary>
		/// Gets or sets the age.
		/// </summary>
		/// <value>The age.</value>
		public byte Age {
			get {
				return age;
			}
			set {
				age = value < 120 ? value : byte.Parse ("0");
			}
		}
		#endregion
		/// <summary>
		/// Initializes the <see cref="Class.Customer"/> class.
		/// </summary>
		static Customer ()
		{
			count = 10;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Class.Customer"/> class.
		/// </summary>
		/// <param name="lastname">Lastname.</param>
		public Customer () : this("first name")
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Class.Customer"/> class.
		/// </summary>
		/// <param name="lastname">Lastname.</param>
		public Customer (string lastname) : this(lastname, "last name")
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Class.Customer"/> class.
		/// </summary>
		/// <param name="lastname">Lastname.</param>
		/// <param name="firstname">Firstname.</param>
		public Customer (string lastname, string firstname) :this(lastname, firstname, 28)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Class.Customer"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="lastname">Lastname.</param>
		/// <param name="age">Age.</param>
		public Customer (string lastname, string firstname, byte age)
		{
			LastName = lastname;
			FirsName = firstname;
			Age = age;
			count++;
		}

		/// <summary>
		/// Returns a <see cref="System.String"/> that represents the current <see cref="Class.Customer"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="Class.Customer"/>.</returns>
		public override string ToString ()
		{
			return string.Format ("[Customer:{0}: LastName={1}, FirsName={2}, Age={3}]", count, LastName, FirsName, Age);
		}
	}
}

