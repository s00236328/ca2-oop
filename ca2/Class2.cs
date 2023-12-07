using System;
using System.Collections.Generic;

public class Team : IComparable<Team>
{
    public string Name { get; set; }
    public int Rating { get; set; }
    public List<Player> Players { get; set; }

    public Team()
    {
        Players = new List<Player>();
    }

    // Implement the IComparable<T> interface
    public int CompareTo(Team other)
    {
        // Compare teams based on their ratings
        return this.Rating.CompareTo(other.Rating);
    }
}
