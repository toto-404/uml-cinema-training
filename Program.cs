namespace uml_cinema_training;

class Program
{
    static void Main(string[] args)
    {
        //Movie
        Movie film1 = new Movie();
        film1.Title = "The Time Traveler's Paradox";
        film1.Duration = 140;
        film1.Display();
        Console.WriteLine();
        //Director
        Director dir1 = new Director();
        dir1.SetFirstName("John");
        dir1.SetLastName("Doe");
        dir1.SetCountry("Malaysia");
        dir1.Display();
    }
}
