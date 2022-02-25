using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using static UnityEngine.InputSystem.InputAction;


public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
    private CarControl car;

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var cars = FindObjectsOfType<CarControl>();
        var index = playerInput.playerIndex;
        if(playerInput.playerIndex>-1)
        car = cars.FirstOrDefault(m => m.GetPlayerIndex() == index);
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        switch (GameManager.State)
        {
            case GameState.Menu:
                playerInput.SwitchCurrentActionMap("Menu control");
                break;
            case GameState.SinglePlayerTimeTrial:
                playerInput.SwitchCurrentActionMap("VehicleControl");
                break;
            case GameState.Multiplayer:
                playerInput.SwitchCurrentActionMap("VehicleControl");
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Movement(CallbackContext context)
    {
            //car.SetfloatMovement(context.ReadValue<float>());
        car.MovementValue = context.ReadValue<float>();
    }
    public void Trottle(CallbackContext context)
    {
            //car.SetTrottleInput(context.ReadValue<float>());
        car.TrottleValue = context.ReadValue<float>();
    }
    public void Drift(CallbackContext context)
    {
            //car.SetDriftMovement(context.ReadValue<float>());
        car.DriftValue = context.ReadValue<float>();
    }
    public void Weapon(CallbackContext context)
    {
            car.SetWeaponUseInput();
    }
    public void MenuMovement(CallbackContext context)
    {
        
    }
    public void MenuConfirm(CallbackContext context)
    {

    }

}
