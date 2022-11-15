//  задача 60


/*

int[,,] getar(int[,,] x){

    int m = 0;
    int l = 9;
    for (int i=0; i< x.GetLength(0); i++){
        for (int j=0; j< x.GetLength(1); j++){
            for (int k=0; k < x.GetLength(2); k++){
                
                x[i,j,k] = new Random().Next(m, l);

                m+=10;
                l+=10;


            }
        }
    }

    return x;


}

void print(int[,,] a){

    for (int i=0; i< a.GetLength(0); i++){
        for (int j=0; j< a.GetLength(1); j++){
            for (int k=0; k< a.GetLength(2); k++){

                Console.Write(a[i,j,k]+ "(" + i + ", " + j + ", " + k + ")  ");



            }
            Console.WriteLine();
        }
    }



}


int[,,] n = new int[2,2,2];


getar(n);
print(n);

*/


/////////////////////////////////////////////////////////////

// задача 62



/*

int[,] getar(int[,] x){

    
    int ch = 0;
    int i = 0, j = 0;
    int pre = x.GetLength(0);
    for (int a = 0; a < pre*pre; a++){

        int k = 0;
        while (k++ < pre - 1) x[i, j++] = ch++; 
        
        for (k = 0; k < pre - 1; k++) x[i++, j] = ch++;
        for (k = 0; k < pre - 1; k++) x[i, j--] = ch++;
        for (k = 0; k < pre - 1; k++) x[i--, j] = ch++;

        i++; j++;

        pre = (pre < 2)?0:(pre - 2);

    }

    return x;

}

void print(int[,] a){

    for (int i=0; i<a.GetLength(0); i++){
        for (int j=0; j< a.GetLength(1); j++){
            
            
            if (a[i,j] < 10) Console.Write("0" + a[i,j] + "  ");
            else Console.Write(a[i,j] + "  ");
        }
        Console.WriteLine();
    }



}

int[,] n = new int[4,4];

getar(n);


print(n);

*/

/////////////////////////////////////////////////////////////



// задача 56

/*


int[,] getar(int[,] x){

    
    for (int i=0; i < x.GetLength(0); i++){
        for (int j=0; j<x.GetLength(1); j++){

            x[i,j] = new Random().Next(1, 9);

        }
    }




    return x;
}

void print(int[,] x){

    for (int i=0; i< x.GetLength(0); i++){
        for (int j=0; j< x.GetLength(1); j++){

            Console.Write(x[i,j] + " ");
        }
        Console.WriteLine();
    }



}


void sort(int[,] m ){

    for (int i=0; i< m.GetLength(0); i++){
        for (int j=0; j < m.GetLength(1); j++){

            for (int l=0; l < m.GetLength(1) -1; l++){

                if (m[i,l] < m[i, l+1]){

                    int help = m[i,l+1];
                    m[i,l+1] = m[i,l];
                    m[i,l] = help;


                }

            }



        }
    }



}



int[,] ar = new int[4,3];

getar(ar);
print(ar);

Console.WriteLine();

sort(ar);
print(ar);

*/



// задача 56


/*



int[,] getar(int[,] x){

    for (int i=0; i<x.GetLength(0); i++){
        for (int j=0; j<x.GetLength(1); j++){

            x[i,j] = new Random().Next(1, 10);


        }
    }

    return x;

}

void print(int[,] h){


    for (int i=0; i<h.GetLength(0); i++){
        for (int j=0; j<h.GetLength(1); j++){

            Console.Write(h[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void minimum(int[,] fr)
{
    int min = 0;
    int stroka = 0;
    int sum = 0;
    for (int i = 0; i < fr.GetLength(1); i++){
        min += fr[0, i];
    }
    for (int i = 0; i < fr.GetLength(0); i++){
        for (int j = 0; j < fr.GetLength(1); j++) sum += fr[i, j];{
            if (sum < min){
                min = sum;
                stroka = i;
            }
        }
        sum = 0;
    }
    Console.Write($"{stroka + 1} строка");
}


int[,] n = new int[4,4];
getar(n);
print(n);
minimum(n);


*/

// задача 58





void getar(int[,] x){

    for (int i = 0; i < x.GetLength(0); i++){

        for (int j = 0; j < x.GetLength(1); j++){

            x[i, j] = new Random().Next(1, 10);

        }
    }
}


void print(int[,] x){

    for (int i = 0; i < x.GetLength(0); i++){
        for (int j = 0; j < x.GetLength(1); j++){

            Console.Write($"{x[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.Write("Количсетво строк= ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов= ");
int stb = int.Parse(Console.ReadLine()!);

int[,] arr = new int[str, stb];
int[,] help = new int[str, stb];
int[,] result = new int[str, stb];

getar(arr);
print(arr);

Console.WriteLine();

getar(help);
print(help);

Console.WriteLine();

if (arr.GetLength(0) != help.GetLength(1)){

    Console.WriteLine("Нельзя перемножить!");
    return;
}

for (int i = 0; i < arr.GetLength(0); i++){

    for (int j = 0; j < help.GetLength(1); j++){

        result[i, j] = 0;
        for (int k = 0; k < arr.GetLength(1); k++){

            result[i, j] += arr[i, k] * help[k, j];
        }
    }
}

print(result);











