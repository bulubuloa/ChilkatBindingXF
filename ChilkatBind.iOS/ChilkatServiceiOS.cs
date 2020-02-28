using System;
using ChilkatBind.iOS;
using NativeLibrary;

[assembly: Xamarin.Forms.Dependency(typeof(ChilkatServiceiOS))]
namespace ChilkatBind.iOS
{
    public class ChilkatServiceiOS : ChilkatService
    {
        public string DecryptEBC(string source)
        {
            var crypt = new CkoCrypt2();
            crypt.CryptAlgorithm = "aes";
            crypt.CipherMode = "cbc";
            crypt.KeyLength = 256;
            crypt.PaddingScheme = 0;
            crypt.EncodingMode = "hex";
            crypt.SetEncodedIV("000102030405060708090A0B0C0D0E0F", "hex");
            crypt.SetEncodedKey("000102030405060708090A0B0C0D0E0F101112131415161718191A1B1C1D1E1F", "hex");
            return crypt.DecryptStringENC(source);
        }

        public string EncryptEBC(string source)
        {
            var crypt = new CkoCrypt2();
            crypt.CryptAlgorithm = "aes";
            crypt.CipherMode = "cbc";
            crypt.KeyLength = 256;
            crypt.PaddingScheme = 0;
            crypt.EncodingMode = "hex";
            crypt.SetEncodedIV("000102030405060708090A0B0C0D0E0F","hex");
            crypt.SetEncodedKey("000102030405060708090A0B0C0D0E0F101112131415161718191A1B1C1D1E1F", "hex");
            return crypt.EncryptStringENC(source).ToString();
        }

        public void Initalize()
        {
            try
            {
                var ckoGlobal = new CkoGlobal();
                ckoGlobal.UnlockBundle("YOUR_KEY_PUT_HERE");
                Console.WriteLine(string.Format("Initialize chilkat version {0} success ", ckoGlobal.Version));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}