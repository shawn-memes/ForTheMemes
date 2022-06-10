using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForTheMemes.IoC;
using ForTheMemes.ViewModels;

namespace ForTheMemes.Data
{
    internal class MemeRepository : IMemeRepository
    {
        private readonly IImgFlipDataSource imgFlipDataSource;

        public MemeRepository(IImgFlipDataSource imgFlipDataSource = null)
        {
            this.imgFlipDataSource = imgFlipDataSource.Locate();
        }

        public async Task<List<MemeViewModel>> GetMemes()
        {
            var response = await imgFlipDataSource.Client.GetMemes();

            if (response is { Success: true } && (response.ResponseData?.Memes?.Any() ?? false))
            {
                return response.ResponseData.Memes.Select(meme => meme.ToViewModel()).ToList();
            }

            return new List<MemeViewModel>();
        }
    }
}