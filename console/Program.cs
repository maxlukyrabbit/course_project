using System;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {

            // string id_deal = SearchDeal.SearchDealMethod("1944102691");

            // string result = DealManager.сhangeStage_accepted_warehouse(id_deal);

            // Console.WriteLine(result);


            string originalText = "bvhkkghvchggkjhcgjvkhgcjgfc 78";
            string key = "mySecretKey12346"; // Ключ должен быть длиной 16, 24 или 32 байта для AES

            
            string encryptedText = AESEncryption.Encrypt(originalText, key);
        
            file_write_and_read.file_write(encryptedText);

            
            string decryptedText = AESEncryption.Decrypt(file_write_and_read.file_read(), key);

            Console.WriteLine(decryptedText);


        }
    }
}
