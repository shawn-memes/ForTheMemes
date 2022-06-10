using System.Collections.Generic;
using System.Threading.Tasks;
using ForTheMemes.ViewModels;

namespace ForTheMemes.Data
{
    internal interface IMemeRepository
    {
        Task<List<MemeViewModel>> GetMemes();
    }
}