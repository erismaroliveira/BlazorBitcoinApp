using BlazorBitcoinApp.DTOs;

namespace BlazorBitcoinApp.Services
{
    public interface IBitcoinService
    {
        Task<List<BitcoinDataDTO>> FindBy(DateTime startDate);
    }
}
