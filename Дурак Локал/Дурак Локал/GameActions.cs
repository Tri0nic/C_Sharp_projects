namespace Дурак_Локал_2;

public class GameActions // действия на клавиатуре
{
    // Action1 - Выводит список карт игрока и предлагает ввести ему следующую команду
    public static void Action1(int p)
    {
        foreach (string card in Players.PlayersHands[Players.PlayersNames[p]])
        {
            Console.WriteLine(card);
        }
        Console.WriteLine($"Введите имя карты, которую хотите кинуть или {(p == Game.N ? "сделайте биту (4)":"заберите карты (3)")}");
        CommandOrCard.Check(p); // Вводим и проверяем, игрок ввел карту или команду, и выполняем то, в зависимости от того что он ввел
    }
    
    // Action3 - делает забор карт игроком
    public static void Action3(int p) 
    {
        for (int j = 0; j < Game.MaybeWillTake.Count; j++)
        {
            Players.PlayersHands[Players.PlayersNames[p]].Add(Game.MaybeWillTake[j]);
        }
        Console.WriteLine($"------ {Players.PlayersNames[p]} взял");
        
        Game.N += 1; // чтобы игрок взявший карты пропустил свой ход
        Game.M += 1;
        Game.action = "4"; // Для завершения хода
    }
    
    // Action4 - делает биту, завершает ход
    public static void Action4()
    {
        Game.action = "4";
    }

    // DoActions - выполняет все команды, переданные игроком
    public static void DoActions(string act, int walker)
    {
        act = Console.ReadLine(); //Считываем действие от ходящего игрока
        if (act == "1") //Показать свои карты и сделать действие
        {
            Action1(walker);
        }
        else if (act == "3") // беру
        {
            Action3(walker);
        }
        else if (act == "4") // бита
        {
            Action4();
        }
        else
        {
            Console.WriteLine("Убедитесь, что вы ввели правильную команду");
            DoActions(act, walker); // Рекурсия: пока игрок не введет подходящее действие, будет выводиться надпись выше
        }
    }
}