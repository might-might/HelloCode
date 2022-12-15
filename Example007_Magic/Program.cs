int counter = 0;

int xa = 40;
int ya = 1; 
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;

int x = xa;
int y = xb;

while(counter < 10000)
{
    
    // Console.Write(x + " ");
    // Console.WriteLine(y + " ");
    // Console.WriteLine("отбивка нулевая");
    int what = new Random().Next(0, 3);
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
    // Console.Write(what + " ");
    // Console.Write(x + " ");
    // Console.WriteLine(y + " ");
    // Console.WriteLine("___________");
    Console.WriteLine("+");
    counter += 1;
}