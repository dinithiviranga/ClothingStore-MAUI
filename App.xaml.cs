namespace DDClothingStoreMAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new View.HomePage();
    }
}