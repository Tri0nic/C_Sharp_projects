namespace Дурак_Локал_2;

class Program
{
    static void Main()
    { 
        Players.AddPlayersNames(); // Добавляем игроков
        Deck.MakeDeck36(); // Создаем колоду из 36 карт
        MakeTrump.Trump(); // Выбираем козырь
        Players.MakePlayersHands(); // Создаем руки игроков
        Players.FillPlayersHands(); // Заполняем руки игроков
        Game.GameProcess(); // Запускаем игру
    }
}