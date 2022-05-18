using System;

namespace CapsModifier
{
	public class SimpleNameSyntax
	{
		internal bool HasAssignment(out SyntaxNode assignment)
		{
			assignment = new SyntaxNode();
			return true;
		}
	}
}