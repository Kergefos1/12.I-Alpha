namespace SocialFeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            TextPost tpost1 = new TextPost("Daniel", "sziasztok cigányok HEHE  >:DDDD");
            TextPost tpost2 = new TextPost("Ladzso", "asd");

            ImagePost Ipost1 = new ImagePost("Zeno", 3);
            ImagePost Ipost2 = new ImagePost("Zeno", 15);

            tpost2.Like();
            tpost2.Like();
            tpost2.Like();
            Console.WriteLine( tpost1.GetDescribtion());
            Console.WriteLine( tpost2.GetDescribtion());
            Ipost1.Like();
            Ipost1.Like();
            Ipost1.Like();
            Ipost1.Like();
            Ipost1.Like();
            Console.WriteLine(Ipost1.GetDescribtion());
            Console.WriteLine(Ipost2.GetDescribtion());

        }
    }
}
