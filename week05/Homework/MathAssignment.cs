public class MathAssignment : Assignment
{
    string _textbookSection;
    string _problems;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        SetStudentName(studentName);
        SetTopic(topic);
        SetTextbookSection(textbookSection);
        SetProblem(problems);
    }
    public string GetHomeworkList()
    {
        string homeworkList = $"{_textbookSection} {_problems}";
        return homeworkList;
    }
    public void SetTextbookSection(string textBookSection)
    {
        _textbookSection = textBookSection;
    }
    public void SetProblem(string problems)
    {
        _problems = problems;
    }
}