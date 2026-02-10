public class WritingAssignment : Assignment
{
    string _title;
    public WritingAssignment(string studentName, string topic, string title) :base(studentName,topic)
    {
        SetStudentName(studentName);
        SetTopic(topic);
        SetTitle(title);
    }

    public string GetWritingInformation()
    {
        string writingInformaion = $"{_title}";
        return writingInformaion;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
}