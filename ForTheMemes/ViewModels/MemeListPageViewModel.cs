using System.Collections.Generic;
using System.Threading.Tasks;
using ForTheMemes.Data;
using ForTheMemes.IoC;
using Sharpnado.Presentation.Forms;

namespace ForTheMemes.ViewModels
{
    internal class MemeListPageViewModel : ViewModelBase
    {
        private readonly IMemeRepository memeRepository;

        public MemeListPageViewModel() : this(null)
        {
        }

        public MemeListPageViewModel(IMemeRepository memeRepository = null)
        {
            this.memeRepository = memeRepository.Locate();
            Loader = new TaskLoaderNotifier<List<MemeViewModel>>();
            Loader.Load(Initialize);
        }
        public List<MemeViewModel> Memes { get; private set; }

        public TaskLoaderNotifier<List<MemeViewModel>> Loader { get; }

        private async Task<List<MemeViewModel>> Initialize(bool isRefreshing)
        {
            Memes = await memeRepository.GetMemes();

            return Memes;
        }
    }
}