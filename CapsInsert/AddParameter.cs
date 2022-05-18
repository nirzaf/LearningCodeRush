using System;
using System.Collections.Generic;
using System.Linq;

namespace CapsModifier
{
	//`![](CapsInsert;crcommand:OpenFile:CapsInsert.cs;;0.012,0.012) to add a new parameter.

	public partial class AddParameter
	{
		//` ![](Add Parameter;https://www.youtube.com/watch?v=KAtOxMQyg3g&list=PL8h4jt35t1wgawacCN9wmxq1EN36CNUGk&index=4 ;;0.04,0.04)  << Learn about Add Parameter.

		internal void TestStart()
		{
			//`                     Look here ![](LookHere;;;0.012,0.012) when you try the next one.
			Start(TimeSpan.FromSeconds(5), Guid.Empty, 25);
		}


		//`![](BtnTextFields;crcommand:OpenFile:TextFields.cs;;0.012,0.012)  << Learn about Text Fields.


		//`            Caps+Insert ![](ArrowDown;;;0.008,0.008) to add a new parameter (e.g., "bool fast").
		void Start(TimeSpan age, Guid id, int count)
		{
			started = true;
		}

		//`++ Pro Tip - Smart Cut/Copy
		// CodeRush lets you cut and copy identifiers without selecting them.
		// Just place the caret inside the identifier and press the copy or 
		// cut keys (e.g., Ctrl+C, Ctrl+Insert, etc.).

		//` ![](SmartCutCopyPasteReplace;https://www.youtube.com/watch?v=KxJO1V-W2lI&list=PL8h4jt35t1wgawacCN9wmxq1EN36CNUGk&index=25 ;;0.04,0.04)  << More on Smart Cut/Copy.

		public void CompleteTasks()
		{
			//`        ![](ArrowDown;;;0.008,0.008) Ctrl+C copies this identifier (no need to select).
			string greeting = "CodeRush Rocks!";

			//  (you can paste it as a new argument in the example below)


			// You can add new parameters from a method's call site:

			if (!started)
			{
				var fiveSeconds = TimeSpan.FromSeconds(5);
				var count = 50;

				//`   Caps+Insert ![](ArrowDown;;;0.008,0.008) (and then paste) to add "greeting" as a new parameter.
				LateStart(count, fiveSeconds);
			}
		}
		//`                        Look here ![](LookHere;;;0.012,0.012) when you try the previous one (undo/redo to see changes).
		public void LateStart(int count, TimeSpan timeSpan)
		{

		}

		//`++ Pro Tip
		// You can use CodeRush templates inside of text fields. So if you 
		// need a "string" for a new parameter, you can enter "ts" (for
		// "type - string") and then press the Space bar or Tab key to expand
		// the template.

		// If you need a list of strings, enter "tl.s" (for "type - list of
		// strings").

		// You can enable Templates on the Quick Setup options page.

		//`![](BtnQuickSetupSettings;crcommand:Options:Quick Setup;;0.012,0.012)


		//` ![](T for Types;https://www.youtube.com/watch?v=WiGSSxFLNhI&list=PL8h4jt35t1wgawacCN9wmxq1EN36CNUGk&index=22 ;;0.04,0.04)  << More on Type templates.


		// Try using "ts" (or "tl.s") on the next example! 

		internal void TestComplete()
		{
			//`          Look here ![](LookHere;;;0.012,0.012) when you try the next one.
			Complete(Guid.Empty);
		}

		//`                           ![](ArrowDown;;;0.008,0.008) Caps+Insert to add a new parameter.
		public void Complete(Guid id)
		{

		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:AddMissingConstructors.cs;;0.012,0.012) << Add Missing Constructors and more...
}



//`![](BtnLessonSummary;crcommand:OpenFile:FinishHere.cs;;0.012,0.012) << Skip ahead to the end.
