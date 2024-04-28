// liczby całkowite
var myAge = 33;
int myAge2 = 120;
int newAge = myAge2 + 100;
Console.WriteLine(newAge);

int myAge3 = int.MinValue;
uint myAge4 = uint.MaxValue;
long myAge5 = long.MaxValue;
ulong myAge6 = ulong.MaxValue;

// liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;
decimal myNumber3 = decimal.MaxValue;

// zmienne tekstowe
string name = "Jan";
string surname = "Kowalski";
string result = name + surname + newAge;
Console.WriteLine(result);
char myVar = 'c';
var result2 = name.ToArray();

// zmienne logiczne
bool isActive = true;
bool isActive2 = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);


