using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace XamarinTesting.Views.Forms
{
    /// <summary>
    /// Page to show Add new card.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCardPage : ContentPage
    {
        public AddCardPage()
        {
            InitializeComponent();
        }
    }
}