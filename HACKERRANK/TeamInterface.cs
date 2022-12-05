using System;

public class Program
{
    static void Main(string[] args)
    {

    }
}

public class Team
{
    public string? teamName;
    public int? noOfPlayers;

    public Team(string teamName, int noOfPlayers)
    {
        this.teamName = teamName;
        this.noOfPlayers = noOfPlayers;
    }

    public void AddPlayer(int count)
    {
        this.noOfPlayers += count;
    }

    public bool RemovePlayer(int count)
    {
        bool result = true;
        this.noOfPlayers -= count;

        if (this.noOfPlayers < 0) 
        {
            result = false;
        }

        return result;
    }
}

public class Subteam : Team
{
    public Subteam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers)
    {

    }

    public void ChangeTeamName(string name)
    {
        this.teamName = name;
    }
}