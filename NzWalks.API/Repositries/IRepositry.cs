using NzWalks.API.Models.Domain;

namespace NzWalks.API.Repositries
{
    public interface IRepositry
    {
        Task<List<Regions>> GetAllRegionsAsync();
        Task<Regions> GetRegionByIdAsync(Guid id);
    }
}
