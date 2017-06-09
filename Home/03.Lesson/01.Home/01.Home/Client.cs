/// <summary>
/// Client.
/// </summary>
using System;

/// <summary>
/// Client.
/// </summary>
namespace Home
{
	/// <summary>
	/// Client.
	/// </summary>
	class Client
	{

		#region Fields
		/// <summary>
		/// The username.
		/// </summary>
		string _username;
		/// <summary>
		/// The surname.
		/// </summary>
		string _surname;
		/// <summary>
		/// The number.
		/// </summary>
		string _number;
		/// <summary>
		/// The _age.
		/// </summary>
		byte _age;
		/// <summary>
		/// The count.
		/// </summary>
		static int count;
		#endregion
		#region Construct
		/// <summary>
		/// Client this instance.
		/// </summary>
		public Client () : this ("Some Username")
		{
		}

		/// <summary>
		/// Client the specified username.
		/// </summary>
		/// <param name="username">Username.</param>
		public Client (string username) : this(username, "Some Surname")
		{
		}

		/// <summary>
		/// Client the specified username and surname.
		/// </summary>
		/// <param name="username">Username.</param>
		/// <param name="surname">Surname.</param>
		public Client (string username, string surname) : this(username, surname, "Some Number")
		{
		}

		/// <summary>
		/// Client the specified username, surname and number.
		/// </summary>
		/// <param name="username">Username.</param>
		/// <param name="surname">Surname.</param>
		/// <param name="number">Number.</param>
		public Client (string username, string surname, string number) : this(username, surname, number, (byte) 0 )
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Home.Client"/> class.
		/// </summary>
		/// <param name="username">Username.</param>
		/// <param name="surname">Surname.</param>
		/// <param name="number">Number.</param>
		/// <param name="age">Age.</param>
		public Client (string username, string surname, string number, byte age)
		{
			Username = username;
			Surname = surname;
			Number = number;
			Age = age;
			count++;
		}
		#endregion
		/// <summary>
		/// Returns a <see cref="System.String"/> that represents the current <see cref="Home.Client"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="Home.Client"/>.</returns>
		public override string ToString ()
		{
			return string.Format ("[Client:{0}: Username={1}, Surname={2}, Number={3}, Age={4}]", count, _username, _surname, _number, _age);
		}

		/// <summary>
		/// Gets or sets the username.
		/// </summary>
		/// <value>The username.</value>
		public string Username {
			get {
				return _username; 
			}
			set {
				_username = value;
			} 
		}

		/// <summary>
		/// Gets or sets the surname.
		/// </summary>
		/// <value>The surname.</value>
		public string Surname {
			get {
				return _surname;
			} 
			set {
				_surname = value;
			}
		}

		/// <summary>
		/// Gets or sets the number.
		/// </summary>
		/// <value>The number.</value>
		public string Number {
			get {
				return _number;
			} 
			set {
				_number = value;
			}
		}

		/// <summary>
		/// Gets or sets the age.
		/// </summary>
		/// <value>The age.</value>
		public byte Age {
			get {
				return _age;
			} 
			set {
				_age = value;
			}
		}
	}
}

