using System;

namespace ObjectCheckExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadeklarowanie  pointer (ptr) (unsafe context)
            unsafe
            {
                int ocena = 5;
                int* ptr = &ocena;

                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("--------------------------- Czy wszystko jest obiektem w C#? ------------------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("-----------------------------------------Nie, nie wszystko :) -------------------------------------------------");
                Console.WriteLine($"\nOcena jaką dostane jesli pointer nie jest obiektem: {ocena} :)");
                Console.WriteLine($"\nTa ocena {ocena} jest przechowywana w pamieci pod adresem {(int)ptr}, ktory widzimy dzieki pointer ptr i mozemy ja wyswietlic takze uzywajac pointer ptr: {*ptr}");
                Console.WriteLine("\nPointer mozemy uzywac tylko po uprzednim dodaniu slowa 'unsafe' i po wlaczeniu opcji w:");
                Console.WriteLine("\nProperties -> Build -> Unsafe code -> Allow code that uses the 'unsafe' keyword to compile.");
                Console.WriteLine("\nNiestety nie mozna sprawdzic czy pointer jest obiektem uzywajac 'ptr is object',"); 
                Console.WriteLine("\nponiewaz pointer nie jest obiektem i zostanie wyswietlony blad:\n\n'CS0244' - The is and as operators are not valid for use on pointer types. ");
                Console.WriteLine("\nZrodlo: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/unsafe-code");
                Console.WriteLine("\nDefinicja: \n\nPointer types don't inherit from object and no conversions exist between pointer types and object. \n\nAlso, boxing and unboxing don't support pointers.");
                Console.WriteLine("\n\n-------------------------------------------- Dziekuje :) ------------------------------------------------------");

                //Odkomentowac ponizszy kod i najechac kursorem na ptr
                //Console.WriteLine(ptr is object); // CS0244 ptr is pointer

                //Odkomentowac ponizszy kod i najechac kursorem na ptr
                //bool b = ptr is object;   // CS0244 ptr is pointer  

                Console.ReadKey();
            }
        }
    }
}