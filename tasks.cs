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












