public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("\n\n ========= Task 5 : Encrypt/Decrypt ========== \n\n");
        EncryptDecrypt encryptDecrypt = new EncryptDecrypt();

        System.Console.Write("Enter a name: ");
        string fullname = System.Console.ReadLine();

        string encryptedData = encryptDecrypt.Encrypt(fullname); // Encrypt: encrypt the full name
        string decryptedData = encryptDecrypt.Decrypt(encryptedData); // Decrypt: decrypt the encrypted data

        System.Console.WriteLine("Fullname: " + fullname);
        System.Console.WriteLine("Encrypted Data: " + encryptedData);
        System.Console.WriteLine("Decrypted Data: " + decryptedData);
    }
}
