using System.Text.Json;
using Microsoft.Net.Http.Headers;

namespace UI.Data;

public class PersonService
{ 
    private readonly IHttpClientFactory _httpClientFactory;
     public PersonService(IHttpClientFactory httpClientFactory) =>
        _httpClientFactory = httpClientFactory;
    public async Task<IEnumerable<Person>> GetPersonAsync()
    {
        IEnumerable<Person>? foundPersons = null;
        var url ="http://localhost:5211/Person";
                var httpRequestMessage = new HttpRequestMessage(
            HttpMethod.Get,
            url);
        var httpClient = _httpClientFactory.CreateClient();
        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            using var contentStream =
                await httpResponseMessage.Content.ReadAsStreamAsync();
            
            foundPersons = await JsonSerializer.DeserializeAsync
                <IEnumerable<Person>>(contentStream);
        }
        return foundPersons;
    }
}
