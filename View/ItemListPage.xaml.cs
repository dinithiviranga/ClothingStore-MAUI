using System;
using System.Collections.ObjectModel;
using DDClothingStoreMAUI.Model;

namespace DDClothingStoreMAUI.View
{
    /// <summary>
    /// ContentPage representing the item list of a particular category
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemListPage : ContentPage
    {
        public ItemListPage(ObservableCollection<Item>? items)
        {
            InitializeComponent();
            CategoryTitle.Text = items != null ? items[0].Category.ToString() : "";
            ItemsCollectionView.ItemsSource = items;
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await ItemSearchBar.HideSoftInputAsync(CancellationToken.None);
            await Navigation.PopModalAsync();
           
        }

        //ToDo
        private async void OnItemClick(object sender, EventArgs e)
        {
            await DisplayAlert ("Sorry", "This feature will be available soon", "OK");
        }

        private void SearchBar_OnSearchButtonPressed(object? sender, EventArgs e)
        {
            ItemSearchBar.HideSoftInputAsync(CancellationToken.None);
        }
    }
}