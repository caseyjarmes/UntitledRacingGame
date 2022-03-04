// GENERATED AUTOMATICALLY FROM 'Assets/GameSystems/MainControl.inputactions'

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
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c6546e25-2f05-47fe-9334-b9a55229a399"",
                    ""expectedControlType"": ""Analog"",
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
                },
                {
                    ""name"": ""Drifting"",
                    ""type"": ""Button"",
                    ""id"": ""19cec146-f0d9-4d8d-99a3-543cd5f69ad6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon"",
                    ""type"": ""Button"",
                    ""id"": ""c7b057cf-bc28-473f-af6d-010b2a646188"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
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
                    ""name"": ""1D Axis"",
                    ""id"": ""53b88e62-dfeb-4ab9-ba51-64a8efc7d713"",
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
                    ""id"": ""769d1906-2530-48ec-8352-0575a841f2a3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e6577b83-d257-4bcf-a05d-f0643aebeacb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                    ""groups"": """",
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
                    ""groups"": """",
                    ""action"": ""TrottleControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""105ff62c-ee9c-4b28-80ea-cf8f3e8d5c0a"",
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
                    ""id"": ""08f13ac6-bb2e-4366-9fbb-b4928720b6fe"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrottleControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""71705d2f-590d-43e4-b74e-e8017801c2d2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrottleControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""775421d0-90f8-4c1c-ab52-5a925c077eea"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drifting"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""97deec54-3e42-4d33-951e-a0b97b0af347"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drifting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bfcf1da6-0aa7-4ef6-bddd-5a5d68ac936e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drifting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""384a0f9b-b0e2-466e-96b9-73bb72a8e444"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drifting"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""708bc1dd-9c49-4516-ae04-1772ae65b14e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drifting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d83998a6-379f-422d-b399-6356e986d315"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drifting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""df68a4e8-9d47-439e-8d52-8cff12fba975"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Weapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""460c1048-94f1-4a90-a48d-0fef8265c704"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu control"",
            ""id"": ""e194bce8-86bd-433f-a677-2bced52083bb"",
            ""actions"": [
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""363f55df-77b1-4f91-99ce-f1cf08089efb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""97a906d9-51d8-4070-8ae8-d7a62586daf1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigation"",
                    ""type"": ""Button"",
                    ""id"": ""89b6e05d-2ecc-4812-8662-07d7ad47380d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7f766d5a-864e-4e63-a426-f9e4adb5fcd1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ba28288c-9a75-4cdf-b69a-ad691524b6f2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Click"",
                    ""type"": ""Button"",
                    ""id"": ""6d28450c-916e-4e03-9d4c-a15ac0e5c872"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""7ba28ffd-4d69-4a17-95f5-77f0498d7e74"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""b4257fd5-cb84-478a-ac3d-53d5b2bd7ef4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad (D-pad)"",
                    ""id"": ""4346d62e-5c91-4554-a1b4-ca71648c95e2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6e362b62-f5d4-44ad-b872-3b9867e6ac0a"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7ef8f854-4563-4679-b481-1778bc16a219"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dbc22088-1733-450c-93b1-4f00f2a27882"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""efdf179a-464c-4492-8f60-9d041a588742"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Thumbstick"",
                    ""id"": ""a2b5e277-2418-4116-90f5-c12a0c5c577a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e9383961-e87e-4700-b0c5-d0ec13f99f34"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""245ca385-744a-48ca-84e4-6283a02eb345"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ae22a4f0-95b7-41ea-ad5f-7782876567fb"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0323e40f-8d2a-4f4c-9789-d262ed3cac65"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard WASD"",
                    ""id"": ""64a3ffac-baa1-4864-b484-540c260dbf35"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""afcb24a9-f4f4-4f17-9b0c-eb37d9134f7d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""30391a8c-2075-46f2-948b-f21a93d5a6a9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ac496d2c-91a4-4580-8708-39abed24f989"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9a6fb270-6103-4087-9b46-6d61f0dd1f6a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Arrow Keys"",
                    ""id"": ""83552a8b-ea8a-4582-a707-7d25033e5fa0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6709e3fd-a456-4114-b7ba-2bad82afb85e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""19e7db61-51e7-4979-a964-84072bf98dc6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5481bdb8-8b99-435e-af48-30bd01f3b24a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""414c3dd9-ef2d-4781-a29f-7f7a49861529"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dc5bb777-dcf8-4d69-a4a1-dcbf08554aa8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e6babf3-b0b4-4546-b489-00b743a2f27a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ca924f8-1db7-4448-aa22-855122d949e6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6583316e-8eb0-4a5f-ad3a-54c4ac9b63e9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3e976ec-fd9f-4882-b3e0-779c439c9d20"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96317c61-d176-4120-ad41-46b469aca8c3"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2768f892-41c4-42c4-8163-47bed4036814"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84915c6a-5b38-4689-a168-7d43f2322ec0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ea54d39-ed1c-42a6-b84a-99965f7f9c08"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d403bb19-0855-4d42-8a8c-aa111ca4468b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KB&Mouse"",
            ""bindingGroup"": ""KB&Mouse"",
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
        }
    ]
}");
        // VehicleControl
        m_VehicleControl = asset.FindActionMap("VehicleControl", throwIfNotFound: true);
        m_VehicleControl_Movement = m_VehicleControl.FindAction("Movement", throwIfNotFound: true);
        m_VehicleControl_TrottleControl = m_VehicleControl.FindAction("TrottleControl", throwIfNotFound: true);
        m_VehicleControl_Drifting = m_VehicleControl.FindAction("Drifting", throwIfNotFound: true);
        m_VehicleControl_Weapon = m_VehicleControl.FindAction("Weapon", throwIfNotFound: true);
        // Menu control
        m_Menucontrol = asset.FindActionMap("Menu control", throwIfNotFound: true);
        m_Menucontrol_Confirm = m_Menucontrol.FindAction("Confirm", throwIfNotFound: true);
        m_Menucontrol_Cancel = m_Menucontrol.FindAction("Cancel", throwIfNotFound: true);
        m_Menucontrol_Navigation = m_Menucontrol.FindAction("Navigation", throwIfNotFound: true);
        m_Menucontrol_Point = m_Menucontrol.FindAction("Point", throwIfNotFound: true);
        m_Menucontrol_Click = m_Menucontrol.FindAction("Click", throwIfNotFound: true);
        m_Menucontrol_RightClick = m_Menucontrol.FindAction("Right Click", throwIfNotFound: true);
        m_Menucontrol_Select = m_Menucontrol.FindAction("Select", throwIfNotFound: true);
        m_Menucontrol_Pause = m_Menucontrol.FindAction("Pause", throwIfNotFound: true);
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
    private readonly InputAction m_VehicleControl_Movement;
    private readonly InputAction m_VehicleControl_TrottleControl;
    private readonly InputAction m_VehicleControl_Drifting;
    private readonly InputAction m_VehicleControl_Weapon;
    public struct VehicleControlActions
    {
        private @MainControl m_Wrapper;
        public VehicleControlActions(@MainControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_VehicleControl_Movement;
        public InputAction @TrottleControl => m_Wrapper.m_VehicleControl_TrottleControl;
        public InputAction @Drifting => m_Wrapper.m_VehicleControl_Drifting;
        public InputAction @Weapon => m_Wrapper.m_VehicleControl_Weapon;
        public InputActionMap Get() { return m_Wrapper.m_VehicleControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleControlActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleControlActions instance)
        {
            if (m_Wrapper.m_VehicleControlActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnMovement;
                @TrottleControl.started -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnTrottleControl;
                @TrottleControl.performed -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnTrottleControl;
                @TrottleControl.canceled -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnTrottleControl;
                @Drifting.started -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnDrifting;
                @Drifting.performed -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnDrifting;
                @Drifting.canceled -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnDrifting;
                @Weapon.started -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnWeapon;
                @Weapon.performed -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnWeapon;
                @Weapon.canceled -= m_Wrapper.m_VehicleControlActionsCallbackInterface.OnWeapon;
            }
            m_Wrapper.m_VehicleControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @TrottleControl.started += instance.OnTrottleControl;
                @TrottleControl.performed += instance.OnTrottleControl;
                @TrottleControl.canceled += instance.OnTrottleControl;
                @Drifting.started += instance.OnDrifting;
                @Drifting.performed += instance.OnDrifting;
                @Drifting.canceled += instance.OnDrifting;
                @Weapon.started += instance.OnWeapon;
                @Weapon.performed += instance.OnWeapon;
                @Weapon.canceled += instance.OnWeapon;
            }
        }
    }
    public VehicleControlActions @VehicleControl => new VehicleControlActions(this);

    // Menu control
    private readonly InputActionMap m_Menucontrol;
    private IMenucontrolActions m_MenucontrolActionsCallbackInterface;
    private readonly InputAction m_Menucontrol_Confirm;
    private readonly InputAction m_Menucontrol_Cancel;
    private readonly InputAction m_Menucontrol_Navigation;
    private readonly InputAction m_Menucontrol_Point;
    private readonly InputAction m_Menucontrol_Click;
    private readonly InputAction m_Menucontrol_RightClick;
    private readonly InputAction m_Menucontrol_Select;
    private readonly InputAction m_Menucontrol_Pause;
    public struct MenucontrolActions
    {
        private @MainControl m_Wrapper;
        public MenucontrolActions(@MainControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Confirm => m_Wrapper.m_Menucontrol_Confirm;
        public InputAction @Cancel => m_Wrapper.m_Menucontrol_Cancel;
        public InputAction @Navigation => m_Wrapper.m_Menucontrol_Navigation;
        public InputAction @Point => m_Wrapper.m_Menucontrol_Point;
        public InputAction @Click => m_Wrapper.m_Menucontrol_Click;
        public InputAction @RightClick => m_Wrapper.m_Menucontrol_RightClick;
        public InputAction @Select => m_Wrapper.m_Menucontrol_Select;
        public InputAction @Pause => m_Wrapper.m_Menucontrol_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Menucontrol; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenucontrolActions set) { return set.Get(); }
        public void SetCallbacks(IMenucontrolActions instance)
        {
            if (m_Wrapper.m_MenucontrolActionsCallbackInterface != null)
            {
                @Confirm.started -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnConfirm;
                @Cancel.started -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnCancel;
                @Navigation.started -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnNavigation;
                @Navigation.performed -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnNavigation;
                @Navigation.canceled -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnNavigation;
                @Point.started -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnClick;
                @RightClick.started -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnRightClick;
                @Select.started -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnSelect;
                @Pause.started -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MenucontrolActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_MenucontrolActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Navigation.started += instance.OnNavigation;
                @Navigation.performed += instance.OnNavigation;
                @Navigation.canceled += instance.OnNavigation;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public MenucontrolActions @Menucontrol => new MenucontrolActions(this);
    private int m_KBMouseSchemeIndex = -1;
    public InputControlScheme KBMouseScheme
    {
        get
        {
            if (m_KBMouseSchemeIndex == -1) m_KBMouseSchemeIndex = asset.FindControlSchemeIndex("KB&Mouse");
            return asset.controlSchemes[m_KBMouseSchemeIndex];
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
    public interface IVehicleControlActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnTrottleControl(InputAction.CallbackContext context);
        void OnDrifting(InputAction.CallbackContext context);
        void OnWeapon(InputAction.CallbackContext context);
    }
    public interface IMenucontrolActions
    {
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnNavigation(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
