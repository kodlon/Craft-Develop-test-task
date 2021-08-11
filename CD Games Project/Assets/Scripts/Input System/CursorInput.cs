using UI.HUD;
using UnityEngine;

namespace Input_System
{
    public class CursorInput : MonoBehaviour
    {
        private CursorControls _controls;


        private void Awake()
        {
            _controls = new CursorControls();
            _controls.Mouse.LeftClick.started += _ => TouchedScreen();
            _controls.Mouse.LeftClick.performed += _ => ReleasedScreen(); //Called when LMB release
        }

        private void OnEnable()
        {
            _controls.Enable();
        }

        private void OnDisable()
        {
            _controls.Disable();
        }

        private void TouchedScreen()
        {
            PlayerControls.VisibilityOfSlider(_controls.Mouse.MousePosition.ReadValue<Vector2>(), true);
        }

        private void ReleasedScreen()
        {
            PlayerControls.VisibilityOfSlider(_controls.Mouse.MousePosition.ReadValue<Vector2>());
        }
    }
}