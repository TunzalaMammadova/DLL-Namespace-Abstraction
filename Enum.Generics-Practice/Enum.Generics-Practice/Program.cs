using Enum.Generics_Practice;
using Enum.Generics_Practice.Helpers.Extensions;


#region Homeworks
//string email = Console.ReadLine();

//var result = email.CheckEmail();

//if(result == true)
//{
//    Console.WriteLine("Success");
//}
//else
//{
//    Console.WriteLine("Wrong");
//}


//Console.WriteLine("Please add your email address");

//string str = Console.ReadLine();

//var res = str.CheckTrimEmail(@"\s");


//if (res == true)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}


//Person person = new();

//person.Id = 1;
//person.Name = "Cavid";
//person.Surname = "Bashirov";

//Console.WriteLine(person.GetFullData());



//int[] arr = { 1, 2, 3, 4, 5 };

//Console.WriteLine(arr.GetMultiplyArray());
#endregion



//IntList list = new();

//list.Add(1);
//list.Add(2);
//list.Add(100);

//list.GetAll();




//StringList list = new();

//list.Add("Semed");
//list.Add("Oruc");
//list.Add("Nurlan");

//list.GetAll();




//StringList list = new();

//list.Add("Semed");
//list.Add("Oruc");
//list.Add("Nurlan");

//list.GetAll();




//PersonList list = new();

//list.Add(new Person { Id = 1, Name = "Test1", Surname = "Test1" });
//list.Add(new Person { Id = 2, Name = "Test2", Surname = "Test2" });
//list.Add(new Person { Id = 3, Name = "Test3", Surname = "Test3" });

//list.GetAll();




//DataList<int> datas = new();

//datas.Add(5);
//datas.Add(10);
//datas.Add(20);

//datas.GetAll();




//DataList<string> stringlist = new();

//stringlist.Add("fgg");
//stringlist.Add("dty");
//stringlist.Add("jdfx");

//stringlist.GetAll();




//DataList<Person> students = new();

//students.Add(new Person { Id = 1, Name = "Test1", Surname = "Test1" });
//students.Add(new Person { Id = 2, Name = "Test2", Surname = "Test2" });
//students.Add(new Person { Id = 3, Name = "Test3", Surname = "Test3" });

//Person[] res = students.GetAll();

//foreach (var item in res)
//{
//    Console.WriteLine(item.Name);
//}




//Repository<string> repo1 = new Repository<string>();
//Repository<int> repo2 = new Repository<int>();
//Repository<bool> repo3 = new Repository<bool>();




//DataList<string> words = new DataList<string>();

//words.Add("salam1");
//words.Add("salam2");
//words.Add("salam3");

//var datas = words.GetAll();

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}




//Repository<Person> repository = new Repository<Person>();
//repository.Add(new Person{ Id = 1, Name = "Test1", Surname = "Test1" });
//Repository<Student> repository1 = new Repository<Student>();




//string paymentType = "Cash";

//static void CheckPaymentType(string type)
//{
//    switch (type)
//    {
//        case nameof(PaymentType.Card):
//            Console.WriteLine("With card");
//            break;
//        case nameof(PaymentType.Cash):
//            Console.WriteLine("With cash");
//            break;
//        default:Console.WriteLine("Payment type is wrong");
//            break;
//    }



    //if (type == (int)PaymentType.Card)
    //{
    //    Console.WriteLine("With card");
    //}
    //else if (type == (int)PaymentType.Cash)
    //{
    //    Console.WriteLine("With cash");
    //}
    //else
    //{
    //    Console.WriteLine("Payment type is wrong");
    //}
//}

//CheckPaymentType(paymentType);