using System.Text.Json;

namespace UI.Data;

public class PersonService
{ 
    public async Task<IEnumerable<Person>> GetPersonAsync()
    {
        var url ="http://localhost:5211/Person";
        var httpClient = new HttpClient();
        var result = httpClient.GetAsync(url).Result;
        if (result.IsSuccessStatusCode)
        {
            using var responseStream = await result.Content.ReadAsStreamAsync();
            return  JsonSerializer.Deserialize<IEnumerable<Person>>(responseStream);
        }
        return null;
    }
}
