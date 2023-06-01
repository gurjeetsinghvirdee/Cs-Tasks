## Task 3

`HexadecimalConverter.cs`
```cs
public class HexadecimalConverter
{
    public string StringToHexadecimal(string input)
    {
        byte[] bytes = System.Text.Encoding.ASCII.GetBytes(input);
        string hexadecimalString = "";

        foreach (byte b in bytes)
        {
            hexadecimalString += b.ToString("X2");
        }

        return hexadecimalString;
    }

    public string HexadecimalToString(string input)
    {
        byte[] bytes = new byte[input.Length / 2];

        for (int i = 0; i < input.Length; i += 2)
        {
            bytes[i / 2] = System.Convert.ToByte(input.Substring(i, 2), 16);
        }

        return System.Text.Encoding.ASCII.GetString(bytes);
    }
}

```

`Program.cs`
```cs
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

```

### Result

<div align="center">
    <img src="./../Assets/Task%20-%203.png" />
</div>