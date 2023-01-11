//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/Inputs/PlayerInputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""PlayerOne"",
            ""id"": ""c604546b-5775-443b-b455-d052abe2eb43"",
            ""actions"": [
                {
                    ""name"": ""Rock"",
                    ""type"": ""Button"",
                    ""id"": ""b51b3695-5f04-4475-9e86-86736b879d2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Paper"",
                    ""type"": ""Button"",
                    ""id"": ""b898c5e8-fd28-4430-90f6-aa62d84403e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Scissors"",
                    ""type"": ""Button"",
                    ""id"": ""4de9f758-cddd-4f5d-a060-40d284ab203e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""36e671d1-181f-4583-91f8-f62bf4bb82af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2e67ad31-c7cf-4168-8bef-91a290f1cd05"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""834ec0e5-b86c-4eee-86c2-f9a8d59e7137"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Paper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a60dbc4d-613b-4310-805f-2346737cca05"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scissors"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3f2b4c2-4110-4cf5-a343-ee306acb6350"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerTwo"",
            ""id"": ""c07105d0-888e-425d-ae23-e61e9f171600"",
            ""actions"": [
                {
                    ""name"": ""Rock"",
                    ""type"": ""Button"",
                    ""id"": ""d7b3707c-6679-4ffe-b821-e87e0ba3fef6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Paper"",
                    ""type"": ""Button"",
                    ""id"": ""b2ccc59c-83cf-4e14-86c6-57b26891182a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Scissors"",
                    ""type"": ""Button"",
                    ""id"": ""0003426b-4e72-48c7-be08-48477ac63473"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""11781ad5-05e0-4276-9c09-8419a9141f35"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9df91c3f-69ca-4857-81a4-0bd1563005c2"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scissors"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87e47972-393a-497d-a1ac-6fdce9658485"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Paper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerOne
        m_PlayerOne = asset.FindActionMap("PlayerOne", throwIfNotFound: true);
        m_PlayerOne_Rock = m_PlayerOne.FindAction("Rock", throwIfNotFound: true);
        m_PlayerOne_Paper = m_PlayerOne.FindAction("Paper", throwIfNotFound: true);
        m_PlayerOne_Scissors = m_PlayerOne.FindAction("Scissors", throwIfNotFound: true);
        m_PlayerOne_Pause = m_PlayerOne.FindAction("Pause", throwIfNotFound: true);
        // PlayerTwo
        m_PlayerTwo = asset.FindActionMap("PlayerTwo", throwIfNotFound: true);
        m_PlayerTwo_Rock = m_PlayerTwo.FindAction("Rock", throwIfNotFound: true);
        m_PlayerTwo_Paper = m_PlayerTwo.FindAction("Paper", throwIfNotFound: true);
        m_PlayerTwo_Scissors = m_PlayerTwo.FindAction("Scissors", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerOne
    private readonly InputActionMap m_PlayerOne;
    private IPlayerOneActions m_PlayerOneActionsCallbackInterface;
    private readonly InputAction m_PlayerOne_Rock;
    private readonly InputAction m_PlayerOne_Paper;
    private readonly InputAction m_PlayerOne_Scissors;
    private readonly InputAction m_PlayerOne_Pause;
    public struct PlayerOneActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerOneActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rock => m_Wrapper.m_PlayerOne_Rock;
        public InputAction @Paper => m_Wrapper.m_PlayerOne_Paper;
        public InputAction @Scissors => m_Wrapper.m_PlayerOne_Scissors;
        public InputAction @Pause => m_Wrapper.m_PlayerOne_Pause;
        public InputActionMap Get() { return m_Wrapper.m_PlayerOne; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOneActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerOneActions instance)
        {
            if (m_Wrapper.m_PlayerOneActionsCallbackInterface != null)
            {
                @Rock.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRock;
                @Rock.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRock;
                @Rock.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRock;
                @Paper.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPaper;
                @Paper.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPaper;
                @Paper.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPaper;
                @Scissors.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnScissors;
                @Scissors.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnScissors;
                @Scissors.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnScissors;
                @Pause.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerOneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rock.started += instance.OnRock;
                @Rock.performed += instance.OnRock;
                @Rock.canceled += instance.OnRock;
                @Paper.started += instance.OnPaper;
                @Paper.performed += instance.OnPaper;
                @Paper.canceled += instance.OnPaper;
                @Scissors.started += instance.OnScissors;
                @Scissors.performed += instance.OnScissors;
                @Scissors.canceled += instance.OnScissors;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerOneActions @PlayerOne => new PlayerOneActions(this);

    // PlayerTwo
    private readonly InputActionMap m_PlayerTwo;
    private IPlayerTwoActions m_PlayerTwoActionsCallbackInterface;
    private readonly InputAction m_PlayerTwo_Rock;
    private readonly InputAction m_PlayerTwo_Paper;
    private readonly InputAction m_PlayerTwo_Scissors;
    public struct PlayerTwoActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerTwoActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rock => m_Wrapper.m_PlayerTwo_Rock;
        public InputAction @Paper => m_Wrapper.m_PlayerTwo_Paper;
        public InputAction @Scissors => m_Wrapper.m_PlayerTwo_Scissors;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTwo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTwoActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTwoActions instance)
        {
            if (m_Wrapper.m_PlayerTwoActionsCallbackInterface != null)
            {
                @Rock.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnRock;
                @Rock.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnRock;
                @Rock.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnRock;
                @Paper.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnPaper;
                @Paper.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnPaper;
                @Paper.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnPaper;
                @Scissors.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnScissors;
                @Scissors.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnScissors;
                @Scissors.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnScissors;
            }
            m_Wrapper.m_PlayerTwoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rock.started += instance.OnRock;
                @Rock.performed += instance.OnRock;
                @Rock.canceled += instance.OnRock;
                @Paper.started += instance.OnPaper;
                @Paper.performed += instance.OnPaper;
                @Paper.canceled += instance.OnPaper;
                @Scissors.started += instance.OnScissors;
                @Scissors.performed += instance.OnScissors;
                @Scissors.canceled += instance.OnScissors;
            }
        }
    }
    public PlayerTwoActions @PlayerTwo => new PlayerTwoActions(this);
    public interface IPlayerOneActions
    {
        void OnRock(InputAction.CallbackContext context);
        void OnPaper(InputAction.CallbackContext context);
        void OnScissors(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IPlayerTwoActions
    {
        void OnRock(InputAction.CallbackContext context);
        void OnPaper(InputAction.CallbackContext context);
        void OnScissors(InputAction.CallbackContext context);
    }
}
