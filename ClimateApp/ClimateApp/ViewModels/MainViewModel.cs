using ClimateApp.Models;
using ClimateApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClimateApp.ViewModels
{
    partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public String cidade;

        [ObservableProperty]
        public String icon;

        [ObservableProperty]
        public String descricao;

        [ObservableProperty]
        public String temperatura;

        [ObservableProperty]
        public String temperaturaMin;

        [ObservableProperty]
        public String temperaturaMax;

        [ObservableProperty]
        public String sensacao;

        [ObservableProperty]
        public String umidade;


        private WeatherResponseServices weatherResponseService = new WeatherResponseServices();

        public ICommand BuscarCommand { get; set; }
        public MainViewModel()
        {
            BuscarCommand = new Command(Buscar);

            Icon = "cerebro.png";
        }


        public async void Buscar()
        {
            if (Cidade == null)
            {
                Debug.WriteLine("Cidade ta nulo");
                return;
            }
            WeatherResponse weatherResponse = await weatherResponseService.GetWeatherByCidadeAsync(Cidade);

            Icon = "http://openweathermap.org/img/wn/" + weatherResponse.Weather[0].Icon.ToString() + ".png";
            Descricao = "Descrição: " + weatherResponse.Weather[0].Description;
            Temperatura = "Temperatura atual: " + weatherResponse.Main.Temp.ToString() + " °C";
            TemperaturaMax = "Temperatura máxima: " + weatherResponse.Main.TempMax.ToString() + " °C";
            TemperaturaMin = "Temperatura mínima: " + weatherResponse.Main.TempMin.ToString() + " °C";
            Sensacao = "Sensação térmica: " + weatherResponse.Main.FeelsLike.ToString() + " °C";
            Umidade = "Umidade: " + weatherResponse.Main.Humidity.ToString() + "%";

        }
    }
}
