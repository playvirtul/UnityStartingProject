using CodeBase.Infrastructure.Services;
using UnityEngine;

namespace CodeBase.Infrastructure.Factory
{
    public interface IGameFactory : IService
    {
        void CreateHud();

        GameObject CreateHero(GameObject at);
    }
}