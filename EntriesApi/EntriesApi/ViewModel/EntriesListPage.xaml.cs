using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntriesApi.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EntriesApi.ViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntriesListPage : ContentPage
    {
        public List<EntryModel> Entries { get; set; }
        public EntriesListPage()
        {
            InitializeComponent();
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Entries = await App.RequestManager.GetEntrieModels();
            lvEntries.ItemsSource = Entries;
            PCCategory.ItemsSource = Entries;
        }
        private void sbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchText = SBSearchAPI.Text.ToLower();
            lvEntries.ItemsSource = Entries.Where(en => en.API.ToLower().Contains(searchText) || en.Description.ToLower().Contains(searchText));
        }
        private async void lvEntries_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            
        }
        private void PCCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PCCategory.SelectedIndex == -1)
            {
                DisplayAlert("error", "index -1", "ОK");
            }
            else
            {
                lvEntries.ItemsSource = Entries.Where(en => en.Category.Contains(PCCategory.SelectedItem()));
            }
        }
    }
}