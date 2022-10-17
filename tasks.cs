//  задача 25



// int st(int x, int y){

//     int per = x;

//     if (y!=0){
    
//         for (int i=1; i<y; i++){

//             per*=x;
//         }
//         return per;

//     } else return 1;


// }


// int a = int.Parse(Console.ReadLine()!);
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine(st(a, b));



/////////////////////////////////////////////////////////////

// задача 27


// int numb(int x){

//     int sum = 0;
//     while (x>0){

//         sum+= x%10;
//         x/=10;



//     }
//     return sum;


// }


// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine(numb(a));




/////////////////////////////////////////////////////////////

// задача 29



int[] arr(int x){

    int[] ex = new int[x];

    for (int i=0; i<x; i++){

        ex[i] = new Random().Next(1000);

    }

    return ex;


}

int[] a = arr(8);

Console.WriteLine($"[{String.Join(", ", a) }]");














