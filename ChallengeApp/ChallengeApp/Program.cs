// zadanie domowe dzień 5

Console.WriteLine("Podaj dowolną liczbę.");
string number = Console.ReadLine();
char[] letters = number.ToArray();


int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char num in letters)
{
    if (num == '0')
    {
        counter0++;
    }
    else if (num == '1')
    {
        counter1++;
    }
    else if (num == '2')
    {
        counter2++;
    }
    else if (num == '3')
    {
        counter3++;
    }
    else if (num == '4')
    {
        counter4++;
    }
    else if (num == '5')
    {
        counter5++;
    }
    else if (num == '6')
    {
        counter6++;
    }
    else if (num == '7')
    {
        counter7++;
    }
    else if (num == '8')
    {
        counter8++;
    }
    else if (num == '9')
    {
        counter9++;
    }
}
Console.WriteLine();
Console.WriteLine("W liczbie: " + number);
Console.WriteLine("Liczb 0 jest: " + counter0);
Console.WriteLine("Liczb 1 jest: " + counter1);
Console.WriteLine("Liczb 2 jest: " + counter2);
Console.WriteLine("Liczb 3 jest: " + counter3);
Console.WriteLine("Liczb 4 jest: " + counter4);
Console.WriteLine("Liczb 5 jest: " + counter5);
Console.WriteLine("Liczb 6 jest: " + counter6);
Console.WriteLine("Liczb 7 jest: " + counter7);
Console.WriteLine("Liczb 8 jest: " + counter8);
Console.WriteLine("Liczb 9 jest: " + counter9);


