namespace Дурак_Локал_2;

public class CheckRange
{
    // Проверка на выход за рамки списка количества игроков
    public static void Check()
    {
        if (Game.M > Players.NumOfPlayers-1)
        {
            Game.M -= Players.NumOfPlayers;
        }
        if (Game.N > Players.NumOfPlayers-1)
        {
            Game.N -= Players.NumOfPlayers;
        }
    }
}