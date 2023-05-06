// See https://aka.ms/new-console-template for more information
using PickRandomCards;

Console.Write("Wpizs liczbę generowanych kart: ");
string line = Console.ReadLine();
if(int.TryParse(line ,out int numberOfCards))
{
    string[] tab = CardPicker.PickSomeCards(numberOfCards);
    foreach(string card in tab)
    {
        Console.WriteLine(card);
    }
}
else
{
    Console.WriteLine("Incorect value");
}
