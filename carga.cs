using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;

namespace Servicio
{
    public class cargaHttp
    {
        public async Task<Banco> cargar(string url)
        {
            HttpClient Cliente = new HttpClient();
            Banco nuevo = new Banco();
            HttpResponseMessage respuesta = await Cliente.GetAsync(url);
            if(respuesta.IsSuccessStatusCode)
            {
                string json = await respuesta.Content.ReadAsStringAsync();
                nuevo = JsonSerializer.Deserialize<Banco>(json);
            }
            return nuevo;
        }

        public void mostrar(Banco banco)
        {
            string simbolo1 = HttpUtility.HtmlDecode(banco.bpi.USD.symbol).ToString();
            string simbolo2 = HttpUtility.HtmlDecode(banco.bpi.GBP.symbol).ToString();
            string simbolo3 = HttpUtility.HtmlDecode(banco.bpi.EUR.symbol).ToString();
            Console.WriteLine("Ultima actualizacion: " + banco.time.updated);
            Console.WriteLine("Ultima actualizacion UK: " + banco.time.updateduk);
            Console.WriteLine("Ultima actualizacion formato ISO: " + banco.time.updatedISO);
            Console.WriteLine("Crypto: " + banco.chartName);
            Console.WriteLine($"\n{banco.bpi.USD.description} {banco.bpi.USD.code}");
            Console.WriteLine($"valor = {simbolo1}{banco.bpi.USD.rate_float} /{simbolo1}{banco.bpi.USD.rate}");
            Console.WriteLine($"\n{banco.bpi.GBP.description} {banco.bpi.GBP.code}");
            Console.WriteLine($"valor = {simbolo2}{banco.bpi.GBP.rate_float} /{simbolo2}{banco.bpi.GBP.rate}");
            Console.WriteLine($"\n{banco.bpi.EUR.description} {banco.bpi.EUR.code}");
            Console.WriteLine($"valor = {simbolo3}{banco.bpi.EUR.rate_float} /{simbolo3}{banco.bpi.EUR.rate}");
            Console.WriteLine("\nDISCLAIMER: " + banco.disclaimer);
        }
    }
}