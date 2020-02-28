using System;
using ChilkatBind.Droid;
using Com.Chilkatsoft;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(ChilkatServiceAndroid))]
namespace ChilkatBind.Droid
{
    public class ChilkatServiceAndroid : ChilkatService
    {
        public string DecryptEBC(string source)
        {
            CkCrypt2 crypt = new CkCrypt2();
            crypt.Put_CryptAlgorithm("aes");
            crypt.Put_CipherMode("cbc");
            crypt.Put_KeyLength(256);
            crypt.Put_PaddingScheme(0);
            crypt.Put_EncodingMode("hex");

            var ivHex = "000102030405060708090A0B0C0D0E0F";
            crypt.SetEncodedIV(ivHex, "hex");

            var keyHex = "000102030405060708090A0B0C0D0E0F101112131415161718191A1B1C1D1E1F";
            crypt.SetEncodedKey(keyHex, "hex");

            return crypt.DecryptStringENC(source);
        }

        public string EncryptEBC(string source)
        {
            CkCrypt2 crypt = new CkCrypt2();
            crypt.Put_CryptAlgorithm("aes");
            crypt.Put_CipherMode("cbc");
            crypt.Put_KeyLength(256);
            crypt.Put_PaddingScheme(0);
            crypt.Put_EncodingMode("hex");

            var ivHex = "000102030405060708090A0B0C0D0E0F";
            crypt.SetEncodedIV(ivHex, "hex");

            var keyHex = "000102030405060708090A0B0C0D0E0F101112131415161718191A1B1C1D1E1F";
            crypt.SetEncodedKey(keyHex, "hex");

            return crypt.EncryptStringENC(source);
        }

        public void Initalize()
        {
            try
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    try
                    {
                        Java.Lang.JavaSystem.LoadLibrary("chilkat");

                        var global = new CkGlobal();
                        global.UnlockBundle("YOUR_KEY_PUT_HERE");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}