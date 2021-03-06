﻿using ModestTree;
using UnityEngine;
using Zenject;

#pragma warning disable 649

namespace Zenject.Tests.ToPrefab
{
    public class Gorp : MonoBehaviour
    {
        [Inject]
        string _arg;

        [Inject]
        public void Initialize()
        {
            Log.Trace("Received arg '{0}' in Gorp", _arg);
        }
    }
}
