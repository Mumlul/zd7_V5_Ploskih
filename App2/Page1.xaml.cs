using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    
    public partial class Page1 : CarouselPage
    {
        
            public Page1()
            {
                InitializeComponent();
            var realEstateList = new List<RealEstate>
            {
                    new RealEstate { Name = "Квартира 1", Price = "1000", Rooms = 2, Photo = "gg.jpg", Description = "Уютная квартира в центре города." },
                    new RealEstate { Name = "Квартира 2", Price = "2000", Rooms = 3, Photo = "2.jpg", Description = "Просторная квартира с видом на парк." },
                    new RealEstate { Name = "Квартира 3", Price = "3000", Rooms = 3, Photo = "3.jpg", Description = "Современная квартира с высокими потолками." },
                    new RealEstate { Name = "Квартира 4", Price = "4000", Rooms = 4, Photo = "4.jpg", Description = "Элитная квартира в новом доме." }
            };
            Children.Add(new ContentPage
                {
                    Title = "Квартира 1",
                   
                        Content = new StackLayout
                        {
                            
                            Children =
                             {
                                    new Label { Text = "Онлайн-агентство недвижимости",TextColor=Color.Blue,FontAttributes=FontAttributes.Italic, FontSize = 20 },
                                    new Label { Text = "Дата:"+DateTime.Now,TextColor=Color.Red,FontAttributes=FontAttributes.Italic, FontSize = 15 },
                                    new Image { Source = "gg.jpg", HeightRequest = 200 },
                                    new Label { Text = "Квартира 1", FontSize = 20 },
                                    new Label { Text = "Цена: 1000", FontSize = 16 },
                                    new Label { Text = "Количество комнат: 2", FontSize = 16 },
                                    new Button
                                    {
                                        Text = "Перейти к информации",
                                        Margin = 100,
                                        Command = new Command(async () =>
                                        {
                                            await Navigation.PushAsync(new MainPage(realEstateList[0]));
                                        })
                                    }
                                    
                            }
                        }
                    
                });
            Children.Add(new ContentPage
            {
                Title = "Квартира 2",
               
                    Content = new StackLayout
                    {
                        Children =
                             {
                                    new Label { Text = "Онлайн-агентство недвижимости",TextColor=Color.Blue,FontAttributes=FontAttributes.Italic, FontSize = 20 },
                                    new Label { Text = "Дата:"+DateTime.Now,TextColor=Color.Red,FontAttributes=FontAttributes.Italic, FontSize = 15 },
                                    new Image { Source = "gg.jpg", HeightRequest = 200 },
                                    new Label { Text = "Квартира 2", FontSize = 20 },
                                    new Label { Text = "Цена: 2000", FontSize = 16 },
                                    new Label { Text = "Количество комнат: 3", FontSize = 16 },
                                    new Button
                                    {
                                        Text = "Перейти к информации",
                                        Margin = 100,
                                        Command = new Command(async () =>
                                        {
                                            await Navigation.PushAsync(new MainPage(realEstateList[1]));
                                        })
                                    }
                            }
                    }
                
            });
        }
    
    }


    
}