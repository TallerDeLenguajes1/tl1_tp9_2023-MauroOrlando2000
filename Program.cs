using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Servicio;

Banco nuevoBanco = new Banco();
cargaHttp nuevo = new cargaHttp();
string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
nuevoBanco = await nuevo.cargar(url);
nuevo.mostrar(nuevoBanco);