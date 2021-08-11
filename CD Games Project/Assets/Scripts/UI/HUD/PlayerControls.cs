using System;
using UI.MainMenu;
using UnityEngine;

namespace UI.HUD
{
    public class PlayerControls : MonoBehaviour
    {
        [SerializeField] private GameObject slider;
        private static GameObject s_slider;

        private void Start()
        {
            s_slider = slider;
        }

        public static void VisibilityOfSlider(Vector3 position, bool isVisible = false)
        {
            if (StartedGame.IsGameStarted)
            {
                s_slider.SetActive(isVisible);
                s_slider.transform.position = position;
            }
        }
    }
}