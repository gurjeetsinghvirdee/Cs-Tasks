public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("\n\n ========= Task 2 : Binary Converter ========== \n\n");
        BinaryConverter base2 = new BinaryConverter();

        System.Console.Write("Enter a name: ");
        string fullname = System.Console.ReadLine();

        string binaryData = base2.StringToBinary(fullname); // Encoding: convert string to binary
        string decodedData = base2.BinaryToString(binaryData); // Decoding: convert binary back to string

        System.Console.WriteLine("Fullname: " + fullname);
        System.Console.WriteLine("Binary Data: " + binaryData);
        System.Console.WriteLine("Decoded Data: " + decodedData);
    }
}