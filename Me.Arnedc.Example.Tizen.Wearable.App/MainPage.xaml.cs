using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms.Xaml;

namespace Me.Arnedc.Example.Tizen.Wearable.App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : CirclePage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnToggledOnOff(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            LabelOnOff.Text = e.Value ? "On" : "Off";
        }
    }
}
