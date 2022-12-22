Console.WriteLine("input three-digit number");
int value = int.Parse(Console.ReadLine());



 int a = value / 100;
 int b = (value / 10) % 10;
 int c = value % 10;

 if (value < 100)
 {
     Console.WriteLine("there is no third number");
 }

 else

 {
    Console.Write("third nimber is ");
    Console.WriteLine(c);
 }

 