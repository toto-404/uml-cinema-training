class Movie
{
    private string? title;
    private int duration;

    private Director director;
    

    public string? Title
    {
        get{return title;}
        set{title = value;}
    }

   public int Duration
    {
        get{return duration;}
        set{duration = value;}
    }

    //sans proprieté
    public Director GetDirector()
    {
        return director;
    }

    public void SetDirector(Director director)
    {
        this.director = director;
    }

    //methode
    public void Display()
    {
        Console.WriteLine($"Titre Film:{Title}");
        Console.WriteLine($"Duration: {Duration} mins");
        Console.WriteLine($"Director: {GetDirector().GetFirstName()} {GetDirector().GetLastName()}");
    }
}