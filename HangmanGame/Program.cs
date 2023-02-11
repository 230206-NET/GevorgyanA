
Console.WriteLine("Let's play a Hangman. You have a 5 attempts to guess the word! Please input a word!");

string wordToGuess = "";


while(true) {
wordToGuess = Console.ReadLine()!;
if(string.IsNullOrWhiteSpace(wordToGuess)){
        Console.WriteLine("Please enter only word!");
        continue;
    }
    break;
}

string copy=wordToGuess;
string currentGuess = new string('_',wordToGuess.Length);
int attempts=5;
int wrongAttempts=0;

while(true){
    if(string.Compare(copy,currentGuess)==0) {
        Console.WriteLine("you got it, congrats!");
        break;
    }

    if (wrongAttempts==5){
        Console.WriteLine("**** HAMGMAN **** You lost!");
        break;
    }

    if (attempts<1){
        Console.WriteLine("You have exceeded the number of attempts");
        Console.WriteLine("whomp whomp.. perhaps next time");
        break;
    }

    Console.WriteLine($"Please guess a letter! You have {attempts} attempts");
    string letter = Console.ReadLine()!;
    char m;
    if(!char.TryParse(letter,out m))
    {
        Console.WriteLine("Wrong entry!");
        continue;
    }
    if(string.IsNullOrWhiteSpace(letter)){
        Console.WriteLine("Please enter only letter!");
    }

    if (wordToGuess.IndexOf(letter)<0){
        Console.WriteLine("Nice try!");
        wrongAttempts++;
        switch(attempts){
            case 1: 
            Console.WriteLine(" _____");
            Console.WriteLine("|    _|_");
            Console.WriteLine("|    |_|");
            Console.WriteLine("|    _|_");
            Console.WriteLine("|     |");
            Console.WriteLine("|    / \\");
            Console.WriteLine("|       ");
            break;
            
            case 2:
            Console.WriteLine(" _____  ");
            Console.WriteLine("|    _|_");
            Console.WriteLine("|    |_|");
            Console.WriteLine("|    _|_");
            Console.WriteLine("|     | ");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            break;

            case 3: 
            Console.WriteLine(" _____  ");
            Console.WriteLine("|    _|_");
            Console.WriteLine("|    |_|");
            Console.WriteLine("|    _|_");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            break;

            case 4: 
            Console.WriteLine(" _____  ");
            Console.WriteLine("|    _|_");
            Console.WriteLine("|    |_|");
            Console.WriteLine("|     | ");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            break;

            case 5: 
            Console.WriteLine(" _____");
            Console.WriteLine("|    _|_");
            Console.WriteLine("|    |_|");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            Console.WriteLine("|       ");
            break;
        }
    }
    
    while(wordToGuess.IndexOf(letter)>=0){
        Console.WriteLine("Well done! You guessed the letter");
        int ind = wordToGuess.IndexOf(letter);
        wordToGuess=wordToGuess.Remove(ind,1).Insert(ind," ");
        currentGuess = currentGuess.Remove(ind,1).Insert(ind,letter);      
    }

    Console.WriteLine(currentGuess);
    attempts--;
}
        