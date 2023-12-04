using System;
using System.Collections.Generic;

public class Team
{

	public string Name { get; set; }
    public List<Player> Players = new List<Player>();

    public Team()
    { }
}
