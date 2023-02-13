int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a; // вводим переменную макс, куда кладем значение А, и потом поочередно сравниваем

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);