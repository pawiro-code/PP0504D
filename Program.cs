using System;

public class Program
{
    static string printfloat(float v)
    {
        return BitConverter.ToString(BitConverter.GetBytes(v));
    }
    static void Main()
    {

      int n = int.Parse(Console.ReadLine());
        string[] tab2 = new string[n];
        for (int i = 0; i < n; i++)
        {
           string wynik = printfloat(float.Parse(Console.ReadLine()));
           string[] tab = wynik.Split('-');
            wynik = "";
            for (int j = tab.Length - 1; j >= 0; j--)
            {
                if (tab[j][0] == '0')
                {
                    wynik += tab[j][1];
                }
                else
                {
                    wynik += tab[j];
                }
                if (j > 0)
                {
                    wynik += " ";
                }
            }
                tab2[i] = wynik.ToLower();
        }
        for (int i = 0;i < n; i++)
        {
            Console.WriteLine(tab2[i]);
        }

    }

        
    }
