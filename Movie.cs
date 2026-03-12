class Movie
{
    private string? title;
    private int duration;
    

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

    //methode
    public void Display()
    {
        Console.WriteLine($"Titre Film:{Title}");
        Console.WriteLine($"Duration: {Duration} mins");
    }
}