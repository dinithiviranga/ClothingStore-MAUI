using DDClothingStoreMAUI.ViewModel;


namespace DDClothingStoreMAUI.View
{
    /// <summary>
    /// ContentPage representing the home page of the clothing store app
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel();
        }
        
        // Override the back button behavior
        protected override bool OnBackButtonPressed()
        {
            return false;
        }

        // Event handler for item click (To be implemented)
        private async void OnItemClick(object sender, EventArgs e)
        {
            // Display a temporary alert indicating the feature will be available soon
            await DisplayAlert ("Sorry", "This feature will be available soon", "OK");
        }
    }
}