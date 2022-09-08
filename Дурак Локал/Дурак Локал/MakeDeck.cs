namespace Дурак_Локал_2;

public class Deck
{
    public static List<string> Deck36 = new List<string>();
    public static void MakeDeck36()
    {
        // Создаем колоду
        string[] masti = { "Черви", "Буби", "Пики", "Крести" };
        for (int i = 6; i < 15; i++)
        {
            int j = 0;
            foreach (var mast in masti)
            {
                switch (i)
                {
                    case 11:
                        Deck36.Add($"Валет {mast}");
                        j += 1;
                        break;
                    case 12:
                        Deck36.Add($"Дамма {mast}");
                        j += 1;
                        break;
                    case 13:
                        Deck36.Add($"Король {mast}");
                        j += 1;
                        break;
                    case 14:
                        Deck36.Add($"Туз {mast}");
                        j += 1;
                        break;
                    default:
                        Deck36.Add($"{i} {mast}");
                        j += 1;     
                        break;
                }
            }
        }
    }
}