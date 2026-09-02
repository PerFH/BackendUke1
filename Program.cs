using System.Reflection.PortableExecutable;
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
        string pword;
        int pwScore = 0;
        Random rng = new Random();
        string updatePrompt()
        {
            pword = getInput();
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
                        prompt = "That password is WEAK! Try again!";
                        hasUpper = false;
                        hasLower = false;
                        hasDigit = false;
                        hasSpecial = false;
                        break;
                    }
                case (>=8, true, true, true, true):
                    {
                    prompt = "That is a strong and secure password!";
                        hasUpper = false;
                        hasLower = false;
                        hasDigit = false;
                        hasSpecial = false;
                    break;
                    }
                default:
                    {
                        pwScoring();
                        Console.WriteLine($"Digit:{hasDigit}, Lowercase:{hasLower}, Uppercase:{hasUpper}, Special:{hasSpecial}\n" +
                        $"Your password satisfies {pwScore}/4 different symbol requirements for a secure password.");
                        pwUpgrade();
                break;
                    }
            }
            return prompt;

        }
        void pwScoring() //int
        {
            if (hasUpper) {
                pwScore ++;
            }
            if (hasLower) {
                pwScore ++;
            }
            if (hasDigit) {
                pwScore ++;
            }
            if (hasSpecial) {
                pwScore++;
            }

                    //må flyttes til et bedre sted, så man kan ivareta verdiene til bonus

                    //return pwScore;
        }
        void pwUpgrade()
        {
            //string pwordImproved = pword;
            if (!hasLower)
            {
                int findLower = rng.Next(97 ,122);
                char lowerAdd = (char)findLower;
                pword = pword + lowerAdd;
            }
            if (!hasUpper)
            {
                int findUpper = rng.Next(65, 90);
                char upperAdd = (char)findUpper;
                pword = pword + upperAdd;
            }
            if (!hasDigit)
            {
                foreach  (char character in pword)
                {
                    int numberAdd =+ character;
                    pword = pword + numberAdd;
                }
            }
            if (!hasSpecial)
            {
                string specials = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
                char specialAdd = specials[rng.Next(0, specials.Length)];
                pword = pword + specialAdd;
            }
            prompt = $"I have improved your password: {pword}";
                    hasUpper = false;
                    hasLower = false;
                    hasDigit = false;
                    hasSpecial = false;
        }
        string getInput()
        {
            string input = Console.ReadLine();
            return input;
        }
        while(true)
        Console.WriteLine(updatePrompt());

        /*void pwSuggest(int pwScoring)
        {
            if suggestQuery == y/yes then run
                switch (pwScoring(),hasLower, hasUpper, hasDigit, hasSpecial)
            {   //hvis uppercase mangler, og har lowercase
                case (1,true, false, false, false):
                    {
                        Console.WriteLine(char.ToUpper(pword[rng.Next(0, pword.Length)]));
                        break;
                    }
                case (1,false, true, false, false):
                    {
                        char letterToSwitch = char.ToLower(pword[rng.Next(0, pword.Length)]);
                        break;
                    }
                case (1, _, _, true, _):
                    {
                        "only digits are obsolete"
                        break; 
                    }
                case (1, _, _ )
            }    
        }*/
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