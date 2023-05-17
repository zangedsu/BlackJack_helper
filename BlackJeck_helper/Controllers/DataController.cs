using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace BlackJack_helper.Controllers;
    public class DataController
    {
    private const string separator = "##################################";
    public string ExportFileName { get; set; } = "Export.txt";

    private MainController _mainController;

    public DataController(MainController mainController) {  _mainController = mainController; }

    public void SaveDataToFile()
    {
        //карты оппонентов
        var opponentsDeck = from c in _mainController.OpponentsTable.OpponentsDeck.Cards
                            where c.CardsCount > 0
                            select "* Номинал: " + c.Name + " Количество: " + c.CardsCount;
        string opponentsCards = string.Join("\n", opponentsDeck);

        //карты диллера
        var dealerDeck = from c in _mainController.DealerTable.DealerDeck.Cards
                         where c.CardsCount > 0
                         select "* Номинал: " + c.Name + " Количество: " + c.CardsCount;
        string dealerCards = string.Join("\n", dealerDeck);

        //карты пользователя
        var userDeck = from c in _mainController.UserTable.UserDeck.Cards
                         where c.CardsCount > 0
                         select "* Номинал: " + c.Name + " Количество: " + c.CardsCount;
        string userCards = string.Join("\n", userDeck);


        string data = $"{separator}\n" +
            $"ЭКСПОРТ ДАННЫХ {DateTime.Now}\n" +
            $"{separator}\n" +
            $"КАРТЫ НА СТОЛЕ ОППОНЕНТОВ\n" +
            $"{opponentsCards}\n" +
            $"{separator}\n" +
            $"КАРТЫ НА СТОЛЕ ДИЛЛЕРА\n" +
            $"{dealerCards}\n" +
            $"{separator}\n" +
            $"КАРТЫ НА СТОЛЕ ПОЛЬЗОВАТЕЛЯ\n" +
            $"{userCards}\n" +
            $"{separator}\n" +
            $"КАРТ В КОЛОДЕ ОСТАЛОСЬ: {_mainController.Deck.GetAllCardsCount()}\n" +
            $"{separator}\n" +
            $"ОЧКОВ У ПОЛЬЗОВАТЕЛЯ: {_mainController.UserPoints}\n" +
            $"{separator}\n" +
            $"ПОДХОДЯЩИХ КАРТ (без учета неизвестной): {_mainController.MathchingCardsCount}\n" +
            $"{separator}\n" +
            $"ВЕРОЯТНОСТЬ ВЫТЯГИВАНИЯ ПОДХОДЯЩЕЙ КАРТЫ: {_mainController.Result}";
        // полная перезапись файла 
        using (StreamWriter writer = new StreamWriter(ExportFileName, false))
        {
             writer.WriteLineAsync(data);
        }
        MessageBox.Show($"Данные сохранены в файл {ExportFileName} в корневой папке программы");
    }
}

