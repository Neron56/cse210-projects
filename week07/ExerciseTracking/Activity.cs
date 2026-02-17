using System.Security;

public abstract class Activity
{
    string _name;
    string _date;
    protected int _time;
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

    public string GetSummary()
    {
        float distance = GetDistance();
        float speed = GetSpeed();
        float pace = GetPace();
        string summary = $"{_date} {_name} ({_time} Minutes)- Distance: {distance.ToString("0.0")}km, Speed: {speed.ToString("0.##")}kph, Pace: {pace.ToString("0.##")} min per km";
        return summary;
    } 
    public void SetDate(string date)
    {
        _date = date;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetTime(int time)
    {
        _time = time;   
    }
}