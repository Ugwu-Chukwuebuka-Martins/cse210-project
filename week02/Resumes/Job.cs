using System;

public class Job
{
    public string _jobTitle;
    public string _company_name;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company_name}) {_startYear} - {_endYear}");
    }
}