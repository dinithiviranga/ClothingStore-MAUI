using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DDClothingStoreMAUI.Model;
using DDClothingStoreMAUI.View;

namespace DDClothingStoreMAUI.ViewModel
{
    /// <summary>
    /// ViewModel for the home page.
    /// </summary>
    public class HomePageViewModel: INotifyPropertyChanged
    {
        // Collection of categories
        private readonly IList<Category> _categorySource;
        
        // Collection of items
        private readonly IList<Item> _itemSource;
        
        // Collection of categories to bind to UI
        public ObservableCollection<Category>? Categories { get; private set; }
        
        // Collection of items to bind to UI
        public ObservableCollection<Item>? Items { get; private set; }
        
        // Command to handle tapping on a category
        public ICommand CategoryTapCommand { get; set; }
        
        // Command to handle tapping on an item
        public ICommand ItemTapCommand { get; set; }
        public ICommand KidsFashionOfferTapCommand { get; set; }
        public HomePageViewModel()
        {
            _categorySource = new List<Category>();
            _itemSource = new List<Item>();
            PopulateCategoryCollection();
            PopulateItemCollection();
            
            CategoryTapCommand = new Command<string>(categoryName =>
            {
                Debug.Assert(Application.Current != null, "Application.Current != null");
                Application.Current.MainPage?.Navigation.PushModalAsync(new ItemListPage(GetItemsByCategory(categoryName)));
            });

            KidsFashionOfferTapCommand = new Command<string>(categoryName =>
            {
                if (Application.Current != null)
                    Application.Current.MainPage?.Navigation.PushModalAsync(
                        new ItemListPage(GetItemsByCategory(categoryName)));
            });
            
            ItemTapCommand = new Command<Item>(items =>
            {
                //ToDo
                //string selected = items.ItemName;
                //Application.Current.MainPage.Navigation.PushModalAsync(new ItemListPage(selected));
            });
        }

        private void PopulateCategoryCollection()
        {
            _categorySource.Add(new Category
            {
                CategoryImage = "men",
                CategoryTitle = "Men",
                CategoryUrl = ""
            });
            _categorySource.Add(new Category
            {
                CategoryImage = "woman",
                CategoryTitle = "Women",
                CategoryUrl = ""
            });
            _categorySource.Add(new Category
            {
                CategoryImage = "kids",
                CategoryTitle = "Kids",
                CategoryUrl = ""
            });

            _categorySource.Add(new Category
            {
                CategoryImage = "baby",
                CategoryTitle = "Baby",
                CategoryUrl = ""
            });

            _categorySource.Add(new Category
            {
                CategoryImage = "sports",
                CategoryTitle = "Sportswear",
                CategoryUrl = ""
            });
            
            _categorySource.Add(new Category
            {
                CategoryImage = "winter",
                CategoryTitle = "Winterwear",
                CategoryUrl = ""
            });

            _categorySource.Add(new Category
            {
                CategoryImage = "swimwear",
                CategoryTitle = "Swimwear",
                CategoryUrl = ""
            });
            // Adding categories to the collection
            Categories = new ObservableCollection<Category>(_categorySource);
        }

        private void PopulateItemCollection()
        {
            _itemSource.Add(new Item
            (
                "Men's T-shirt",
                "mens_black_tshirt",
                "$ 10",
                CategoryEnum.Men,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Fashion men's windproof jacket",
                "mens_full_kit",
                "$ 20",
                CategoryEnum.Men,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "100% Cotton New Summer Men's T Shirt ",
                "mens_gray_tshirt",
                "$ 10",
                CategoryEnum.Men,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "New Arrival Loose Comfy Cotton Pants",
                "mens_comfy",
                "$ 40",
                CategoryEnum.Men,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Women's Comfy T-shirt",
                "womens_green_tshirt",
                "$ 10",
                CategoryEnum.Women,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Women's White T-shirt",
                "womens_white_tshirt",
                "$ 20",
                CategoryEnum.Women,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Women's Printed T-shirt",
                "womens_printed_tshirt",
                "$ 20",
                CategoryEnum.Women,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Women's Orange T-shirt",
                "womens_brown_tshirt",
                "$ 10",
                CategoryEnum.Women,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Kid's T-shirt",
                "kids_yellow_tshirt",
                "$ 10",
                CategoryEnum.Kids,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Kid's comfy pack",
                "kids_comfy_pack",
                "$ 10",
                CategoryEnum.Kids,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Kid's fashion pack",
                "kids_fashion_pack",
                "$ 20",
                CategoryEnum.Kids,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Kid's comfy jacket",
                "kids_comfy_jacket",
                "$ 30",
                CategoryEnum.Kids,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Newborn pack",
                "baby_green_kit",
                "$ 30",
                CategoryEnum.Baby,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Baby shirt",
                "baby_shirts",
                "$ 10",
                CategoryEnum.Baby,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Knitted baby shirt",
                "baby_knitted_shirt",
                "$ 30",
                CategoryEnum.Baby,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Knitted pack",
                "baby_knitted_kit",
                "$ 40",
                CategoryEnum.Baby,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Comfy short",
                "sports_short",
                "$ 10",
                CategoryEnum.Sportswear,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
                                      
            ));
            
            _itemSource.Add(new Item
            (
                "Women's sports kit",
                "sports_black_kit",
                "$ 50",
                CategoryEnum.Sportswear, 
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Sport skinny",
                "sports_pink",
                "$ 10",
                CategoryEnum.Sportswear,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item
            (
                "Hooded winter Jacket",
                "winter_pink",
                "$ 70",
                CategoryEnum.Winterwear,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));

            _itemSource.Add(new Item(
                "Red winter Jacket", 
                "winter_red", 
                "$ 60",  
                CategoryEnum.Winterwear,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                "Pellentesque consectetur hendrerit varius."));
            
            _itemSource.Add(new Item(
                "Red winter Jacket",
                "winter_red",
                "$ 60",
                CategoryEnum.Winterwear,
                "",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item(
                 "Fashion Jacket",
                 "winter_coat",
                 "$ 40",
                 CategoryEnum.Winterwear,
                 "",
                 "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                  "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                  "Pellentesque consectetur hendrerit varius."
            ));
            
            _itemSource.Add(new Item(
                             "Swimming kit",
                             "winter_coat",
                             "$ 20",
                             CategoryEnum.Swimwear,
                             "",
                             "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                              "Sed commodo mi et odio tristique efficitur. Phasellus sed pharetra erat. " +
                                              "Pellentesque consectetur hendrerit varius."
                        ));
            
            Items = new ObservableCollection<Item>(_itemSource);
        }

        private ObservableCollection<Item> GetItemsByCategory(string categoryName)
        {
            return new ObservableCollection<Item>((Items ?? []).Where(item => item.Category.ToString() == categoryName));
        }
        
        private ObservableCollection<Item> GetItemsByCategory(Category category)
        {
            return new ObservableCollection<Item>(Items.Where(item => item.Category.ToString() == category.CategoryTitle));
        }
        
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}