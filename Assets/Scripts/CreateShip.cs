using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShip : MonoBehaviour
{
    public List<GameObject> ships = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        InstantiateShip(ShipChoice.ShipIndex);
    }

    public void InstantiateShip(int chosen_ship)
    {
        Instantiate(ships[chosen_ship], new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
    }
    
}
