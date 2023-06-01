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