// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/touchScreenInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TouchScreenInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchScreenInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""touchScreenInputActions"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""4fbf944c-49c5-40f7-8176-ddb5c4123064"",
            ""actions"": [
                {
                    ""name"": ""NextPage"",
                    ""type"": ""Button"",
                    ""id"": ""fdbed2a4-3fcb-44aa-af51-8da7578e56ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackPage"",
                    ""type"": ""Button"",
                    ""id"": ""4a8d8ae4-ee13-4262-9e08-ff3eaf744073"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GlossaryOpenClose"",
                    ""type"": ""Button"",
                    ""id"": ""6d4ab1c8-0dd7-4c12-af5f-6c3668d446a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e6a70349-04fe-493f-ae49-b2af4a2caad2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextPage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c71a3f28-e7b8-4e62-82fd-e31108fcaf5a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackPage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93def623-d147-490e-8a28-cc8529bfde80"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GlossaryOpenClose"",
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
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_NextPage = m_Touch.FindAction("NextPage", throwIfNotFound: true);
        m_Touch_BackPage = m_Touch.FindAction("BackPage", throwIfNotFound: true);
        m_Touch_GlossaryOpenClose = m_Touch.FindAction("GlossaryOpenClose", throwIfNotFound: true);
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

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_NextPage;
    private readonly InputAction m_Touch_BackPage;
    private readonly InputAction m_Touch_GlossaryOpenClose;
    public struct TouchActions
    {
        private @TouchScreenInputActions m_Wrapper;
        public TouchActions(@TouchScreenInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextPage => m_Wrapper.m_Touch_NextPage;
        public InputAction @BackPage => m_Wrapper.m_Touch_BackPage;
        public InputAction @GlossaryOpenClose => m_Wrapper.m_Touch_GlossaryOpenClose;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @NextPage.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnNextPage;
                @NextPage.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnNextPage;
                @NextPage.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnNextPage;
                @BackPage.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnBackPage;
                @BackPage.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnBackPage;
                @BackPage.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnBackPage;
                @GlossaryOpenClose.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnGlossaryOpenClose;
                @GlossaryOpenClose.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnGlossaryOpenClose;
                @GlossaryOpenClose.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnGlossaryOpenClose;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NextPage.started += instance.OnNextPage;
                @NextPage.performed += instance.OnNextPage;
                @NextPage.canceled += instance.OnNextPage;
                @BackPage.started += instance.OnBackPage;
                @BackPage.performed += instance.OnBackPage;
                @BackPage.canceled += instance.OnBackPage;
                @GlossaryOpenClose.started += instance.OnGlossaryOpenClose;
                @GlossaryOpenClose.performed += instance.OnGlossaryOpenClose;
                @GlossaryOpenClose.canceled += instance.OnGlossaryOpenClose;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);
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
    public interface ITouchActions
    {
        void OnNextPage(InputAction.CallbackContext context);
        void OnBackPage(InputAction.CallbackContext context);
        void OnGlossaryOpenClose(InputAction.CallbackContext context);
    }
}
