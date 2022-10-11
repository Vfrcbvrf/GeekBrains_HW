

//  задача 19

// string a = Console.ReadLine()!;
// if (a.Length!=5) Console.WriteLine("введите 5-значное число");
// else {

//     if (a[0]==a[4] && a[1]==a[3]) Console.WriteLine("да");
//     else Console.WriteLine("неа");



// }






/////////////////////////////////////////////////////////////


// задача 21


Console.WriteLine("введите координаты точки A: ");
int a1 = int.Parse(Console.ReadLine()!);
int a2 = int.Parse(Console.ReadLine()!);
int a3 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите координаты точки B: ");
int b1 = int.Parse(Console.ReadLine()!);
int b2 = int.Parse(Console.ReadLine()!);
int b3 = int.Parse(Console.ReadLine()!);

double ans = Math.Sqrt( Math.Pow((a1-b1),2) + Math.Pow((a2-b2),2) + Math.Pow((a3-b3),2)   );


Console.WriteLine(Math.Round(ans,2));








/////////////////////////////////////////////////////////////


// задача 23












