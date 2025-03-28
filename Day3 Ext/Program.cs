int cardNo = 12;
string suite = "Hearts";

string cardName = cardNo switch
    {
        1 => "Ace",
        11 => "Jack",
        12 => "Queen",
        13 => "King",
        _ => cardNo.ToString()
    };
Console.WriteLine(cardName);

string cardName2 = (cardNo, suite) switch
    {
        (1, "Hearts") => "Ace of Hearts",
        (11, "Hearts") => "Jack of Hearts",
        (12, "Hearts") => "Queen of Hearts",
        (13, "Hearts") => "King of Hearts",
        (_, "Hearts") => cardNo.ToString() + " of Hearts",
        (1, "Diamonds") => "Ace of Diamonds",
        (11, "Diamonds") => "Jack of Diamonds",
        (12, "Diamonds") => "Queen of Diamonds",
        (13, "Diamonds") => "King of Diamonds",
        (_, "Diamonds") => cardNo.ToString() + " of Diamonds",
        (1, "Clubs") => "Ace of Clubs",
        (11, "Clubs") => "Jack of Clubs",
        (12, "Clubs") => "Queen of Clubs",
        (13, "Clubs") => "King of Clubs",
        (_, "Clubs") => cardNo.ToString() + " of Clubs",
        (1, "Spades") => "Ace of Spades",
        (11, "Spades") => "Jack of Spades",
        (12, "Spades") => "Queen of Spades",
        (13, "Spades") => "King of Spades",
        (_, "Spades") => cardNo.ToString() + " of Spades",
        (_, _) => "Unknown"
    };
Console.WriteLine(cardName2);

char ch = 'a';
if ( ch is 'a' or 'e' or 'i' or 'o' or 'u' )
{
    Console.WriteLine("This is Vowel");
}
else
{
    Console.WriteLine("Not Vowel");
}

int [] arr = new int [5];
int ind = 2;
arr [0] = 1;
arr [2-1] = 2;
arr [ind] = 3;
arr [ind * 2] = 4;

//Console.WriteLine(arr [0]);
//Console.WriteLine(arr [1]);
//Console.WriteLine(arr [2]);
//Console.WriteLine(arr [3]);
//Console.WriteLine(arr [4]);

int start = 0;
int end = 5;

CSM:  if (start < 5 ) // start < arr.Length
{
    Console.WriteLine($"IF: Answer is {start}");
    start++;
    goto CSM;
}

int co = arr.Length;
for (int i = 0; i < co; i++ )
{
    Console.WriteLine($"FOR: Answer is {arr [i]}");
}



