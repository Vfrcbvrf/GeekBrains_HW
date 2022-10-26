//  задача 47

/*


float[,] get(float[,] x){

    for (int i = 0; i<x.GetLength(0); i++){
        for (int j=0; j<x.GetLength(1); j++){
            
            float b = new Random().Next(-100, 100);
            x[i,j] = b/10;
        }


    }

    return x;
}

void print(float[,] ara){

    for (int i=0; i<ara.GetLength(0); i++){
        for (int j=0; j<ara.GetLength(1); j++){

            Console.Write(ara[i,j] + "  ");

        }
        Console.WriteLine();
    }


}

Console.WriteLine("m= ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("n= ");
int n = int.Parse(Console.ReadLine()!);

float[,] a = new float[m,n];

print(get(a));

*/


/////////////////////////////////////////////////////////////

// задача 50


/*


float[,] get(float[,] x){

    for (int i = 0; i<x.GetLength(0); i++){
        for (int j=0; j<x.GetLength(1); j++){
            
            x[i,j] = new Random().Next(-10, 10);
        }


    }

    return x;
}

void print(float[,] ara){

    for (int i=0; i<ara.GetLength(0); i++){
        for (int j=0; j<ara.GetLength(1); j++){

            Console.Write(ara[i,j] + "  ");

        }
        Console.WriteLine();
    }


}

Console.Write("m= ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("n= ");
int n = int.Parse(Console.ReadLine()!);

float[,] a = new float[m,n];

print(get(a));


Console.Write("i= ");
int fir = int.Parse(Console.ReadLine()!);
Console.Write("j= ");
int sec = int.Parse(Console.ReadLine()!);
if (fir>m-1 || sec>n-1) Console.WriteLine("Dont exist");
    else Console.WriteLine(a[fir, sec]);


*/



/////////////////////////////////////////////////////////////

// задача 52


int[,] get(int[,] x){

    for (int i = 0; i<x.GetLength(0); i++){
        for (int j=0; j<x.GetLength(1); j++){
            
            x[i,j] = new Random().Next(10);
        }


    }

    return x;
}

void print(int[,] ara){

    for (int i=0; i<ara.GetLength(0); i++){
        for (int j=0; j<ara.GetLength(1); j++){

            Console.Write(ara[i,j] + "  ");

        }
        Console.WriteLine();
    }


}


int[,] a = new int[4,4];

print(get(a));


float ber = 0, count = 0;;

for (int i=0; i<a.GetLength(0); i++){

    ber = 0; count = 0;

    for (int j=0; j<a.GetLength(1); j++){

        ber += a[j, i];
        count++;

    }
    Console.Write(ber/count + " ");



    
}
















