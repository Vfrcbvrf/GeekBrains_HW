//  задача 64

/*

void outnat(int x){

if (x<0){ 
    Console.WriteLine(x + " не натуральное число");
    return;
}
if (x==0) return;
Console.Write(x+ " ");
outnat(x-1);



}

Console.Write("Введите натурально число: ");
int n = int.Parse(Console.ReadLine()!);
outnat(n);


*/


/////////////////////////////////////////////////////////////

// задача 66

/*

void sum(int x, int y, int fin){

    if (x<=y){
        fin+=x;
        x++;
        sum(x,y,fin);
    } else {
        Console.WriteLine(fin);
        return;
    }



}



Console.Write("M = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("N = ");
int n = int.Parse(Console.ReadLine()!);
int all = 0;
sum(m,n,all);

*/

/////////////////////////////////////////////////////////////



// задача 68

int acker(int x, int y){

    if (x==0) return y+1;
    if (x!=0 && y == 0) return acker(x-1, 1);
    if (x>0 && y>0) return acker(x-1, acker(x, y-1));
    return 0;
}

Console.Write("m=");
int m = int.Parse(Console.ReadLine()!);
Console.Write("n=");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"A({m},{n}) = {acker(m,n)}");