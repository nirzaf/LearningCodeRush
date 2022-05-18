using System;
using System.Linq;

namespace CapsModifier
{
	public partial class ExpressionBodies
	{
		//`![](CapsSpace;crcommand:OpenFile:CapsSpace.cs;;0.012,0.012) converts between normal and expression bodies.


		public string Name
		{
			//`![](ArrowDown;;;0.008,0.008) Caps+Space to toggle between accessor and expression bodies. 
			get
			{
				return name;
			}

			//`![](ArrowDown;;;0.008,0.008) Caps+Space to toggle between accessor and expression bodies.
			set => name = value;
		}


		//`![](ArrowDown;;;0.008,0.008) Caps+Space to toggle again... 
		public bool AllGood => GetState();


		//`![](ArrowDown;;;0.008,0.008) Press Caps+Space to use an expression body for this method:
		internal bool AllStarted()
		{
			return started;
		}


		//`![](ArrowDown;;;0.008,0.008) Press Caps+Space to expand this expression body into a property body:
		public bool WeHaveIssues => !GetState();


		//`![](ArrowDown;;;0.008,0.008) Press Caps+Space to expand this expression body into a method body:
		internal bool GetStarted() => started;


		internal int Fibonacci(int n)
		{
			if (n < 0)
				throw new ArgumentOutOfRangeException(nameof(n), "n must be greater than or equal to zero.");
			return Fib(n);

			//`![](ArrowDown;;;0.008,0.008) Caps+Space to expand (or compress) this local function: 
			int Fib(int n) => n < 2 ? n : Fib(n - 1) + Fib(n - 2);
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:Initializers.cs;;0.012,0.012) << Initializers and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsDelete.cs;;0.012,0.012)  << Skip ahead to the next lesson (Caps+Delete)...
