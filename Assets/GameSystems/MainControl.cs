// GENERATED AUTOMATICALLY FROM 'Assets/MainControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MainControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainControl"",
    ""maps"": [
        {
            ""name"": ""VehicleControl"",
            ""id"": ""3c4ca357-3ac9-4c79-8c6a-f7a0de012dfb"",
            ""actions"": [
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""18b44c22-ad3d-4faa-be50-84bb190a3905"",
                    ""expectedControlType"": """",
                    ""processors"": ""AxisDeadzone(min=0.5)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e84b161e-d16d-44c9-9c5c-13ceafd54a99"",
                    ""expectedControlType"": """",
                    ""processors"": ""AxisDeadzone(min=12.99)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""591a07b0-0680-4a92-8f22-e0d76f07fdaa"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c6546e25-2f05-47fe-9334-b9a55229a399"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reverse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""98882324-29d0-4da0-a75f-57dc8264f726"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrottleControl"",
                    ""type"": ""Button"",
                    ""id"": ""64948263-54f3-45a7-90d9-538d98f83825"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""32d201c0-c62f-40ca-87e8-18f31a211156"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": ""Hold"",
                    ""processors"": ""StickDeadzone(min=0.2)"",
                    ""groups"": ""VehicleControl"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e0667f1-bd27-40c0-93d1-d8a6c381ff8d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""VehicleControl"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afcbdd44-c6e0-4478-a19e-4fb71fafbf1c"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VehicleControl"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b1b2788-64d7-42c9-abd6-2480fccc9693"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VehicleControl"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a32da61-297c-48a6-ae20-846b2d9022d2"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VehicleControl"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94174df8-5d3e-4d9d-a1e4-0af7ca4b5e8c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VehicleControl"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""351a2b69-28e4-4d69-b298-c68987fea0e8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.25)"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d7aa53ff-4282-40fe-bae1-131cacbc338d"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.2)"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""87dfdc88-6b9f-4f70-907a-68e54c6c046f"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.2)"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2bdd37e6-d213-4b3f-a753-6a1773fce7db"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VehicleControl"",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""770f7bf3-a4bb-4b06-8d03-c7ca9c22c20f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VehicleControl"",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d8be738a-7baa-4bf1-8f6b-0ac671adb196"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrottleControl"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""211fe42e-7855-4677-8906-464dea462ac9"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VehicleControl"",
                    ""action"": ""TrottleControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b186fbcb-6332-4793-a403-4f8d25056706"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VehicleControl"",
                    ""action"": ""TrottleControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""VehicleControl"",
            ""bindingGroup"": ""VehicleControl"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // VehicleControl
        m_VehicleControl = asset.FindActionMap("VehicleControl", throwIfNotFound: true);
        m_VehicleControl_MoveRight = m_VehicleControl.FindAction("MoveRight", throwIfNotFound: true);
        m_VehicleControl_MoveLeft = m_VehicleControl.FindAction("MoveLeft", throwIfNotFound: true);
        m_VehicleControl_Accelerate = m_VehicleControl.FindAction("Accelerate", throwIfNotFound: true);
        m_VehicleControl_Movement = m_VehicleControl.FindAction("Movement", throwIfNotFound: true);
        m_VehicleControl_Reverse = m_VehicleControl.FindAction("Reverse", throwIfNotFound: true);
        m_VehicleControl_TrottleControl = m_VehicleControl.FindAction("TrottleControl", throwIfNotFound: true);
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

    // VehicleControl
    private readonly InputActionMap m_VehicleControl;
    private IVehicleControlActions m_VehicleControlActionsCallbackInterface;
    private readonly InputAction m_VehicleControl_MoveRight;
    private readonly InputAction m_VehicleControl_MoveLeft;
    private readonly InputAction m_VehicleControl_Accelerate;
    private readonly InputAction m_VehicleControl_Movement;
    private readonly InputAction m_VehicleControl_Reverse;
    private readonly InputAction m_VehicleControl_TrottleControl;
    public struct VehicleControlActions
    {
        private @MainControl m_Wrapper;
        public VehicleControlActions(@MainControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveRight => m_Wrapper.m_VehicleControl_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_VehicleControl_MoveLeft;
        public InputAction @Accelerate => m_Wrapper.m_VehicleControl_Accelerate;
        public InputAction @Movement => m_Wrapper.m_VehicleControl_Movement;
        public InputAction @Reverse => m_Wrapper.m_VehicleControl_Reverse;
        public InputAction @TrottleControl => m_Wrapper.m_VehicleControl_TrottleControl;
        public InputActionMap Get() { return m_Wrapper.m_VehicleControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleControlActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleControlActions instance)
        {
            if (m_Wrapper.m_VehicleControlActionsCallbackInterface != null)
            {
                @MoveRight.started -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnMoveRight;
                @MoveLeft.started -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnMoveLeft;
                @Accelerate.started -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnAccelerate;
                @Movement.started -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnMovement;
                @Reverse.started -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnReverse;
                @Reverse.performed -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnReverse;
                @Reverse.canceled -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnReverse;
                @TrottleControl.started -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnTrottleControl;
                @TrottleControl.performed -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnTrottleControl;
                @TrottleControl.canceled -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnTrottleControl;
            }
            m_Wrapper.m_VehicleControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Reverse.started += instance.OnReverse;
                @Reverse.performed += instance.OnReverse;
                @Reverse.canceled += instance.OnReverse;
                @TrottleControl.started += instance.OnTrottleControl;
                @TrottleControl.performed += instance.OnTrottleControl;
                @TrottleControl.canceled += instance.OnTrottleControl;
            }
        }
    }
    public VehicleControlActions @VehicleControl => new VehicleControlActions(this);
    private int m_VehicleControlSchemeIndex = -1;
    public InputControlScheme VehicleControlScheme
    {
        get
        {
            if (m_VehicleControlSchemeIndex == -1) m_VehicleControlSchemeIndex = asset.FindControlSchemeIndex("VehicleControl");
            return asset.controlSchemes[m_VehicleControlSchemeIndex];
        }
    }
    public interface IVehicleControlActions
    {
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnReverse(InputAction.CallbackContext context);
        void OnTrottleControl(InputAction.CallbackContext context);
    }
}
