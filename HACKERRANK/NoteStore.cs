using System;

public class Program
{
    static void Main(string[] args)
    {

    }
}

public class NotesStore
{
    public List<Notes> Notes;
    public NotesStore()
    {
        Notes = new List<Notes>();
    }
    public void AddNote(String state, String name) 
    { 
        try
        {
            
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
    public List<String> GetNotes(String state) { }
}

public class Notes
{
    public string state { get; set; }
    public string name { get; set; }
}

public enum States
{
    Completed = "completed",
    Active = "active",
    Others = "others"
}

public class NotesNameEmptyException : Exception
{
    public override string Message
    {
        get
        {
            return "Name cannot be empty";
        }
    }
}

public class NotesNameEmptyException : Exception
{
    public override string Message
    {
        get
        {
            return "Invalid state ";
        }
    }
}