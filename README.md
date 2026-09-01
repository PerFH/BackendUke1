# BACKEND
# Oppgave, uke 1
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

# Bonus
generere manglende kode for å oppfylle alle 4 parametrene
foreslå bedre passord med input og legg til manglende symboler for å oppfylle alle krav
# Pseudokode for generering
lage random

if !hasLower
    lowerAdd = rng (97, 122) 
    string actualSuggest = pword + lowerAdd
    hasLower = true
if !hasUpper...
if !hasDigit...
    if !hasSpecial
    string specials = "!"#$%&'()*+,-./:;<=>?@[\]^_`{|}~"
        rng.pickoneofthespecials
        add it
        hasSpecials = true





values for special chars:
32 to 47:  (space) ! " # \$ % & ' ( ) * + , - . /
58 to 64: : ; < = > ? @
91 to 96: `[ \ ] ^ _ ``
123 to 126: { | } ~

tall: 0-9
lowercase: 97-122
uppercase: 65-90