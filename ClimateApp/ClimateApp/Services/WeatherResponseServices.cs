using ClimateApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClimateApp.Services
{
    internal class WeatherResponseServices
    {
        private HttpClient httpClient;
        private WeatherResponse weatherResponse; //isso é para get específicos, como getbyid por exemplo
        private JsonSerializerOptions jsonSerializerOptions; // configurar/formatar o JSON
        Uri uri = new Uri("http://api.openweathermap.org/data/2.5/weather?q=");
        // aqui vai a chave da API String key = ;
        String options = "lang=pt_br&units=metric";

        public WeatherResponseServices()
        {
            httpClient = new HttpClient();
            jsonSerializerOptions = new JsonSerializerOptions
            {
                //propriedades dos serializer options
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }

        public async Task<WeatherResponse> GetWeatherByCidadeAsync(String cidade) // TASK: usado no await
        {
            Debug.WriteLine("Chamou!! o GetWeatherByCidadeAsync");
            WeatherResponse weatherResponse = new WeatherResponse
                ();
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{uri}{cidade}&{options}&{key}");//quero saber todos os posts;
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();// tranforma o conteudo em string;

                    Debug.WriteLine($"Resposta JSON: {content}");

                    weatherResponse = JsonSerializer.Deserialize<WeatherResponse>(content, jsonSerializerOptions);
                }
                else
                {
                    // se der erro na chama da API mostra
                    Debug.WriteLine($"Erro na chamada à API: {response.StatusCode}");
                }
            }
            catch (JsonException ex)
            {
                // se der alguma exeption ai mostra
                Debug.WriteLine($"Exceção ocorrida: {ex.Message}");
            }
            catch (Exception ex)
            {
                // se der alguma exeption ai mostra
                Debug.WriteLine($"Exceção ocorrida: {ex.Message}");
            }

            return weatherResponse;
        }

    }


}
