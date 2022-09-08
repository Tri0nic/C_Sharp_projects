namespace Дурак_Локал_2;

public class MakeWinner
{
    // Выводим надпись с сообщением о победителе
    public static void Winner()
    {
        //Ищем игрока, у которого закончились карты
        string winner = null;
        for (int i = 0; i < Players.numCardsInHands.Count; i++)
        {
            if (Players.numCardsInHands[i] == 0)
            {
                winner = Players.PlayersNames[i];
            }
        }
        
        Console.WriteLine($"ПОБЕДИЛ {winner}, ПОЗДРАВЛЯЕМ!!!");
    }
}