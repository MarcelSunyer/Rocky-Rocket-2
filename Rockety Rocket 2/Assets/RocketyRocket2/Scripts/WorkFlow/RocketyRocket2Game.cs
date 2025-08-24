using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RocketyRocket2
{
    public class RocketyRocket2Game
    {
        public static RocketyRocket2Game Instance = new();

        public SaveGameManager SaveGameManager { get; } = new();

        private RocketyRocket2Game() { }
     }
}
