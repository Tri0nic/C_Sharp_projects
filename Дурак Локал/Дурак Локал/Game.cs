namespace Дурак_Локал_2;

public class Game
{
    static Random rnd = new Random();
    //int walker = rnd.Next(1, Players.NumOfPlayers+1); // выбираем кто будет ходить первым
    public static int N = rnd.Next(0, Players.NumOfPlayers); // выбираем кто будет ходить первым // Индекс нападающего игрока
    public static int M = N + 1; // Индекс защищающегося игрока
    public static string RoundHistory; // Текстовая история раунда
    public static List<string> MaybeWillTake; // возможная бита/забор
    public static string action = "0"; // Начальное значение параметра, отвечающего за действие игрока
    public static void GameProcess()
    {
        Console.WriteLine("1 - Показать свои карты и кинуть карту, 3 - беру, 4 - бита"); // Управление
        Players.CheckNumOfCardsInPlayersHands(); // Это нужно для массива numCardsInHands, проверяем, сколько карт в руках игроков
        
        while (Players.numCardsInHands.All(s => s != 0)) // Пока у одного из игроков не закончатся карты:
        {
            RoundHistory = null;
            MaybeWillTake = new List<string>();
            int walker; // игрок, который сейчас ходит
            int pp = 0; // индекс для определения нападающего/защищающегося
            
            CheckRange.Check();// Проверка на выход за рамки списка количества игроков

            while (action != "4") // Пока не бита, делай:
            { 
                walker = pp % 2 == 0 ? N : M; // Проверяем, игрок сейчас нападает или отбивается

                Console.WriteLine($"------ {Players.PlayersNames[walker]} {(walker == N ? "нападает":"отбивается")}");
                GameActions.DoActions(action, walker); //выполняет все команды, переданные игроком
                
                pp += 1; // меняем на отбивающего/нападающего
            }
            N += 1; // меняем нападающего игрока
            M += 1; // меняем защищающегося игрока
            Players.FillPlayersHands(); // заполняем руки
            Players.CheckNumOfCardsInPlayersHands(); // считаем, сколько карт в руке каждого игрока
            action = "0"; // Начальное значение параметра, отвечающего за действие игрока
        }
        MakeWinner.Winner(); // Выводим надпись с сообщением о победителе
    }
}