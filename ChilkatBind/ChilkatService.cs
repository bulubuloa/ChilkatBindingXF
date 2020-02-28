using System;
namespace ChilkatBind
{
    public interface ChilkatService
    {
        void Initalize();
        string EncryptEBC(string source);
        string DecryptEBC(string source);
    }
}