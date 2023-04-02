//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/InputActions.inputactions
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

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Shooter"",
            ""id"": ""863a2168-6b93-471b-b469-a5b404e076cc"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""290fe6eb-6d51-413b-83dc-8b7b86260354"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Launcher"",
                    ""type"": ""Button"",
                    ""id"": ""04fa2a12-746a-4815-8b7b-2e33cb6b74d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3b624ae7-6c9b-4573-85f7-b5bc9c4520c0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9f8e2cca-39fc-453b-8f16-055835a18f2c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keybord"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ceab07ac-d3f8-475e-9857-f600b3fb1884"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keybord"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d878da9c-9bb9-4159-bba3-626d541d54e5"",
                    ""path"": ""<Touchscreen>/primaryTouch/delta/x"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-15,max=15)"",
                    ""groups"": ""Touch"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49abf57a-dc81-490b-b258-14f24094ad6e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keybord"",
                    ""action"": ""Launcher"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""336a3bb0-15ed-4f23-be26-1a92a79010f1"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Launcher"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keybord"",
            ""bindingGroup"": ""Keybord"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
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
        }
    ]
}");
        // Shooter
        m_Shooter = asset.FindActionMap("Shooter", throwIfNotFound: true);
        m_Shooter_Movement = m_Shooter.FindAction("Movement", throwIfNotFound: true);
        m_Shooter_Launcher = m_Shooter.FindAction("Launcher", throwIfNotFound: true);
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

    // Shooter
    private readonly InputActionMap m_Shooter;
    private IShooterActions m_ShooterActionsCallbackInterface;
    private readonly InputAction m_Shooter_Movement;
    private readonly InputAction m_Shooter_Launcher;
    public struct ShooterActions
    {
        private @InputActions m_Wrapper;
        public ShooterActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Shooter_Movement;
        public InputAction @Launcher => m_Wrapper.m_Shooter_Launcher;
        public InputActionMap Get() { return m_Wrapper.m_Shooter; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShooterActions set) { return set.Get(); }
        public void SetCallbacks(IShooterActions instance)
        {
            if (m_Wrapper.m_ShooterActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ShooterActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ShooterActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ShooterActionsCallbackInterface.OnMovement;
                @Launcher.started -= m_Wrapper.m_ShooterActionsCallbackInterface.OnLauncher;
                @Launcher.performed -= m_Wrapper.m_ShooterActionsCallbackInterface.OnLauncher;
                @Launcher.canceled -= m_Wrapper.m_ShooterActionsCallbackInterface.OnLauncher;
            }
            m_Wrapper.m_ShooterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Launcher.started += instance.OnLauncher;
                @Launcher.performed += instance.OnLauncher;
                @Launcher.canceled += instance.OnLauncher;
            }
        }
    }
    public ShooterActions @Shooter => new ShooterActions(this);
    private int m_KeybordSchemeIndex = -1;
    public InputControlScheme KeybordScheme
    {
        get
        {
            if (m_KeybordSchemeIndex == -1) m_KeybordSchemeIndex = asset.FindControlSchemeIndex("Keybord");
            return asset.controlSchemes[m_KeybordSchemeIndex];
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
    public interface IShooterActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLauncher(InputAction.CallbackContext context);
    }
}
