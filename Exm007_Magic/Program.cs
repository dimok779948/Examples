Console.Clear();
//Console.SetCursorPosition(30, 4); // показывает отступы (левый край, верх)
//Console.WriteLine("+");

int xa =40, ya = 1,
    xb = 1, yb = 25,
    xc = 80, yc = 25;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("!");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("!");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("!");

int x = xa, y = xb; // определяем первую случайную точкку

int count = 0; //вводим счетчик 

while (count < 10000) //сколько раз
{
    int what = new Random().Next(0, 3); // определяем случайное число [0;3) - 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("!");
    count = count + 1;
    
} 