using System;
using System.Linq;

namespace CapsModifier
{
	public partial class InlineLambda
	{
		public delegate void RoutedEventHandler(object sender, RoutedEventArgs ea);
		public event RoutedEventHandler Loaded;
		void InitializeComponent()
		{
			throw new NotImplementedException();
		}
	}
}

