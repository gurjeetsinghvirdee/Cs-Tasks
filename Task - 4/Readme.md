## Task 4

`BaseConverter64.cs`
```cs
public class Base64Converter
{
    public string StringToBase64(string input)
    {
        System.Text.Encoding asciiEncoding = new System.Text.ASCIIEncoding();
        byte[] bytes = asciiEncoding.GetBytes(input);
        string base64String = System.Convert.ToBase64String(bytes);
        return base64String;
    }
}

```

`Program.cs`
```cs
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

```

### Result

<div align="center">
    <img src="./../Assets/Task%20-%204.png" width="600">
</div>