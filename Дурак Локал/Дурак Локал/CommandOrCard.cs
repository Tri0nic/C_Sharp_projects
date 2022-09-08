namespace Дурак_Локал_2;

public class CommandOrCard
{
    // Для Action1 проверяем, игрок ввел карту или команду и выполняем то, в зависимости от того что он ввел
    public  static void Check(int p)
    {
        string thrownCard = Console.ReadLine(); //Игрок вводит имя карты или действия
        try //игрок ввел команду
        {
            int act = int.Parse(thrownCard);
            if (act == 3)
            {
                GameActions.Action3(p);
            }
            else if (act == 4)
            {
                Game.action = Convert.ToString(act);
            }
            else
            {
                Console.WriteLine("Убедитесь, что вы ввели правильную команду");
                Check(p);
            }
        }
        catch //игрок ввел имя карты
        {
            Players.PlayersHands[Players.PlayersNames[p]].Remove(thrownCard); // убираем карту из руки
            Game.MaybeWillTake.Add(thrownCard);// добавляем карту в возможный забор отбивающимся игроком
            Game.RoundHistory += $"---> {Players.PlayersNames[p]} {(p == Game.N ? "кинул":"отбил")} {thrownCard} "; // Выводим историю на экран
            Console.WriteLine(Game.RoundHistory);   
        }
    }
}