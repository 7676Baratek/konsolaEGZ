class Program
{
    static void Main(string[] args)
    {
        int liczba1,liczba2;
        int nwd;

        Console.Write("Podaj 1 liczbe: ");
        int.TryParse(Console.ReadLine(), out liczba1);
        Console.Write("Podaj 2 liczbe: ");
        int.TryParse(Console.ReadLine(), out liczba2);

        nwd = znajdzNWD(liczba1, liczba2);

        Console.WriteLine($"NWD liczb {liczba1} {liczba2} to : {nwd}");

    }

    static int znajdzNWD(int liczba1, int liczba2)
    {
        int nwd = 0;
        bool czyKoniec = true;

        while (czyKoniec == true)
        {
            if (liczba1 == liczba2)
            {
                nwd = liczba1;
                czyKoniec = false;
            }
            else if (liczba1 > liczba2)
            {
                liczba1 = liczba1 - liczba2;
            }
            else
            {
                liczba2 = liczba2 - liczba1;
            }
        }

        return nwd;
    }
}