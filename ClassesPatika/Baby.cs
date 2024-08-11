namespace ClassesPatika;

public class Baby
{
    public Baby()
    {
        Name = "Undefined";
        Surname = "Undefined";
        BirthTime = DateTime.Now;
    }

    public Baby(string name, string surname)
    {
        Surname = surname;
        Name = name;
        BirthTime = DateTime.Now;
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthTime { get; set; }
}