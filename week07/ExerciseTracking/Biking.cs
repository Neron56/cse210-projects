public class Biking : Activity
{
    float _speed;
    public Biking(string date, int time, float speed)
    {
        SetDate(date);
        SetName("Biking");
        SetTime(time);
        _speed = speed;
    }
    public override float GetDistance()
    {
        float distance = _time / GetPace();
        return distance;
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        float pace = 60/_speed;
        return pace;
    }
}