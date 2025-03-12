// See https://aka.ms/new-console-template for more information
Console.WriteLine("Wpisz 3 liczby naturalne");
int[] liczby = new int[3];
for (int i = 0; i < 3; i++)
{
    bool isValid = false;
    while (!isValid)
    {
        Console.Write($"Liczba {i + 1}: ");
string input = Console.ReadLine();
isValid = int.TryParse(input, out liczby[i]);
if (!isValid)
{
    Console.WriteLine("Nieprawidłowy format liczby. Spróbuj ponownie.");
}
                }
            }

            Console.WriteLine("Wprowadzone liczby to:");
Array.Sort(liczby);
foreach (int liczba in liczby)
{
    Console.WriteLine(liczba);
}
int a = liczby[0];
int b = liczby[1];
int c = liczby[2];
if (a *a + b *b == c* c)
    Console.WriteLine("Spelniaja trojke pitagorejska");
else Console.WriteLine("Nie spelniaja trojki pitagorejskiej");
