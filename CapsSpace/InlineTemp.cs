using System;
using System.Linq;

namespace CapsModifier
{
	public partial class InlineTemp
	{
		//`![](CapsSpace;crcommand:OpenFile:CapsSpace.cs;;0.012,0.012) to inline temporary variables.

		public float CalculateDiscountedPrice(float price)
		{
			float percentage = GetCurrentDiscount();
			float fraction = percentage * 0.01f;

			//`      Caps+Space ![](ArrowDown;;;0.008,0.008) to inline this temp (twice if you like):
			return price - fraction * price;
		}
	}
}

//`++Great Work!
/* 
You used Caps+Space to compress/expand:

	* Implicit/Explicit Declarations
	* Expression Bodies
	* Initializers

And you used Caps+Space to inline temporary variables.

![](BtnCapsDeleteTrim;crcommand:OpenFile:CapsDelete.cs;;0.012,0.012)  << Caps+Delete to remove code...                */

