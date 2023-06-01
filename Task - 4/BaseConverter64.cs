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