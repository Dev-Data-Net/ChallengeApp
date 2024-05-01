// tablica
// I sposób
int[] grades = new int[5];
string[] dayOfWeeks = new string[7];
dayOfWeeks[0] = "poniedziałek";
dayOfWeeks[1] = "wtorek";
dayOfWeeks[2] = "środa";
dayOfWeeks[3] = "czwartek";
dayOfWeeks[4] = "piątek";
dayOfWeeks[5] = "sobota";
dayOfWeeks[6] = "niedziela";
//Console.WriteLine(dayOfWeeks[2]);

// II sposób
string[] dayOfWeeks2 = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };
//Console.WriteLine(dayOfWeeks2[1]);

// pętla "for"
for (int i = 0; i < dayOfWeeks.Length; i++)
{
    Console.WriteLine(dayOfWeeks2[i]);
}