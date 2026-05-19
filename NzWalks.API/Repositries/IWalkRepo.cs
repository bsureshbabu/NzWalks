using Microsoft.AspNetCore.Mvc;
using NzWalks.API.Models.Domain;

namespace NzWalks.API.Repositries
{
    public interface IWalkRepo
    {
        Task<Walks> CreateAsync(Walks walks);
        //Task<List<Walks>> GetAllAsync();
        Task<List<Walks>> GetAllWalkAsync();
    }
}
