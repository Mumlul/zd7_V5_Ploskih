using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private async void OnSignInClicked(object sender, System.EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(this.FindByName<Entry>("login").Text) && string.IsNullOrWhiteSpace(this.FindByName<Entry>("pas").Text))
            {
                await DisplayAlert("Ошибка", "Пожалуйста, введите вашу фамилию", "OK");
                return;
            }
           
            else
            {
                if (this.FindByName<Entry>("login").Text == "ects" && this.FindByName<Entry>("pas").Text == "ects2024")
                {
                    
                    await Navigation.PushAsync(new Page1());

                }
                else
                {
                    await DisplayAlert("Ошибка", "Не верный пароль", "OK");
                }
            }






        }
    }
}