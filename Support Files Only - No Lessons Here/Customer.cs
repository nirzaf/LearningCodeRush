using System;

namespace CapsModifier
{
	public class Customer
	{
		private DateTime creationTime;

		public string FirstName { get; set; }
		public Guid Id { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public void Ready()
		{
			creationTime = DateTime.Now;
		}
	}
}
