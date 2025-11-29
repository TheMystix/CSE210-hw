using System;

public class Comment
{
    private string _firstName;
    private string _lastName;
    private string _text;

    public Comment(string firstName, string lastName, string text)
    {
        _firstName = firstName;
        _lastName = lastName;
        _text = text;
        
    }

    public string GetCommenterName() => $"{_firstName} {_lastName}";
    public string GetText() => _text;
}