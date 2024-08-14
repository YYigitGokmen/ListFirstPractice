
public class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("** Davetliler **");

        List<string> guests = new List<string>() {"1-Bülent Ersoy","2-Ajda Pekkan", "3-Ebru Gündeş",
            "4-Hadise","5-Hande Yener", "6-Tarkan","7-Funda Arar","8-Demek Akalın"};

        foreach (string s in guests)
        {

            Console.WriteLine(s);

        }
    }
}








