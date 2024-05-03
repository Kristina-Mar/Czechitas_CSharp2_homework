namespace Lesson4_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.
            Console.WriteLine($"Current date and time: {DateTime.Now}");

            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.
            DateTime dateOfBirth = new DateTime(1990, 8, 28);
            int daysFromBirth = (DateTime.Now - dateOfBirth).Days;
            Console.WriteLine($"It has been {daysFromBirth} day since I was born.");

            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.
            List<string> listOfStrings = new List<string> { "holiday", "kitty", "bed", "opportunities", "weekend" };

            // 4. Smaž z tohoto listu libovolnou hodnotu.
            string wordToRemove = "weekend";
            listOfStrings.Remove(wordToRemove);


            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains
            string includedWord = "bed";
            if (listOfStrings.Contains(includedWord))
            {
                Console.WriteLine($"The list includes {includedWord}.");
            }
            else
            {
                Console.WriteLine($"The list does not include {includedWord}.");
            }

            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").
            Console.Write($"The list has {listOfStrings.Count} items: ");
            Console.Write(String.Join(", ", listOfStrings));
            Console.WriteLine();

            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).
            Dictionary<string, int> shoppingList = new Dictionary<string, int>
            {
                {"bread", 89 },
                {"beans", 58 },
                {"apples", 45 },
                {"broccoli", 49 },
                {"chocolate", 99 },
                {"crisps", 39 }
            };

            // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.
            string includedKey = "bagel";
            if (shoppingList.ContainsKey(includedKey))
            {
                Console.WriteLine($"{includedKey}:  {shoppingList[includedKey]}");
            }
            else
            {
                Console.WriteLine($"{includedKey} is not on the shopping list");
            }

            // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.
            KeyValuePair<string, int> bread = new KeyValuePair<string, int>("bread", 89);
            if (shoppingList.ContainsKey(bread.Key))
            {
                shoppingList[bread.Key] += bread.Value; 
            }
            else
            {
                shoppingList.Add(bread.Key, bread.Value);
            }

            // Writes out the shopping list.
            foreach (KeyValuePair<string, int> item in shoppingList)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
