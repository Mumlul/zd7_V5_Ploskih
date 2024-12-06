using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        RealEstate ll;
        public MainPage(RealEstate room)
        {
            InitializeComponent();
            this.FindByName<Image>("k").Source = room.Photo;
            this.FindByName<Label>("kk").Text = room.Name;
            this.FindByName<Label>("kkk").Text = room.Price;
            this.FindByName<Label>("kkkk").Text = room.Rooms.ToString();
            this.FindByName<Label>("kkkkk").Text = room.Description;
            ll = room;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(ll));
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
