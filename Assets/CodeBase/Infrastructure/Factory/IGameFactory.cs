﻿using System;
using System.Collections.Generic;
using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.Services.PersistentProgress;
using UnityEngine;

namespace CodeBase.Infrastructure.Factory
{
    public interface IGameFactory : IService
    {
        void CreateHud();

        GameObject CreateHero(GameObject at);

        List<ISavedProgressReader> ProgressReaders { get; }

        List<ISavedProgress> ProgressWriters { get; }

        GameObject HeroGameObject { get; }

        event Action HeroCreated;

        void Cleanup();
    }
}