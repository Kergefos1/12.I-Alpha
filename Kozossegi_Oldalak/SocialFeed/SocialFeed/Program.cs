namespace SocialFeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            TextPost tpost1 = new TextPost("Daniel", "sziasztok cigányok HEHE  >:DDDD");
            TextPost tpost2 = new TextPost("Ladzso", "asd");

            tpost2.Like();
            tpost2.Like();
            tpost2.Like();
            Console.WriteLine( tpost1.GetDescribtion());
            Console.WriteLine( tpost2.GetDescribtion());
        }
    }
}
