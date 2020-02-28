using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChilkatBind
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var chilkat = DependencyService.Get<ChilkatService>();
            var sourceOriginal = "anh quach hoang that la dep trai";

            Console.WriteLine("Original => " + sourceOriginal);

            var encrypt = chilkat.EncryptEBC(sourceOriginal);
            Console.WriteLine("Encrypt => "+ encrypt);

            var decrypt = chilkat.DecryptEBC(encrypt);
            Console.WriteLine("Decrypt => " + decrypt);
        }
    }
}
