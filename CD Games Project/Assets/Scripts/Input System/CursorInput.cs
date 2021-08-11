using UI.HUD;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Input_System
{
    public class CursorInput : MonoBehaviour
    {
        private CursorControls _controls;


        private void Awake()
        {
            _controls = new CursorControls();
            _controls.Mouse.LeftClick.started += ctx => TouchedScreen(ctx);
            _controls.Mouse.LeftClick.performed += _ => ReleasedScreen(); //Called when LMB release

            _controls.Mouse.Touch.started += ctx => TouchedScreen(ctx);
            
        }

        private void OnEnable()
        {
            _controls.Enable();
        }

        private void OnDisable()
        {
            _controls.Disable();
        }

        private void TouchedScreen(InputAction.CallbackContext context)
        {
            Debug.Log("Touch");
            PlayerControls.VisibilityOfSlider(_controls.Mouse.MousePosition.ReadValue<Vector2>(), true);
        }

        private void ReleasedScreen()
        {
            PlayerControls.VisibilityOfSlider(_controls.Mouse.MousePosition.ReadValue<Vector2>());
        }
    }
}