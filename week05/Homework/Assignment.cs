public class Assignment
{
    protected string _studentName;
    protected string _topic;
    public Assignment(string studentName, string topic)
    {
        SetStudentName(studentName);
        SetTopic(topic);
    }

    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
}