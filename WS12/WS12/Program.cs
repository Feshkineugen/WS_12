using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите строку для поиска корректного IP-адреса: ");
        string strng = Console.ReadLine();

        Regex regex = new Regex(@"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");
        MatchCollection matches = regex.Matches(strng);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}

// IP-адрес (Internet Protocol Address) - это уникальный идентификатор устройства в компьютерной сети, который используется для маршрутизации данных между узлами сети. IP-адрес состоит из четырех чисел, разделенных точками, например, 192.168.1.1.