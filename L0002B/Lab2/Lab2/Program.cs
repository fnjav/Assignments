// Filip Andersson Vestman	L0002B

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab2 {
    class Program {
        static void Main(string[] args) {
            List<Person> personList = new List<Person>(); // Lista med Person där säljare sparas
            String tmp, s49="", s99="", s199="", s200="", result;   // Initierar basen för strängarna för de olika kategorierna
            int counter49 = 0, counter99 = 0, counter199 = 0, counter200 = 0; // Används för att räkna antal säljare i varje kategori
            Person tmpP; // Temporär Person som används för att lägga till säljare i listan
            

            Console.WriteLine("Välkommen! Var vänlig lägg till sex nya säljare");

            while (true) {      // Loopar till det är 6 säljare
                Console.Write("Ange namn: ");
                tmp = getInput();
                tmpP = new Person(tmp);

                Console.Write("Ange personnummer: ");
                tmp = getInput();
                tmpP.pnr = tmp;

                Console.Write("Ange distrikt: ");
                tmp = getInput();
                tmpP.district = tmp;

                Console.Write("Ange antal sålda: ");
                int tmpInt = Convert.ToInt32(getInput()); // Sparar antal sålda som integer så det går att jämföra lättare
                tmpP.antalS = tmpInt;                     

                personList.Add(tmpP);

                if (personList.Count == 6) {    // Bryter loopen när det är 6st säljare
                    break;
                }
            }

            //Sortera lista
            personList.Sort((x, y) => x.antalS.CompareTo(y.antalS)); // Sorterar från minsta till största genom att använda sig av get-metoden för antalS           

            //Dela in i fyra olika strängar
            for (int i = 0; i < personList.Count; i++) {    // Loopar igenom hela listan
                tmpP = personList[i];       // Plockar ut pekare till den aktuella säljaren
                if (tmpP.antalS <= 49) {        // Bestämmer kategori för säljaren samt inkrementerar räknaren för kategorin
                    counter49++;
                    s49 += printPerson(tmpP);
                }else if (tmpP.antalS <= 99) {
                    counter99++;
                    s99 += printPerson(tmpP);                   
                } else if (tmpP.antalS <= 199) {
                    counter199++;
                    s199 += printPerson(tmpP);
                } else if (tmpP.antalS >= 200) {
                    counter200++;
                    s200 += printPerson(tmpP);
                }
            }

            if (counter49 > 0) {                        // Lägger till texten som beskriver hur många säljare det finns i varje kategori
                s49 += String.Format("{0} säljare har nått nivå 1: 0-49 artiklar\n\n", counter49);
            }
            if (counter99 > 0) {
                s99 += String.Format("{0} säljare har nått nivå 2: 50-99 artiklar\n\n", counter99);
            }
            if (counter199 > 0) {
                s199 += String.Format("{0} säljare har nått nivå 3: 100-199 artiklar\n\n", counter199);
            }
            if (counter200 > 0) {
                s200 += String.Format("{0} säljare har nått nivå 4: 200+ artiklar\n\n", counter200);
            }

            // Skapar den slutgiltiga strängen för resultatet. (-15 används för att placera texten åt vänster, det blev snyggast i mina tester med -15. Kan bli knasigt med väldigt långa namn dock)
            result = String.Format("{0,-15}{1,-15}{2,-15}{3,-15}\n{4}{5}{6}{7}", "Namn", "Personnummer", "Distrikt", "Antal", s49, s99, s199, s200);

            String path = @"..\..\..\Resultat.rtf"; // Skriver till mappen där Lab2-mappen samt lab2.sln finns          
            System.IO.File.WriteAllText(path, result);

            Console.WriteLine(result);  // Visar resultat för användaren
        }


        public static String getInput() {       // Liten metod som returnerar input, slipper kodupprepning tack vare denna
            return Console.ReadLine();
        }

        public static String printPerson(Person p) {    // Samam som ovan. Denna metod returnerar datan från Personen        
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}\n",p.name, p.pnr, p.district, p.antalS.ToString());
        }
        
    }

    class Person {  // Person-klass för listan
        public String name { get; private set; }    // I det här fallet är det onödigt med private set, men ville testa lite hur det fungerar då c# och detta är nytt för mig
        public String pnr { get; set; }             // Namn tilldelas vid skapandet, om något borde kanske personnumret gjort det istället.
        public String district { get; set; }
        public int antalS { get; set; }    

        public Person(String name){
            this.name=name; 
        }
        
    }
}
