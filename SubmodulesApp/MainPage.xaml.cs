#region Using

using Windows.UI.Xaml.Controls;
using SubModulesLib;

#endregion

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SubmodulesApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            MyCalculator calc = new MyCalculator();
            var result = calc.Sum(3, 5);
        }
    }
}