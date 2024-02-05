//This breaks the project on ios
using Multiproject.Netstandard.Shared;

namespace Multiproject.Netstandard
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            //This breaks the project on ios
            var netStandardShared = new NetStandardShared();
            CounterBtn.Text = netStandardShared.ExampleNetStandard;
            
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
