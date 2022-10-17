//  задача 34

/*

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


*/





/////////////////////////////////////////////////////////////

// задача 36


/*

int[] zapar(int x){

    int[] arr = new int[x];

    for (int i=0; i<x; i++){

        arr[i] = new Random().Next(-100, 100);


    }

    return arr;

}


int nech(int[] pit){

    int sum = 0;

    for (int i=1; i<pit.Length; i+=2){


        sum+=pit[i];

    }

    return sum;




}


Console.WriteLine("Введите размер массива: ");

int a = int.Parse(Console.ReadLine()!);

int[] bar = zapar(a);

Console.WriteLine($"[{String.Join(", ", bar)}]");

Console.WriteLine(nech(bar));

*/







/////////////////////////////////////////////////////////////

// задача 38



int[] arr(int x){

    int[] put = new int[x];


    for (int i=0; i<x; i++){

        
        put[i] = new Random().Next(-1000000, 1000000);

    }

    return put;

}


int max = -1000000000;
int min =  1000000000;

Console.WriteLine("Введите длину массива ");
int a = int.Parse(Console.ReadLine()!);
int[] be = arr(a);

Console.WriteLine($"[{String.Join(", ", be)}]");



for (int i=0; i<a; i++){

    if (be[i] > max) max = be[i];
    if (be[i] < min) min = be[i];

}

Console.WriteLine(max - min);


















