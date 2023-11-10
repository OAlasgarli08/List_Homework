using Practical.Controllers;
using Practical.Models;

//Animal animal = new Animal();

//Fish fish1 = new Fish();

//fish1.Sound();

//Bird bird1 = new Bird();

//Animal animal2 = fish1;



//Bird bird2 = (Bird)animal;

//Animal[] datas = {animal, bird1, bird2, animal2, fish1};

//foreach (var data in datas)
//{
//    data.Name = "xxx";
//    Console.WriteLine(data.Name);
//}

//Animal animal = new Animal();

//Animal animal2 = new Fish();

//Bird bird = new Bird();

//Fish fish = new Fish();

//object[] datas = { 1, 2, bird, "salam", fish, animal, 100, animal2 };

//foreach (var data in datas)
//{
//    if(data is Animal)
//    {
//        ((Animal)data).Name = "xxx";
//        Console.WriteLine(((Animal)data).Name);
//    }
//    else 
//    {
//        Console.WriteLine($"{data} cannot convert");
//    }
//}












//List<int> nums = new List<int>();

//nums.Add(1);
//nums.Add(2);
//nums.Add(3);

//foreach(var items in nums)
//{
//    Console.WriteLine(items);
//}

//Console.WriteLine(nums.Count);


//List<string> names = new List<string>() { "Person1", "Person 2", "Person 3" };

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}


//List<string> emails = new() { "a@gmail.com", "b@gmail.com", "c@gmail.com" };

//static void CheckEmail(string email, List<string> emails)
//{
//    if (email.Contains(email))
//    {
//        Console.WriteLine("yes");
//    }
//    else
//    {
//        Console.WriteLine("no");
//    }
//}


//CheckEmail("c@gmail.com", emails);


//List<Product> products = new List<Product>();

//products.Add(new Product { Id = 1, Name = "A", Price = 5 });
//products.Add(new Product { Id = 2, Name = "B", Price = 10 });
//products.Add(new Product { Id = 3, Name = "C", Price = 7 });


//foreach (var product in products)
//{
//    Console.WriteLine(product.Name);
//}

//static IEnumerable<Product> Search(string str, List<Product> products)
//{
//    //return products.FindAll(m => m.Name.Contains(str));

//    return products.Where(m => m.Name.Contains(str)).ToList();
//}


List<int> nums = new() { 1, 2, 3, 4, 4, 5, 6 };

//for (int i = 0; i < nums.Count; i++)
//{
//    if (i <= 4)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}


//for (int i = 0;i < nums.Count; i++)
//{
//    if (nums[i] == 5)
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine(nums[i]);
//    }
//}



//for (int i = 0; i < nums.Count; i++)
//{
//    int index = nums.IndexOf(5);
//    if (i <= index)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}



ProductController productController = new ProductController();

//productController.GetById();
//productController.GetAll();
//productController.Sorting();