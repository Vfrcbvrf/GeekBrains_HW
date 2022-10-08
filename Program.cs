

//  задача 10

// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine((a/10)%10);




/////////////////////////////////////////////////////////////


// задача 13



int a = int.Parse(Console.ReadLine()!);
int count = 0;
int te = a;

while (te>0){
    count++;
    te/=10;
}


if (count<3){
    Console.WriteLine("третьей цифры нема");
}else {

    for (int i=1; i<=count-3; i++){
        a/=10;
    }
    
    Console.WriteLine(a%10);

}








/////////////////////////////////////////////////////////////


// задача 15











