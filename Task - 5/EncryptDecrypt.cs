public class EncryptDecrypt
{
    private string key = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private string value = "nopqrstuvwxyzabcdefghijklmNOPQRSTUVWXYZABCDEFGHIJKLM";

    public string Encrypt(string input)
    {
        string encryptedString = "";
        foreach (char c in input)
        {
            int index = key.IndexOf(c);
            if (index >= 0)
            {
                encryptedString += value[index];
            }
            else
            {
                encryptedString += c;
            }
        }
        return encryptedString;
    }

    public string Decrypt(string input)
    {
        string decryptedString = "";
        foreach (char c in input)
        {
            int index = value.IndexOf(c);
            if (index >= 0)
            {
                decryptedString += key[index];
            }
            else
            {
                decryptedString += c;
            }
        }
        return decryptedString;
    }
}
