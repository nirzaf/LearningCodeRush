using System;
using System.Linq;

namespace CapsModifier
{
	public class Initializers
	{
		//`![](CapsSpace;crcommand:OpenFile:CapsSpace.cs;;0.012,0.012) to create and decompose initializers.

		public void CreateTestCustomer1()
		{
			//`                  ![](ArrowDown;;;0.008,0.008) Caps+Space to Convert to an Initializer: 
			Customer andrew = new Customer();
			andrew.FirstName = "Andrew";
			andrew.LastName = "Fuller";
			andrew.Age = 48;
			andrew.Ready();
		}

		public void CreateTestCustomer2()
		{
			//`                  ![](ArrowDown;;;0.008,0.008) Caps+Space to Decompose this Initializer: 
			Customer jackson = new Customer() { 
								FirstName = "Jackson", 
								LastName = "Grand", 
								Age = 35 };
			jackson.Ready();
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:InlineTemp.cs;;0.012,0.012) << Inline Temp and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsDelete.cs;;0.012,0.012)  << Skip ahead to the next lesson (Caps+Delete)...
