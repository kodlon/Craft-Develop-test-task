using UI.MainMenu;
using UnityEngine;

namespace Other
{
    public class BackgroundMove : MonoBehaviour
    {
        private float _speed = 10f;

        private void Update()
        {
            if (StartedGame.IsGameStarted)
                transform.Translate(Vector3.right * (_speed * Time.deltaTime));
        }
    }
}