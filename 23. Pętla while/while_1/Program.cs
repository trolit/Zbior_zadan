﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Informacja:
 *  Omówienie pętli while znajdziesz tutaj, ale również i w zadaniu 5 Tablice cz1 troszkę napomknąłem o nich :)

    =================================
              Treść zadania:
    =================================
    Wiemy już na czym polega pętla for. Teraz czas zapoznać się z kolejną pętlą czyli while. Pętla którą
    dziś się zajmiemy ma coś wspólnego z pętlą for! Co? A już mówię. Obie pętle zanim wejdą do bloku
    instrukcji to sprawdzają warunek, czy jest prawdziwy, jeśli tak to spoko a jeśli warunek jest
    fałszywy to po prostu omijamy pętlę albo nie wykonujemy kolejny raz. W ranach informacji: potem
    zapoznasz się z pętlą, która najpierw wykonuje instrukcje a potem sprawdza warunek (może wiesz już jaka)
    ale to potem, żeby nie mącić. :)

    budowa pętli while nie należy do skomplikowanych, po prostu mamy:

    while( warunek )
    {
        instrukcje...
        instrukcje....
    }

    ale to pewnie już wiesz, tylko masz problem z zastosowaniem tego. :) 
    tak naprawdę to jest wszystko co można powiedzieć, możemy chyba przejść do ćwiczenia.....

    1. Stwórz klasę Testy
    2. Stwórz metodę Petla()   
    3. W metodzie Petla() poproś uzytkownika o liczbe, a następnie napisz pętlę while, która  wypisze wszystkie 
    liczby od niej mniejsze. Warunek jest taki ze podana liczba nie moze byc wieksza niz 19. 

    przyklad:
    Podaj liczbe:
    5
    5
    4
    3
    2
    1
    0
    Wszystkie mniejsze elementy wypisane poprawnie!

    4. Stwórz obiekt w dowolny sposób, a następnie wywołaj metodę petla().
    5. Przetestuj ją.


    =================================
                 Część II. 
    =================================
    Skoro udało Ci się skomponować powyższą metodę, może udoskonalnmy program, aby jeszcze przećwiczyć
    manipulowanie pętlą while, okej? A więc... Do metody, którą masz dorzuć drugą pętlę while, która 
    z kolei wypisze liczby na odwrót czyli jak np. podasz 18 to ona wypisze 1. 2. 3 itd... aż do 18!
    Pomyśl jaki warunek dać, jak to zrobić. :) 

    przyklad:
    Podaj liczbe
    6
    0
    1
    2
    3
    4
    5
    6

    ==================================================================
    A więc do zapamiętania masz :
    - jak jest zbudowana pętla while
    - jak działa petla while
    ==================================================================
    
    PS: Nikt Ci nie powie gdzie masz jakiej pętli użyć, to tylko i wyłączenie zależy od Twojego
    doświadczenia programistycznego i pomysłowości. :) Po prostu trzeba pomyśleć i przewidzieć
    jak chcesz żeby Twój kod działał.
*/
namespace while_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
