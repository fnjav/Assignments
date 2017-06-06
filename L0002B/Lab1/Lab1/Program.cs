// Filip Andersson Vestman	L0002B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1{
    class Program{
        static void Main(string[] args){
            int pris, betalt, rest = 0;     // Initierar variabler för mindre hårdkodning
            int[] valorLista = new int[] {500, 100, 50, 20, 10, 5, 1}; 
            String[] strValorListaP = new String[] {" Femhundralappar", " Hundralappar", " Femtiolappar", " Tjugolappar", " Tiokronor", " Femkronor", " Enkronor"};
            String[] strValorListaS = new String[] { " Femhundralapp", " Hundralapp", " Femtiolapp", " Tjugolapp", " Tiokrona", " Femkrona", " Enkrona" }; // En lista för plural och en för singular
           
            Console.Write("Välkommen!\n");  // Välkomstmeddelande
            Console.Write("Ange pris: ");
            pris = Convert.ToInt32(Console.ReadLine()); // Begär input från användaren, läser hela raden samt konverterar chars till int

            while (true) {                     // Evig loop ifall användaren betalar för lite
                Console.Write("Betalt: ");
                betalt = Convert.ToInt32(Console.ReadLine());
                rest = betalt - pris;         // Tar reda på resten efter varan är betald

                if (rest < 0) {
                    Console.WriteLine("Det där var {0} kr för lite, försök igen!\nPriset är: {1}", (pris - betalt), pris);  // {0} tar första variabeln, {1} andra och så vidare..
                } else {                    
                    break;              // bryter loopen
                }
            }

            Console.WriteLine("\nVäxel tillbaka:");            
            for (int i = 0; i < valorLista.Length; i++){    // Loopar igenom alla olika valörer 
                if (rest >= 2 * valorLista[i]) {            // Använder sig av listan med plural ifall rest är minst dubbelt så stor som den nuvarande valören
                    Console.WriteLine(rest / valorLista[i] + strValorListaP[i]);
                }else if (rest >= valorLista[i]){
                    Console.WriteLine(rest / valorLista[i] + strValorListaS[i]);
                }                 
                else {  // Ifall det blir 0 av någonting, till exempel pris 50 och du betalar 53, då hoppar den nu över 20, 10 och 5 istället för att skriva ut 0 på dem.
                    // do nothing
                } rest %= valorLista[i]; // Hoppar ett steg vidare bland valörerna, 1234 % 500 blir till exempel 234, medans 234 % 100 blir 34, 34 % 50 blir 34 och så vidare..
            } 
        }
    }
}
