// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input System/CursorControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CursorControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CursorControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CursorControls"",
    ""maps"": [
        {
            ""name"": ""Mouse"",
            ""id"": ""3560b3dc-f23f-4ce1-aa56-dca6499a477a"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""9d77103a-27d8-4a2a-a9cf-3f74cd15052d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Mouse Position"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dfd2211c-92b4-4a26-8624-84127cdb7d8c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Touch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fe38d64f-a06e-4490-adeb-deb2ae35724b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Touch Input"",
                    ""type"": ""Button"",
                    ""id"": ""d34e1a38-764f-49d1-9f80-2c4d8c1a82cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Touch Position"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6abe30ae-1225-41a4-bc81-1d6f8270be6e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6af6ac01-2767-41fa-ad69-4c633f672e4b"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f30c5b7-b0cf-4a28-bfd9-0f62712abcb8"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab39c4a8-5b7d-4d42-8a05-9b3a52979739"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72618cea-c1f4-496d-9fc5-e444832459fa"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch Input"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d96fc9a9-bbcb-4ce7-a915-a3d31fc11d66"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_LeftClick = m_Mouse.FindAction("LeftClick", throwIfNotFound: true);
        m_Mouse_MousePosition = m_Mouse.FindAction("Mouse Position", throwIfNotFound: true);
        m_Mouse_Touch = m_Mouse.FindAction("Touch", throwIfNotFound: true);
        m_Mouse_TouchInput = m_Mouse.FindAction("Touch Input", throwIfNotFound: true);
        m_Mouse_TouchPosition = m_Mouse.FindAction("Touch Position", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_LeftClick;
    private readonly InputAction m_Mouse_MousePosition;
    private readonly InputAction m_Mouse_Touch;
    private readonly InputAction m_Mouse_TouchInput;
    private readonly InputAction m_Mouse_TouchPosition;
    public struct MouseActions
    {
        private @CursorControls m_Wrapper;
        public MouseActions(@CursorControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_Mouse_LeftClick;
        public InputAction @MousePosition => m_Wrapper.m_Mouse_MousePosition;
        public InputAction @Touch => m_Wrapper.m_Mouse_Touch;
        public InputAction @TouchInput => m_Wrapper.m_Mouse_TouchInput;
        public InputAction @TouchPosition => m_Wrapper.m_Mouse_TouchPosition;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftClick;
                @MousePosition.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePosition;
                @Touch.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnTouch;
                @Touch.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnTouch;
                @Touch.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnTouch;
                @TouchInput.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnTouchInput;
                @TouchInput.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnTouchInput;
                @TouchInput.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnTouchInput;
                @TouchPosition.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnTouchPosition;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @Touch.started += instance.OnTouch;
                @Touch.performed += instance.OnTouch;
                @Touch.canceled += instance.OnTouch;
                @TouchInput.started += instance.OnTouchInput;
                @TouchInput.performed += instance.OnTouchInput;
                @TouchInput.canceled += instance.OnTouchInput;
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
    public interface IMouseActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnTouch(InputAction.CallbackContext context);
        void OnTouchInput(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
    }
}
