using bookStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bookStore.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}