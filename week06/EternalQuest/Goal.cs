
public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    // Called when the user records progress on a goal.
    // Returns the number of points earned.
    public abstract int RecordEvent();

    // Returns whether the goal is complete.
    public abstract bool IsComplete();

    // Returns a formatted string for displaying the goal.
    public abstract string GetStatus();

    // Returns a formatted string for saving the goal to a file.
    public abstract string GetSaveString();
}

