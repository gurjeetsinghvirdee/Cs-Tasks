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