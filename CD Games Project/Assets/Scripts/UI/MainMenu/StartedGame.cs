using UnityEngine;

namespace UI.MainMenu
{
    public class StartedGame : MonoBehaviour
    {
        public static bool IsGameStarted { get; set; }

        public void OnStartGamePressed()
        {
            IsGameStarted = true;
            
            gameObject.SetActive(false);
        }
    }
}