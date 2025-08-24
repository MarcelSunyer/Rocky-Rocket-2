using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RocketyRocket2
{
    public class MainBootstrap : MonoBehaviour
    {
        protected void PrepareGame()
        {
            RocketyRocket2Game.Instance.SaveGameManager.Load();
        }
    }
}
