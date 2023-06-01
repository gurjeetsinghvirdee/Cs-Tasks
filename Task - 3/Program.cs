public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("\n\n ========= Task 3 : Hexadecimal Converter ========== \n\n");
        HexadecimalConverter base16 = new HexadecimalConverter();

        System.Console.Write("Enter a name: ");
        string fullname = System.Console.ReadLine();

        string hexadecimalData = base16.StringToHexadecimal(fullname); // Encoding: convert string to hexadecimal
        string decodedData = base16.HexadecimalToString(hexadecimalData); // Decoding: convert hexadecimal back to string

        System.Console.WriteLine("Fullname: " + fullname);
        System.Console.WriteLine("Hexadecimal Data: " + hexadecimalData);
        System.Console.WriteLine("Decoded Data: " + decodedData);
    }
}