int number1 = 10;
int number2 = 5;

// operatory relacyjne

// == równa się
// != różne
// < mniejsze
// > większe
// <= mniejsze lub równe
// >= większe lub równe

if (number1 < number2)
{
    Console.WriteLine("Liczba2 jest większa od liczby1");
}
else
{
    Console.WriteLine("Liczba2 jest mniejsza od liczby1");
}



var name = "Jan";
var age = 33;

// operatory logiczne
// && i
// || lub
// ! negacja

// instrukcje warunkowe if
if (name == "Jan" && age > 30)
{
    Console.WriteLine("Nazywam się Jan i mam powyżej 30 lat.");
}
else
{
    Console.WriteLine("Jestem kimś innym");
}

// zagnieżdzony if (else if)
if (age > 30)
{
    Console.WriteLine("Jan ma powyżej 30 lat.");
}
else if (age > 40)
{
    Console.WriteLine("Jan ma powyżej 40 lat.");
}
else if (age > 50)
{
    Console.WriteLine("Jan ma powyżej 50 lat.");
}