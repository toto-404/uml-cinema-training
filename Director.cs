class Director
{
    private string firstName;
    private string lastName;
    private string country;

    public string GetFirstName()
    {
        return firstName;
    }
    public void SetFirstName( string firstName)
    {
        this.firstName = firstName;
    }

    public string GetLastName()
    {
        return lastName;
    }

    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public string GetCountry()
    {
        return country;
    }

    public void SetCountry( string country)
    {
        this.country = country;
    }

    public void Display()
    {
        Console.WriteLine($"Nom réalisateur: {GetLastName()}");
        Console.WriteLine($"Prenom: {GetFirstName()}");
        Console.WriteLine($"Pays: {GetCountry()}");
    }
}