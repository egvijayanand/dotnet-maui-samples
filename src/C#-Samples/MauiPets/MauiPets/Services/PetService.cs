using System;
using System.Net.Http.Json;
using MAUIPETS.Models;

namespace MAUIPETS.Services;

public 	class PetService
{
    HttpClient httpClient;
    public PetService()
    {
        this.httpClient = new HttpClient();
    }

    List<Pet> petList;
    public async Task<List<Pet>> GetPets()
    {
        if (petList?.Count > 0)
            return petList;

        // Online
        var response = await httpClient.GetAsync("https://raw.githubusercontent.com/BryanOroxon/data/main/pets.json");
        if (response.IsSuccessStatusCode)
        {
            petList = await response.Content.ReadFromJsonAsync<List<Pet>>();
        }

        return petList;
    }
    
}