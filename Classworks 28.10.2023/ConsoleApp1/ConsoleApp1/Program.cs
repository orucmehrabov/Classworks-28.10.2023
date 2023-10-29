using ConsoleApp1;
using ConsoleApp1.Helpers;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

#region Homeworks

//string email = Console.ReadLine();
//var result = email.CheckEmail();

//if (result == true)
//{
//    Console.WriteLine("Success");
//}
//else
//{
//    Console.WriteLine("Wrong");
//}



//Console.WriteLine("Please add your email address");
//string email = Console.ReadLine();

//var res = email.CheckTrimEmail(@"\s");

//if(res == true)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}



//Person person = new ();
//person.Id = 1;
//person.Name = "Oruj";
//person.Surname = "Mehrabov";

//Console.WriteLine(person.GetFullName());



//int[] arr = { 1, 2, 3, 6, 7 };
//Console.WriteLine(arr.GetMultiplyArray());

#endregion


//IntList list = new IntList();

//list.Add(1);
//list.Add(2);
//list.Add(100);

//list.GetAll();


//StringList list = new ();

//list.Add ("Oruc");
//list.Add ("Semed");
//list.Add("Ilham");

//list.GetAll();



//PersonList list = new PersonList();

//list.Add(new Person { Id = 1, Name = "Oruc", Surname = "Mehrabov" });
//list.Add(new Person { Id = 2, Name = "Sahin", Surname = "Movsumzade" });
//list.Add(new Person { Id = 3, Name = "Tural", Surname = "Taqiyev" });

//list.GetAll();



//DataList<int> datas = new();

//datas.Add(1);
//datas.Add(10);
//datas.Add(20);

//datas.GetAll();


//DataList<string> stringList = new();

//stringList.Add("Oruc");
//stringList.Add("Tural");
//stringList.Add("Kenan");

//stringList.GetAll();



//DataList<Person> students = new();

//students.Add(new Person { Id = 1, Name = "Oruc", Surname = "Mehrabov" });
//students.Add(new Person { Id = 2, Name = "Sahin", Surname = "Movsumzade" });
//students.Add(new Person { Id = 3, Name = "Tural", Surname = "Taqiyev" });

//var res = students.GetAll();

//foreach (var item in res)
//{
//    Console.WriteLine(item.Name);
//}



//List<Person> people = new();

//people.Add(new Person { Id = 1, Name = "Oruc", Surname = "Mehrabov" });

//foreach (Person person in people)
//{
//    Console.WriteLine(person.Name);
//}



Repository<string> repo1 = new Repository<string>();
Repository<int> repo2 = new Repository<int>();
Repository<bool> repo3 = new Repository<bool>();
Repository<Person> repo4 = new Repository<Person>();
