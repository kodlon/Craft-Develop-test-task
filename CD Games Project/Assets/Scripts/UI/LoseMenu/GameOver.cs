using UI.MainMenu;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.LoseMenu
{
    public class GameOver : MonoBehaviour
    {
        public void OnRestartPressed()
        {
            StartedGame.IsGameStarted = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}