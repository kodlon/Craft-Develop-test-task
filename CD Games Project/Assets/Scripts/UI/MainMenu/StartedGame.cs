using UnityEngine;

namespace UI.MainMenu
{
    public class StartedGame : MonoBehaviour
    {
        public static bool IsGameStarted { get; set; }

        public void GameStarted()
        {
            IsGameStarted = true;
            
            gameObject.SetActive(false);
        }
    }
}