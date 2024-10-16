using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        zad1();
        zad2();
        zad3();
      static void zad1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

            }
        }
        static void zad2() {
                int i = 0;
                
                while (i < 6) 
                {
                    Console.WriteLine("wartosc mniejsza od 6");
                    i++;
                }
            }
        static void zad3()
        {
            string tekst = "Lorem ipsum";
            foreach (char Znak in tekst)
            {
                Console.WriteLine(Znak);
            }
        }
    }
}


