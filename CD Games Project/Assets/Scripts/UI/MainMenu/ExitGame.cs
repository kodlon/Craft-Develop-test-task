using UnityEngine;

namespace UI.MainMenu
{
    public class ExitGame : MonoBehaviour
    {
        public void OnExitButtonPressed()
        {
            Application.Quit();
        }
    }
}