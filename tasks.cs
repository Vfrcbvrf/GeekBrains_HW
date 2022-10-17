//  задача 34


int[] addarr(int x){

    int[] ar = new int[x];

    for (int i=0; i<x; i++){

        ar[i] = new Random().Next(100, 999);


    }

    return ar;

}

int size(int[] t){

    int count = 0;

    for (int i=0; i<t.Length; i++){

        if (t[i] % 2 == 0) count++;

    

    }

    return count;




}

Console.WriteLine("Введите размер массива");
int a = int.Parse(Console.ReadLine()!);


int[] b = addarr(a);

Console.WriteLine($"[{String.Join(", ", b)}]");

Console.WriteLine(size(b) + " четный(ых) элемент(а)");








/////////////////////////////////////////////////////////////

// задача 36





/////////////////////////////////////////////////////////////

// задача 38



// int[] arr(int x){

//     int[] ex = new int[x];

//     for (int i=0; i<x; i++){

//         ex[i] = new Random().Next(1000);

//     }

//     return ex;


// }

// int[] a = arr(8);

// Console.WriteLine($"[{String.Join(", ", a) }]");














