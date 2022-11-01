using CodeBase.Infrastructure.States;
using CodeBase.Logic;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour, ICoroutineRunner
    {
        private Game _game;

        [SerializeField] private LoadingCurtain _curtainPrefab;

        private void Awake()
        {
            _game = new Game(this, Instantiate(_curtainPrefab));
            _game.StateMachine.Enter<BootstrapState>();

            DontDestroyOnLoad(this);
        }
    }
}