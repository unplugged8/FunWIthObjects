# FunWithObjects

* Dowod na to, ze nie wszystko jest obiektem w C#.
* Cel: 5.0 na koniec semestru :)

## Zrodlo:
* https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/unsafe-code
* dowod: "Pointer types don't inherit from object and no conversions exist between pointer types and object. Also, boxing and unboxing don't support pointers."
* ![image](https://github.com/unplugged8/FunWIthObjects/assets/77389165/a9915681-9e05-44b0-9cd5-c053d4ba4044)


## Wymagania:
* slowo 'unsafe" musi byc uzyte w glownym programie
* wlaczona opcja Properties -> Build -> Unsafe code -> Allow code that uses the 'unsafe' keyword to compile

## Metoda na sprawdzenie czy pointer jest obiektem:
Nie mozna sprawdzic czy pointer jest obiektem uzywajac metody 'ptr is object' ponieważ:
* pointer nie jest obiektem
* kod bledu 'CS0244' - The is and as operators are not valid for use on pointer types.
* ![image](https://github.com/unplugged8/FunWIthObjects/assets/77389165/aaae453b-d33c-4fd2-af45-9d1740812730)

