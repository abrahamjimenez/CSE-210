using System;
namespace Learning04;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment()
    {

    }

    public void SetTextbookSection(string textBookSection)
    {
        _textbookSection = textBookSection;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}

