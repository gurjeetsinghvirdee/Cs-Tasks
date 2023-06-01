public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("\n\n ========= Task 4 : Base64 Converter ========== \n\n");
        Base64Converter base64 = new Base64Converter();

        System.Console.Write("Enter a name: ");
        string fullname = System.Console.ReadLine();

        string base64Data = base64.StringToBase64(fullname); // Encoding: convert string to Base64

        System.Console.WriteLine("Fullname: " + fullname);
        System.Console.WriteLine("Base64 Data: " + base64Data);
    }
}