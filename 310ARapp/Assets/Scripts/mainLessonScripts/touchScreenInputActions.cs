// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/mainLessonScripts/touchScreenInputActions.inputactions'

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
                },
                {
                    ""name"": ""PopOutMenu"",
                    ""type"": ""Button"",
                    ""id"": ""392b743f-e5ee-40da-b55c-46674947632d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ClosePopOut"",
                    ""type"": ""Button"",
                    ""id"": ""c0e98fca-1255-4b14-bd2c-42def1f4021c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoToLessonOne"",
                    ""type"": ""Button"",
                    ""id"": ""a7dc4104-7170-423b-b7b9-6e3df32a3282"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoToLessonTwo"",
                    ""type"": ""Button"",
                    ""id"": ""c7a7ac42-aa45-4198-804e-a73ea920af63"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoToConceptMap"",
                    ""type"": ""Button"",
                    ""id"": ""6415106c-22aa-4f5a-af0a-0e58a1cde513"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartArLesson"",
                    ""type"": ""Button"",
                    ""id"": ""54adbfa5-c147-4dae-b8ac-3d1654118e66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e6a70349-04fe-493f-ae49-b2af4a2caad2"",
                    ""path"": ""<Keyboard>/#(A)"",
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
                    ""path"": ""<Keyboard>/#(B)"",
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
                    ""path"": ""<Keyboard>/#(C)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GlossaryOpenClose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ca11137-2563-4f41-a9e4-dd4e01410647"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PopOutMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5833c23e-fbb9-4bb5-91a9-04a8244f5405"",
                    ""path"": ""<Keyboard>/#(E)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClosePopOut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a5d8b49-e372-45a7-aed5-b5d57b7d7812"",
                    ""path"": ""<Keyboard>/#(F)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoToLessonOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a24aca96-46db-4ab1-ab79-6b0452cc9673"",
                    ""path"": ""<Keyboard>/#(G)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoToLessonTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90edbb45-3a2a-44f4-a563-3eaaa9c42de5"",
                    ""path"": ""<Keyboard>/#(H)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoToConceptMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62abfaba-4bce-4452-b9f7-11cc1b34ada4"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartArLesson"",
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
        m_Touch_PopOutMenu = m_Touch.FindAction("PopOutMenu", throwIfNotFound: true);
        m_Touch_ClosePopOut = m_Touch.FindAction("ClosePopOut", throwIfNotFound: true);
        m_Touch_GoToLessonOne = m_Touch.FindAction("GoToLessonOne", throwIfNotFound: true);
        m_Touch_GoToLessonTwo = m_Touch.FindAction("GoToLessonTwo", throwIfNotFound: true);
        m_Touch_GoToConceptMap = m_Touch.FindAction("GoToConceptMap", throwIfNotFound: true);
        m_Touch_StartArLesson = m_Touch.FindAction("StartArLesson", throwIfNotFound: true);
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
    private readonly InputAction m_Touch_PopOutMenu;
    private readonly InputAction m_Touch_ClosePopOut;
    private readonly InputAction m_Touch_GoToLessonOne;
    private readonly InputAction m_Touch_GoToLessonTwo;
    private readonly InputAction m_Touch_GoToConceptMap;
    private readonly InputAction m_Touch_StartArLesson;
    public struct TouchActions
    {
        private @TouchScreenInputActions m_Wrapper;
        public TouchActions(@TouchScreenInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextPage => m_Wrapper.m_Touch_NextPage;
        public InputAction @BackPage => m_Wrapper.m_Touch_BackPage;
        public InputAction @GlossaryOpenClose => m_Wrapper.m_Touch_GlossaryOpenClose;
        public InputAction @PopOutMenu => m_Wrapper.m_Touch_PopOutMenu;
        public InputAction @ClosePopOut => m_Wrapper.m_Touch_ClosePopOut;
        public InputAction @GoToLessonOne => m_Wrapper.m_Touch_GoToLessonOne;
        public InputAction @GoToLessonTwo => m_Wrapper.m_Touch_GoToLessonTwo;
        public InputAction @GoToConceptMap => m_Wrapper.m_Touch_GoToConceptMap;
        public InputAction @StartArLesson => m_Wrapper.m_Touch_StartArLesson;
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
                @PopOutMenu.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPopOutMenu;
                @PopOutMenu.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPopOutMenu;
                @PopOutMenu.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPopOutMenu;
                @ClosePopOut.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnClosePopOut;
                @ClosePopOut.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnClosePopOut;
                @ClosePopOut.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnClosePopOut;
                @GoToLessonOne.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnGoToLessonOne;
                @GoToLessonOne.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnGoToLessonOne;
                @GoToLessonOne.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnGoToLessonOne;
                @GoToLessonTwo.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnGoToLessonTwo;
                @GoToLessonTwo.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnGoToLessonTwo;
                @GoToLessonTwo.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnGoToLessonTwo;
                @GoToConceptMap.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnGoToConceptMap;
                @GoToConceptMap.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnGoToConceptMap;
                @GoToConceptMap.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnGoToConceptMap;
                @StartArLesson.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnStartArLesson;
                @StartArLesson.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnStartArLesson;
                @StartArLesson.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnStartArLesson;
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
                @PopOutMenu.started += instance.OnPopOutMenu;
                @PopOutMenu.performed += instance.OnPopOutMenu;
                @PopOutMenu.canceled += instance.OnPopOutMenu;
                @ClosePopOut.started += instance.OnClosePopOut;
                @ClosePopOut.performed += instance.OnClosePopOut;
                @ClosePopOut.canceled += instance.OnClosePopOut;
                @GoToLessonOne.started += instance.OnGoToLessonOne;
                @GoToLessonOne.performed += instance.OnGoToLessonOne;
                @GoToLessonOne.canceled += instance.OnGoToLessonOne;
                @GoToLessonTwo.started += instance.OnGoToLessonTwo;
                @GoToLessonTwo.performed += instance.OnGoToLessonTwo;
                @GoToLessonTwo.canceled += instance.OnGoToLessonTwo;
                @GoToConceptMap.started += instance.OnGoToConceptMap;
                @GoToConceptMap.performed += instance.OnGoToConceptMap;
                @GoToConceptMap.canceled += instance.OnGoToConceptMap;
                @StartArLesson.started += instance.OnStartArLesson;
                @StartArLesson.performed += instance.OnStartArLesson;
                @StartArLesson.canceled += instance.OnStartArLesson;
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
        void OnPopOutMenu(InputAction.CallbackContext context);
        void OnClosePopOut(InputAction.CallbackContext context);
        void OnGoToLessonOne(InputAction.CallbackContext context);
        void OnGoToLessonTwo(InputAction.CallbackContext context);
        void OnGoToConceptMap(InputAction.CallbackContext context);
        void OnStartArLesson(InputAction.CallbackContext context);
    }
}
