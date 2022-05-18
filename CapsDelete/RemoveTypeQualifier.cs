using System;
using System.Collections.Generic;
using System.Linq;

namespace CapsModifier
{
	//`![](CapsPlusDelete;crcommand:OpenFile:CapsDelete.cs;;0.012,0.012) removes redundant type qualifiers.

	public class RemoveTypeQualifier
	{
		internal string GetSymbolName(ISymbol symbol)
		{
			// Caps+Delete to remove this redundant type qualifier:
			//`                  ![](ArrowDown;;;0.008,0.008)
			if (symbol is CapsModifier.IMethodSymbol _)
				return symbol.Name;

			return null;
		}

		public string GetImageFolder()
		{
			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			string folder = assembly.Location;
			return System.IO.Path.Combine(folder, "Images");
		}

		public RemoveTypeQualifier()
		{

		}

		//`![](BtnRemoveAllTypeQualifiers;crcommand:OpenFile:RemoveAllTypeQualifiers.cs;;0.012,0.012) << Bonus shortcut - Use Shift+Caps+Delete!
	}


	//`![](BtnMoreLikeThis;crcommand:OpenFile:RemoveUnusedMember.cs;;0.012,0.012) << Remove Unused Member and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsInsert.cs;;0.012,0.012)  << Skip ahead to the next lesson (Caps+Insert)...
