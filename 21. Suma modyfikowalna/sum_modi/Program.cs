﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    =============================================
                    Treść zadania:
    =============================================
    Jako, że poznałeś/poznałaś już działanie pętli for, oraz działanie metod n możemy
    przejść do następnego poziomu. Tutaj również będziesz musiała/musiał wykorzystać tablicę i indeksy, które
    także już poznałeś/poznałaś. 

    Zatem...

    Twoim zadaniem jest stworzyć program który obliczy sumę tylu liczb ile poda użytkownik, czyli może np. 
    użytkownik chce zrobić tak: 4 + 4 + 2 albo 3 + 5 + 10 + 5 ... itd... Ogranicz jednak rozmiar swojej tablicy
    do 100 elementów. Ups... Już Ci podpowiedziałem. Tak, aby przechować te wszystkie liczby, które poda
    użytkownik musimy wykorzystać tablicę. Dlaczego? Bo nie wiesz ile liczb poda użytkownik!

    1. Stwórz klasę suma

    2. W funkcji main stwórz tablicę, do której użytkownik będzie wpisywał liczby, które chce zsumowac.
    Jeśli użytkownik wpisze "koniec" to program wywoła funkcje suma_modyfikowalne!

    3. Stwórz metodę suma_modyfikowalne, które przyjmie tablicę liczb, które wpisał użytkownik.

    4. Za pomocą pętli for w tej metodzie sumuj kolejne elementy aż do otrzymania wyniku. 
       Zastanów się jak rozwikłać problem warunku w pętli for. Mógłby brzmieć tak:
       "i < zlicz" gdzie zlicz to liczba elementów ile podał użytkownik do zsumowania.

       a więc propozycja: zmodyfikuj wygląd swojej metody suma_modyfikowalne i dodaj do niej argument:
       int zlicz czyli będzie tak: suma_modyfikowalne(int tablica, int zlicz). Zlicz będzie zwiększane
       za każdym razem gdy użytkownik poda liczbę. Teraz to zaimplementuj.

    5. Pamiętaj o stworzeniu obiektu aby odwołać się do swojej metody oczywiście z klasy iloczyn.

    6. Wyświetl wynik sumowania. Możesz dorzucić metodę void, która wypisze go, bądź skorzystać z klasycznego
    Console.Writeline... 

    =============================================
                 Utrwalisz sobie:
    =============================================
    - wszystko o tablicach jednowymiarowych
    - co to jest indeks w tablicy
    - jak działa pętla for, jak ją budujemy
    - co to metoda, klasa, obiekt?
*/

namespace sum_modi
{
    class Program
    {
        static void Main(string[] args)
        {

            // jeżeli wykonałeś bez problemu Iloczyn modyfikowalny, bez problemu poradzisz sobie z sumą modyfikowalną
            // :)
            Console.ReadLine();
        }
    }
}
