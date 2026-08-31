using System.Runtime.CompilerServices;

namespace BackendUke1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("I am here to grade your password:");
        string prompt;
        bool hasUpper = false;
        bool hasLower = false;
        bool hasDigit = false;
        bool hasSpecial = false;
        string updatePrompt()
        {
            string pword = getInput();
            foreach (char letter in pword)
                {
                if (char.IsUpper(letter))

                    {
                    hasUpper = true;
                    }
                
                if (char.IsLower(letter))
                    {
                    hasLower = true;
                    }
                if (char.IsDigit(letter))
                    {
                    hasDigit = true;
                    }
                if (char.IsPunctuation(letter) || char.IsSymbol(letter))
                    {
                    hasSpecial = true;
                    }
                }

            switch (pword.Length, hasLower, hasUpper, hasDigit, hasSpecial)
            {
                case (<8, _, _, _, _):
                    {
                        prompt = "That password is WEAK! It can be hacked instantly";
                        break;
                    }
                default:
                    {
                        prompt = "Now we're getting somewhere...";
                        Console.WriteLine($"D:{hasDigit}, L:{hasLower}, U:{hasUpper}, S:{hasSpecial}");
                break;
                    }
            }
            return prompt;

        }
        string getInput()
        {
            string input = Console.ReadLine();
            return input;
        }
        while(true)
        Console.WriteLine(updatePrompt());
    }   
}

//Oppgave, uke 1
//Et program som sjekker lengden på en tekststreng (f.eks. med .Length på en string-variabel)
//og vurderer om det kan være et sterkt eller svakt passord

//string med input av kodeforslag
//switch function for prompt variable

//if word.Length < 8 = terribad
//else 
//foreach char letter in pword 
//letter.IsUpper(x) letter.IsLower(x) letter.IsDigit(x) letter.IsPunctuation(x) or letter.IsSymbol(x)
//score based on how many is true, ispunctuation and issymbol will have to be combined into IsSpecial
//switch
//case 1 2 >= parameters = not good enough needs x y
//case 2 3 parameters = good enough but x would be nice
//case 3 4 parameters = strong

//bonus: foreslå bedre passord basert på input og hvor mange parametre som ikke er oppfylt
//gjør om bokstavene til tall, del summen på lengden/randomnumber, og bruk dette til å anbefale passord forbedring
//mangler stor/liten bokstav, gjør om en av bokstavene til det som mangler,
//for spesialtegn så må vi konvertere en del randomnumber(1, pword.Length+1) via char og % int

//bonus: PW generator???


//              6         8           10          12          16
//numbers       instant   instant     instant     12m         6.5d
//lowerC        instant   2w          73Y         185kY       32bY
//mixed C+1+!   instant   132y        145kY       158mY       *tY
//
//