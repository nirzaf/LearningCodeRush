using System;

namespace CapsModifier
{
	public class Book
	{
		public Book(string title, string author, DateTime addDate)
		{
			Title = title;
			Author = author;
			AddDate = addDate;
		}
		public DateTime AddDate { get; set; }
		public string Author { get; set; }
		public string Title { get; set; }
	}
}
