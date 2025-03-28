int cardNo = 12;

    string cardName = cardNo switch
    {
        1 => "Ace",
        11 => "Jack",
        12 => "Queen",
        13 => "King",
        _ => cardNo.ToString()
    };
Console.WriteLine(cardName);