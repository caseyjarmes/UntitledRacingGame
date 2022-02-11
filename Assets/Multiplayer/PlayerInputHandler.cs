using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
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
        car = cars.FirstOrDefault(m => m.GetPlayerIndex() == index);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Movement(CallbackContext context)
    {
        if (car != null)
            car.SetfloatMovement(context.ReadValue<float>());
    }
}
