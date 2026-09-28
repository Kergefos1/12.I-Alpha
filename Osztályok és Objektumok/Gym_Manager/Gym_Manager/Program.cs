using Gym_Manager;

Member student = new Member("Józsi", 69, true);
Member student2 = new Member("Jóska", 15, true);
Member notstudent = new Member("Sóska", 67, false);

Console.WriteLine(student.Name, student.Age);
Console.WriteLine(student2.Name, student2.Age);
Console.WriteLine(notstudent.IsStudent);