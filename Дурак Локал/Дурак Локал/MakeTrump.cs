namespace Дурак_Локал_2;

public class MakeTrump
{
    // Создаем козырь
    public static string TrumpName;
    public static void Trump()
    {
        Random rnd = new Random();
        int numTrump = rnd.Next(1, 5);
        switch (numTrump)
        {
            case 1:
                Console.WriteLine("Козырь: Черви");
                TrumpName = "Черви";
                break;
            case 2:
                Console.WriteLine("Козырь: Буби");
                TrumpName = "Буби";
                break;
            case 3:
                Console.WriteLine("Козырь: Пики");
                TrumpName = "Пики";
                break;
            case 4:
                Console.WriteLine("Козырь: Крести");
                TrumpName = "Крести";
                break;
        }
    }
}