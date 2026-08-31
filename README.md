#Oppgave, uke 1
Et program som sjekker lengden på en tekststreng (f.eks. med .Length på en string-variabel)
og vurderer om det kan være et sterkt eller svakt passord.

string med input av kodeforslag
switch function for prompt variable

if word.Length < 8 = terribad
else
foreach char letter in pword
letter.IsUpper(x) letter.IsLower(x) letter.IsDigit(x) letter.IsPunctuation(x) or letter.IsSymbol(x)

score based on how many is true, ispunctuation and issymbol will have to be combined into IsSpecial
switch
case 1 2 >= parameters = not good enough needs x y
case 2 3 parameters = good enough but x would be nice
case 3 4 parameters = strong

//bonus: foreslå bedre passord basert på input og hvor mange parametre som ikke er oppfylt
