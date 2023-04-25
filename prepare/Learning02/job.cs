using System;


// this is a class template named Job

/*
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job(string aCompany, string aJobTitle, int aStartYear, int anEndYear)
    {
        _company = aCompany;
        _jobTitle = aJobTitle;
        _startYear = aStartYear;
        _endYear = anEndYear;   
    }
    Job display = new Job("Microsoft", "Software Engineer", 2022, 2023);

}    */

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}