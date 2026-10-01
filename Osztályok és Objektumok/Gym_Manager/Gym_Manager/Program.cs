using Gym_Manager;

Member student = new Member("Józsi", 69, true);
Member student2 = new Member("Jóska", 15, true);
Member notstudent = new Member("Sóska", 67, false);

Console.WriteLine(student.Name, student.Age);
Console.WriteLine(student2.Name, student2.Age);
Console.WriteLine(notstudent.IsStudent);

Membership ship = new Membership(student, 131685, 398);
Membership ship2 = new Membership(notstudent, 131685, 398);

ship2.Extended(2);
Console.WriteLine($"{ship.Owner.Name} {ship.Owner.Age} ");
Console.WriteLine(ship2.Owner.Name);

Gym gym = new Gym("almagym");

Console.WriteLine($"{ship.Owner.Name}, {ship.PricePerVisit()}");