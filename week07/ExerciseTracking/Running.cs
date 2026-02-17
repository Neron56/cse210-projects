public class Running : Activity
{
    float _distance;
    public Running(string date, int time, float distance)
    {
        SetDate(date);
        SetName("Running");
        SetTime(time);
        _distance = distance;
    }
    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        float speed = 60/GetPace();
        return speed;
    }
    public override float GetPace()
    {
        float pace = _time / _distance;
        return pace;
    }
}