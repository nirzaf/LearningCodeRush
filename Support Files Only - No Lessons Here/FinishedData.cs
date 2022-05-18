using System;
using System.Collections.Generic;

public class FinishedData
{
	public DateTime StartTime { get; set; }
	public DateTime EndTime { get; set; }
	public int CyclesProcessed { get; set; }
	public List<string> Messages { get; set; }
	public FinishedData()
	{

	}
}
