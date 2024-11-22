using ClimateApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimateApp.ViewModels
{
    internal partial class WeatherResponseViewModel : ObservableObject, INotifyPropertyChanged
    {
        [ObservableProperty]
        public Coordinates coord; 

        [ObservableProperty]
        public List<Weather> weather;

        [ObservableProperty]
        public string Base; 

        [ObservableProperty]
        public Main main;

        [ObservableProperty]
        public int visibility;

        [ObservableProperty]
        public Wind wind;

        [ObservableProperty]
        public Clouds clouds;

        [ObservableProperty]
        public long dt;

        [ObservableProperty]
        public Sys sys; 

        [ObservableProperty]
        public int timezone;

        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public string name;

        [ObservableProperty]
        public int cod;


        WeatherResponseServices weatherResponseServices = new WeatherResponseServices();
    }
}
