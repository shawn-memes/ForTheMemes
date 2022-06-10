using System.Threading.Tasks;
using ForTheMemes.Models;
using Refit;

namespace ForTheMemes.Data
{
    public interface IImgFlipApi
    {
        [Get("/get_memes")]
        Task<GetMemesResponse> GetMemes();
    }
}