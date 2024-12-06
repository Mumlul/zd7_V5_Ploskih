using App2;

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Xml;

using Xamarin.Forms;

public class RealEstateViewModel : INotifyPropertyChanged
{
    public ObservableCollection<RealEstate> RealEstateList { get; set; }
    public ICommand NavigateToMainPageCommand { get; }
    public ICommand NavigateToModalPageCommand { get; }
    public ICommand NavigateToCarouselPageCommand { get; }

    public RealEstateViewModel()
    {
        RealEstateList = new ObservableCollection<RealEstate>
        {
            new RealEstate { Name = "Квартира 1", Price = "1000000", Rooms = 2, Photo = "C:\\PLOSKIKH\\App2\\App2.Android\\Resources\\photo1.jpg" },
            new RealEstate { Name = "Квартира 2", Price = "2000000", Rooms = 3, Photo = "C:\\PLOSKIKH\\App2\\App2.Android\\Resources\\photo2.jpg" }
        };

        NavigateToMainPageCommand = new Command(async () =>
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Page1());
        });

        NavigateToModalPageCommand = new Command(async () =>
        {
           /* await Application.Current.MainPage.Navigation.PushModalAsync(new Page2());*/
        });

        NavigateToCarouselPageCommand = new Command(async () =>
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Page1());
        });
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}