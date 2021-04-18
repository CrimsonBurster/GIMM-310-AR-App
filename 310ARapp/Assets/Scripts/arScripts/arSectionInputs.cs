// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/arScripts/arSectionInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ArSectionInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ArSectionInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""arSectionInputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""2c1b5dfa-3743-42d6-8c3a-dfbd9431ceb5"",
            ""actions"": [
                {
                    ""name"": ""pollenButton"",
                    ""type"": ""Button"",
                    ""id"": ""2b3577c5-1988-4671-90c0-26f66c5215db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""waterButton"",
                    ""type"": ""Button"",
                    ""id"": ""8464fb0a-ebba-4356-b89c-559f80d9f5b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""seedButton"",
                    ""type"": ""Button"",
                    ""id"": ""02c56b63-b06e-45ac-b618-56f428db5283"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""sunButton"",
                    ""type"": ""Button"",
                    ""id"": ""439a7ee7-a8ae-42aa-a6f0-95cbc354b7ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""wrongClear"",
                    ""type"": ""Button"",
                    ""id"": ""d5787787-74f1-431f-a906-eac27e74c30b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveToQuiz"",
                    ""type"": ""Button"",
                    ""id"": ""53058471-8b1b-4b16-acf4-0fcccf134722"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0b60ae61-d25e-4a97-9542-8957a1cc591c"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pollenButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""616268d0-49b6-4378-bea9-0c28857dc2eb"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""waterButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c01b2dda-ea4b-408d-be12-b2f5f9e11c1f"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""seedButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84b81af7-d7fe-41b2-aa25-79616d90b342"",
                    ""path"": ""<Keyboard>/#(F)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sunButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d531915-d1d1-4d6f-b8f3-e502f60e7cac"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""wrongClear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50a35ab8-5b74-4eb0-9dd8-8c10044b4e8a"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveToQuiz"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_pollenButton = m_Player.FindAction("pollenButton", throwIfNotFound: true);
        m_Player_waterButton = m_Player.FindAction("waterButton", throwIfNotFound: true);
        m_Player_seedButton = m_Player.FindAction("seedButton", throwIfNotFound: true);
        m_Player_sunButton = m_Player.FindAction("sunButton", throwIfNotFound: true);
        m_Player_wrongClear = m_Player.FindAction("wrongClear", throwIfNotFound: true);
        m_Player_moveToQuiz = m_Player.FindAction("moveToQuiz", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_pollenButton;
    private readonly InputAction m_Player_waterButton;
    private readonly InputAction m_Player_seedButton;
    private readonly InputAction m_Player_sunButton;
    private readonly InputAction m_Player_wrongClear;
    private readonly InputAction m_Player_moveToQuiz;
    public struct PlayerActions
    {
        private @ArSectionInputs m_Wrapper;
        public PlayerActions(@ArSectionInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @pollenButton => m_Wrapper.m_Player_pollenButton;
        public InputAction @waterButton => m_Wrapper.m_Player_waterButton;
        public InputAction @seedButton => m_Wrapper.m_Player_seedButton;
        public InputAction @sunButton => m_Wrapper.m_Player_sunButton;
        public InputAction @wrongClear => m_Wrapper.m_Player_wrongClear;
        public InputAction @moveToQuiz => m_Wrapper.m_Player_moveToQuiz;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @pollenButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPollenButton;
                @pollenButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPollenButton;
                @pollenButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPollenButton;
                @waterButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWaterButton;
                @waterButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWaterButton;
                @waterButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWaterButton;
                @seedButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSeedButton;
                @seedButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSeedButton;
                @seedButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSeedButton;
                @sunButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSunButton;
                @sunButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSunButton;
                @sunButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSunButton;
                @wrongClear.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWrongClear;
                @wrongClear.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWrongClear;
                @wrongClear.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWrongClear;
                @moveToQuiz.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveToQuiz;
                @moveToQuiz.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveToQuiz;
                @moveToQuiz.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveToQuiz;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @pollenButton.started += instance.OnPollenButton;
                @pollenButton.performed += instance.OnPollenButton;
                @pollenButton.canceled += instance.OnPollenButton;
                @waterButton.started += instance.OnWaterButton;
                @waterButton.performed += instance.OnWaterButton;
                @waterButton.canceled += instance.OnWaterButton;
                @seedButton.started += instance.OnSeedButton;
                @seedButton.performed += instance.OnSeedButton;
                @seedButton.canceled += instance.OnSeedButton;
                @sunButton.started += instance.OnSunButton;
                @sunButton.performed += instance.OnSunButton;
                @sunButton.canceled += instance.OnSunButton;
                @wrongClear.started += instance.OnWrongClear;
                @wrongClear.performed += instance.OnWrongClear;
                @wrongClear.canceled += instance.OnWrongClear;
                @moveToQuiz.started += instance.OnMoveToQuiz;
                @moveToQuiz.performed += instance.OnMoveToQuiz;
                @moveToQuiz.canceled += instance.OnMoveToQuiz;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnPollenButton(InputAction.CallbackContext context);
        void OnWaterButton(InputAction.CallbackContext context);
        void OnSeedButton(InputAction.CallbackContext context);
        void OnSunButton(InputAction.CallbackContext context);
        void OnWrongClear(InputAction.CallbackContext context);
        void OnMoveToQuiz(InputAction.CallbackContext context);
    }
}
