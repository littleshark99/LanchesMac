using LancheMac.Models;

namespace LancheMac.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanche { get; }
        IEnumerable<Lanche> LanchePreferidos { get; }

        Lanche GetLancheById(int lancheId);

    }
}

