using System;
using System.Linq;

namespace CapsModifier
{
	//`![](CapsPlusDelete;crcommand:OpenFile:CapsDelete.cs;;0.012,0.012) removes unused members.

	public class RemoveUnusedMember
	{
		// Caps+Delete to remove the unused member:
		//`     ![](ArrowDown;;;0.008,0.008)
		void Button1_Clicked(object sender, EventArgs ea)
		{
			if (sender == null || ea == null)
				return;
		}

		public bool Started { get; set; }
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:RemoveUnusedParameter.cs;;0.012,0.012) << Remove Unused Parameter and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsInsert.cs;;0.012,0.012)  << Skip ahead to the next lesson (Caps+Insert)...
