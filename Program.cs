
using ConsoleApp1;

Book asd = new Book("Egressy", "Gábor", 153);
Book asd2 = new Book("Egri Csillagok", "Móricz Zsigmond", -36);
Book asd3 = new Book("ASD222", "Varsányy Ró-lant");
Book asd4 = new Book("ADHD2000", "Ladzso20");
Book asd5 = new Book("AUTISM4MIL", "Vitézi Dávyd");
asd.Descripe();
asd2.Descripe();
asd3.Descripe();
/*Console.WriteLine(asd2.IsLong());
Console.WriteLine(asd.IsLong());
Console.WriteLine(asd3.IsLong());
*/

Console.WriteLine(asd.Borrow());
asd.Return();
Console.WriteLine(asd.Borrow());

Libary dsa = new Libary("Széchenyi Könyvtár");

dsa.AddBook(asd);
dsa.AddBook(asd2);
dsa.AddBook(asd3);
dsa.AddBook(asd4);
dsa.AddBook(asd5);

Console.WriteLine(dsa.FindByTitle("ASasdasdas")); 