using System;
using System.Threading.Tasks;

namespace ConsumirOpenAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var httpClient = new System.Net.Http.HttpClient();
            var api = new PetStoreClient(httpClient);
            var pet = await api.GetPetByIdAsync(21221);
            Console.WriteLine(pet.Category.Name);
        }
    }
}
