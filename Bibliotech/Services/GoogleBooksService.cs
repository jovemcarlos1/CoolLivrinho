using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace Bibliotech.Services
{
    public class GoogleBooksService
    {
        public async Task<string> BuscarCapaLivro(string titulo)
        {
            using (var client = new HttpClient())
            {
                string url = $"https://www.googleapis.com/books/v1/volumes?q={titulo}";
                var response = await client.GetStringAsync(url);
                var json = JObject.Parse(response);

                
                string capa = (string)json["items"]?[0]?["volumeInfo"]?["imageLinks"]?["thumbnail"];
                return capa ?? "/images/default-cover.png"; // fallback
            }
        }

    }
}
