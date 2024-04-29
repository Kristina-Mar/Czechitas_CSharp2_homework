namespace Lesson3_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tento ukol se opravuje sam. Kazdy priklad obsahuje kontrolni vypisy, ktere overi, ze jsi dosla k spravnemu vysledku.
            // Vsechny priklady take obsahuji nejakou predpripravenou promennou, kam ulozis vysledek svoji prace.

            int padding = 45;
            string text = @"""Hurry up, boy!"" shouted Uncle Vernon from the kitchen. ""What are you
doing, checking for letter bombs?"" He chuckled at his own joke.

Harry went back to the kitchen, still staring at his letter. He handed
Uncle Vernon the bill and the postcard, sat down, and slowly began to
open the yellow envelope.

Uncle Vernon ripped open the bill, snorted in disgust, and flipped over
the postcard.

""Marge's ill,"" he informed Aunt Petunia. ""Ate a funny whelk. --.""

""Dad!"" said Dudley suddenly. ""Dad, Harry's got something!""

Harry was on the point of unfolding his letter, which was written on the
same heavy parchment as the envelope, when it was jerked sharply out of
his hand by Uncle Vernon.

""That's mine!"" said Harry, trying to snatch it back.

""Who'd be writing to you?"" sneered Uncle Vernon, shaking the letter open
with one hand and glancing at it. His face went from red to green faster
than a set of traffic lights. And it didn't stop there. Within seconds
it was the grayish white of old porridge.";

            // Nez zacnes volat nejake stringove funkce na nejake stringove promenne, nezapomen overit, ze obsahuje smysluplnou hodnotu. Vysledek uloz do promenne 'textMaSmysl'.
            bool textMaSmysl = false;
            if (!String.IsNullOrEmpty(text) && !String.IsNullOrWhiteSpace(text))
            {
                textMaSmysl = true;
            }
            Console.WriteLine("Text dava smysl - ".PadRight(padding) + (textMaSmysl == true));

            // Do promenne 'delkaTextu' uloz celkovou delku uryvku z knizky.

            string ocistenyText = text.Replace("\r\n", " ");
            // Vyčistí prázdné řádky (mezery mezi odstavci), které se počítají nesprávně jako 4 znaky.
            int delkaTextu = ocistenyText.Length;
            Console.WriteLine("Delka textu je spravna - ".PadRight(padding) + (delkaTextu == 1001));

            // Do promenne 'oddelovac' vloz text, ktery se sklada pouze z pomlcek a jeho delka je presne 20. Pouzij k tomu konstruktor typu string.

            string oddelovac = new string('-', 20);
            Console.WriteLine("Oddelovac ma 20 pomlcek - ".PadRight(padding) + (oddelovac == "--------------------"));

            // Pozmen nasledujici porovnani textu tak, aby se do konzole vypisovalo True, aniz bys menila hodnoty promennych

            string jmeno1 = "Katka";
            string jmeno2 = "katka";
            bool jeStejne = String.Equals(jmeno1, jmeno2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Obe promenne obsahuji stejne jmeno - ".PadRight(padding) + jeStejne);

            // Zjisti, jestli je v textu zminka o obtloustle "tete" Harryho. Jmenuje se Marge. Vysledek uloz do promenne 'piseSeOMarge';

            bool piseSeOMarge = text.Contains("Marge"); // Vlastní jméno musí být velkým písmenem na začátku.
            Console.WriteLine("V textu se zminuje Harryho 'teticka' - ".PadRight(padding) + (piseSeOMarge == true));

            // Zjisti, jestli je text spravne ukonceny interpunkci. Vysledek uloz do promenne 'jeSpravneUkoncen'.

            char posledniZnak = text[^1];
            bool jeSpravneUkoncen = posledniZnak == '.' || posledniZnak == '!' || posledniZnak == '?';
            Console.WriteLine("Text je spravne ukoncen interpunkci - ".PadRight(padding) + (jeSpravneUkoncen == true));

            // Pomoci abecedniho porovnavani zjisti, ktery z nasledujicich textu je podle abecedy prvni a jeho hodnotu prirad do promenne 'prvni'.

            string blabol1 = "abbc";
            string blabol2 = "acbc";
            string blabol3 = "abbb";
            string prvni;
            if (String.Compare(blabol1, blabol2) <= 0)
            {
                if (String.Compare(blabol1, blabol3) <= 0)
                {
                    prvni = blabol1;
                }
                else
                {
                    prvni = blabol3;
                }
            }
            else
            {
                if (String.Compare(blabol2, blabol3) <= 0)
                {
                    prvni = blabol2;
                }
                else
                {
                    prvni = blabol3;
                }
            }

            Console.WriteLine("Prvni v abecede je blabol3 - ".PadRight(padding) + (prvni == blabol3));

            // Najdi prvni rozkazovaci vetu v textu a uloz ji do promenne 'veta' bez vykricniku a uvozovek.

            int poziceVykricniku = text.IndexOf('!');
            string oseknutyZbytekTextu = text.Substring(0, poziceVykricniku); // Odstraní se text počínající vykřičníkem.
            int poziceZacatkuVety = 0;
            if (oseknutyZbytekTextu.Contains('.') || oseknutyZbytekTextu.Contains('?'))
                // Pokud zbývající text neobsahuje tečku ani otazník, rozkazovací věta je první, index začátku zůstává 0.
            {
                int poziceTecky = oseknutyZbytekTextu.LastIndexOf('.');
                int poziceOtazniku = oseknutyZbytekTextu.LastIndexOf('?');
                if (poziceOtazniku > poziceTecky)
                {
                    poziceZacatkuVety = poziceOtazniku;
                }
                else
                {
                    poziceZacatkuVety = poziceTecky;
                }
            }
            while (!Char.IsLetter(oseknutyZbytekTextu[poziceZacatkuVety]))
            // Aby na začátku bylo písmeno, nikoliv např. uvozovky jako zde.
            {
                poziceZacatkuVety++;
            }
            string veta = oseknutyZbytekTextu.Substring(poziceZacatkuVety);
            Console.WriteLine("Prvni rozkazovaci veta je 'Hurry up, boy' - ".PadRight(padding) + (veta == "Hurry up, boy"));

            // Zjisti, kolikrat se v textu vyskytuje slovo "and" bez ohledu na velikosti prvniho pismenka a vysledek uloz do promenne 'pocetAnd'.
            // Abych vam to zjednodusil, muzete se spolehnout, ze tato anglicka spojka bude v textu vzdy obklopena mezerou na kazde strane.
            // Tim se snadno vylouci jakekoliv vyskyty "and" v ramci jinych slov.

            int pocetAnd = 0;
            string zbytekTextu = text;
            while (zbytekTextu.Contains(" and ", StringComparison.OrdinalIgnoreCase))
            {
                // Když text obsahuje end, počet se zvýší o jedna a část textu od and dále se odstraní.
                pocetAnd++;
                zbytekTextu = zbytekTextu.Substring(0, zbytekTextu.LastIndexOf(" and ", StringComparison.OrdinalIgnoreCase));
            }
            Console.WriteLine("Text obsahuje slovo 'and' celkem 5x' - ".PadRight(padding) + (pocetAnd == 5));
        }
    }
}
