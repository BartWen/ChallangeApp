using System.Diagnostics.Metrics;

Console.WriteLine("Podaj liczbe:");

string number = Console.ReadLine();
char[] leters = number.ToArray();

int[] amount= new int[10];

Console.WriteLine("wynik dla liczby {0}", number);

for (int i = 0; i < amount.Length; i++)
{
    foreach (var leter in leters)
    {
        var leterToString = leter.ToString();
        var leterInt = int.Parse(leterToString);

        if (leterInt==i)
        {
            amount[i]++;
        }
    }
 Console.WriteLine("{0}=>{1}", i, amount[i]);
}



