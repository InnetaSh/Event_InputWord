//Создайте консольное приложение на C#, в котором пользователь может вводить сообщения. 
//Реализуйте событие, которое срабатывает, когда сообщение содержит слово "событие". 
//При срабатывании события, в консоль должно выводиться сообщение "Событие произошло!"

//Инструкция:

//Создайте класс MessageHandler с событием OnEventOccurred.
//Реализуйте метод CheckMessage, который проверяет сообщение на наличие слова "событие".
//Если слово найдено, вызовите событие OnEventOccurred.
//В главной программе подпишитесь на событие и выведите соответствующее сообщение в консоль.




MessageHandler message1 = new MessageHandler();
Console.WriteLine("Введите сообщение:");
string msg = Console.ReadLine();
message1.EventOccurred += PrintMessage;
message1.CheckMessage(msg);


void PrintMessage()
{
    Console.WriteLine("Событие произошло!");
}


public class MessageHandler
{
    private string word = "событие";
    public void CheckMessage(string message)
    {
        message = message.ToLower();
        if (message.Contains(word))
        {
            OnEventOccurred();
        }
    }
    public delegate void EventHandler();
    public  event EventHandler EventOccurred;
    public void OnEventOccurred()
    {
        EventOccurred?.Invoke();
    }
}


