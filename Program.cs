namespace uml_cinema_training;

class Program
{
    static void Main(string[] args)
    {
        Movie film1 = new Movie();
        film1.Title = "The Time Traveler's Paradox";
        film1.Duration = 140;
        film1.Display();
    }
}
