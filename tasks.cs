//  задача 41

/*

float[] zap(int x){

    float[] at = new float[x];


    for (int i=0; i<x; i++){

        
        at[i] = float.Parse(Console.ReadLine()!);


    }

    return at;


}



int getzero(float[] po){

    int sum = 0;

    for (int j=0; j<po.Length; j++){

        if (po[j] > 0) sum++;

    }

    return sum;

}


Console.WriteLine("Количество чисел: ");
int a = int.Parse(Console.ReadLine()!);


Console.WriteLine("Введите " + a + " чисел");

float[] apr = zap(a);

Console.WriteLine($"[{String.Join("; ", apr)}]");

Console.WriteLine("Здесь " + getzero(apr) + " чисел, больших 0");

*/


/////////////////////////////////////////////////////////////

// задача 43

/*
Console.WriteLine("k1= ");
float k1 = float.Parse(Console.ReadLine()!);

Console.WriteLine("b1= ");
float b1 = float.Parse(Console.ReadLine()!);

Console.WriteLine("k2= ");
float k2 = float.Parse(Console.ReadLine()!);

Console.WriteLine("b2= ");
float b2 = float.Parse(Console.ReadLine()!);


float x = (b2-b1)/(k1-k2);
float y = k1*x + b1;

Console.WriteLine($"({String.Join("; ", x, y)})");

*/

/////////////////////////////////////////////////////////////

// задача доп


float[] getarr(){


    float[] exarr = new float[10];

    for (int i=0; i<10; i++){

        exarr[i] = new Random().Next(50, 100);

    }

    return exarr;

}


float schet(ref float a, ref float[] arr ){


    float con=1;


    for (int j=0; j<arr.Length; j++){

        if(arr[j]<a) con*=arr[j];


    }

    return con;



}



float[] arr = getarr();

Console.WriteLine("Введите число: ");
float a = float.Parse(Console.ReadLine()!);

Console.WriteLine($"[{String.Join(", ", arr)}]");

float test = schet(ref a, ref arr);

if (test==1) Console.WriteLine("Чисел, которые меньше " + a + ", нет");
    else Console.WriteLine(test);



















