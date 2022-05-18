

//`![](CapsInsert;crcommand:OpenFile:CapsInsert.cs;;0.012,0.012) to add a member to an interface.

interface IPerson
{
	string FullName { get; set; }
}

class Person : IPerson
{
	public string FullName { get; set; }

	//`   Caps+Insert ![](ArrowDown;;;0.008,0.008) to add this property to the IPerson interface.
	public string MobilePhone { get; set; }

	//` Caps+Insert ![](ArrowDown;;;0.008,0.008) to add this method to the IPerson interface.
	public void Call()
	{
		throw new System.NotImplementedException();
	}
}

//`![](BtnCongratulations;crcommand:OpenFile:FinishHere.cs;;0.012,0.012) << Click to complete the lessons!
