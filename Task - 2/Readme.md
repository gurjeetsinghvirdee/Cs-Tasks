Task - 2 

`BinaryConverter.cs`
```cs
public class BinaryConverter
{
    public string StringToBinary(string input)
    {
        System.Text.Encoding asciiEncoding = new System.Text.ASCIIEncoding();
        byte[] bytes = asciiEncoding.GetBytes(input);
        System.Text.StringBuilder binaryStringBuilder = new System.Text.StringBuilder();

        foreach (byte b in bytes)
        {
            binaryStringBuilder.Append(System.Convert.ToString(b, 2).PadLeft(8, '0'));
        }

        return binaryStringBuilder.ToString();
    }

    public string BinaryToString(string input)
    {
        System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

        for (int i = 0; i < input.Length; i += 8)
        {
            string binaryByte = input.Substring(i, 8);
            byte value = System.Convert.ToByte(binaryByte, 2);
            stringBuilder.Append((char)value);
        }

        return stringBuilder.ToString();
    }
}

```


`Program.cs`
```cs
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
```

### Result

