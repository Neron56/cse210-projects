public class Swimming : Activity
{
    float _laps;
    public Swimming(string date, int time, float laps)
    {
        SetDate(date);
        SetName("Swimming");
        SetTime(time);
        _laps = laps;
    }
    public override float GetDistance()
    {
        float distance = (_laps * 50) / 1000;
        return distance;
    }
    public override float GetSpeed()
    {
        float speed = (GetDistance()/_time) * 60;
        return speed;
    }
    public override float GetPace()
    {
        float pace = _time / GetDistance();
        return pace;
    }
}