using System;
using System.Linq;

namespace CapsModifier
{
	public abstract partial class FlattenConditionals
	{
		public abstract void Start();
		public abstract void ReadData();
		public abstract void Draw();
		public abstract void DoMoreWork();
		public abstract void FinishDrawing();
	}
}

