namespace Дурак_Локал_2;

public class Players
{
    // Добавляем игроков
    public static int NumOfPlayers;
    public static List<string> PlayersNames = new List<string>();
    public static void AddPlayersNames()
    {
        Console.WriteLine("Введите количество игроков: ");
        NumOfPlayers = int.Parse(Console.ReadLine());
        
        for (int i = 1; i < NumOfPlayers+1; i++)
        {
            Console.WriteLine($"Введите имя игрока {i}: ");
            string name = Console.ReadLine();
            PlayersNames.Add(name);
        }
    }
    
    // Создаем руки игроков
    public static Dictionary<string, List<string>> PlayersHands = new Dictionary<string, List<string>>();
    public static void MakePlayersHands()
    {
        for (int i = 0; i < Players.NumOfPlayers; i++)
        {
            PlayersHands[PlayersNames[i]] = new List<string>();
        }
    }
    
    // Заполняем руки игроков
    public static void FillPlayersHands()
    {
        for (int i = 0; i < NumOfPlayers; i++)
        {
            while (Deck.Deck36.Count!=0 && PlayersHands[PlayersNames[i]].Count <6)
            {
                Random rnd = new Random();
                int numCard = rnd.Next(0, Deck.Deck36.Count);
                PlayersHands[PlayersNames[i]].Add(Deck.Deck36[numCard]);
                Deck.Deck36.RemoveAt(numCard);
            }
        }
    }
    
    // Проверяем, сколько карт у каждого игрока в руке
    public static List<int> numCardsInHands = new List<int>();
    public static void CheckNumOfCardsInPlayersHands()
    {
        numCardsInHands = new List<int>();
        for (int j = 0; j < PlayersHands.Count; j++)
        {
            numCardsInHands.Add(PlayersHands[PlayersNames[j]].Count);
        }
    }
}