using System;

namespace CapsModifier
{
	public partial class RemoveUnusedParameter
	{
		//`![](CapsPlusDelete;crcommand:OpenFile:CapsDelete.cs;;0.012,0.012) removes unused parameters.

		public void CallMethod()
		{	//`                         ![](LookHere;;;0.012,0.012) Look here when you try the next one.
			GetSymbolName(null, "Yo yo yo", DateTime.Now);
		}

		//`                        Caps+Delete ![](ArrowDown;;;0.008,0.008) to remove the unused parameter (undo/redo to see changes):
		string GetSymbolName(ISymbol symbol, string unusedMessage, DateTime requestTime)
		{
			prioritizeNextTask = (DateTime.Now - requestTime).TotalSeconds > 5;

			if (symbol is IMethodSymbol _)
				return symbol.Name;

			return null;
		}
	}
}


	//`++Great Work!

	/* 
	You used Caps+Delete to remove unnecessary or unused code, including:

		* Type Qualifiers
		* All Type Qualifiers (with Shift+Caps+Delete)
		* Unused Members
		* Unused Parameters

	Here's your next lesson:

	![](BtnCapsInsertTrim;crcommand:OpenFile:CapsInsert.cs;;0.012,0.012)  << Caps+Insert to add new code...  */
