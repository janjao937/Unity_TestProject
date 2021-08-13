// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""GameControl"",
            ""id"": ""49ce05f3-a2ba-4dc6-8411-7b242edac1d5"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""c484ec63-1916-4382-a7ae-20a11210168f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""16ef302f-54a2-4d9c-8079-638ca602fedc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""1dd9c802-cb0a-48ec-87a5-044542ab509a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""37c206eb-e0ab-464d-8fe3-0c69c0e79ab4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a1a57c9f-d465-489a-8c41-fb4c838ee698"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a360f94d-6baf-4b5f-93c8-5e7ee8e03336"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""80d34d80-ac11-4816-9608-935cc06ac03d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4f56a63d-b588-44a8-8d49-332717d2b99f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameControl
        m_GameControl = asset.FindActionMap("GameControl", throwIfNotFound: true);
        m_GameControl_Movement = m_GameControl.FindAction("Movement", throwIfNotFound: true);
        m_GameControl_Jump = m_GameControl.FindAction("Jump", throwIfNotFound: true);
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

    // GameControl
    private readonly InputActionMap m_GameControl;
    private IGameControlActions m_GameControlActionsCallbackInterface;
    private readonly InputAction m_GameControl_Movement;
    private readonly InputAction m_GameControl_Jump;
    public struct GameControlActions
    {
        private @PlayerControl m_Wrapper;
        public GameControlActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GameControl_Movement;
        public InputAction @Jump => m_Wrapper.m_GameControl_Jump;
        public InputActionMap Get() { return m_Wrapper.m_GameControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameControlActions set) { return set.Get(); }
        public void SetCallbacks(IGameControlActions instance)
        {
            if (m_Wrapper.m_GameControlActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GameControlActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GameControlActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GameControlActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_GameControlActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameControlActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameControlActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_GameControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public GameControlActions @GameControl => new GameControlActions(this);
    public interface IGameControlActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
