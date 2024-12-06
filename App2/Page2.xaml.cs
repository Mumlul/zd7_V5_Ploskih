using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        int price = 0;
        public Page2(RealEstate house)
        {
            InitializeComponent();
            price = Convert.ToInt32(house.Price);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (int.TryParse(this.FindByName<Entry>("summa").Text, out int days))
            {
                if (days > 0)
                {
                    if (this.FindByName<Picker>("hh").SelectedIndex != -1)
                    {
                        string paymentMethod = this.FindByName<Picker>("hh").SelectedItem.ToString();
                       
                            decimal finalPrice = CalculateFinalPrice(price, paymentMethod, days);
                            this.FindByName<Label>("all").Text = $"Итоговая сумма: {finalPrice:C}";
                        
                    }
                   
                    
                }
              
            }
            else
            {
                DisplayAlert("Ошибка", "Пожалуйста, введите корректные данные.", "OK");
            }
        }
        private  decimal CalculateFinalPrice(decimal price, string paymentMethod, int days)
        {
            decimal discountOrMarkup = 0;


            if (paymentMethod == "Наличка")
            {
                discountOrMarkup = price * 0.10m; 
                price -= discountOrMarkup;
            }
            else if (paymentMethod == "Безналичный")
            {
                discountOrMarkup = price * 0.10m; 
                price += discountOrMarkup;
            }

           
            if (days >= 1 && days <= 4)
            {
                price += price * 0.05m * days; 
            }
            else if (days >= 5 && days <= 10)
            {
                price += price * 0.10m * days; 
            }
            else if (days >= 11 && days <= 20)
            {
                price += price * 0.15m * days; 
            }
            else
            {
                DisplayAlert("Ошибка", "Сорянчик", "OK");
            }

            return price;
        }
    }
}