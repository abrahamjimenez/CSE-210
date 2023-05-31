using System;
namespace Learning04;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment()
    {
        
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title}";
    }
}

