using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterContoller : MonoBehaviour {

    public KeyCode jumpKey;
    public KeyCode energyKey;
    public KeyCode leftKey;
    public KeyCode rightkey;

    Vector3 movement = new Vector3(0.1f, 0, 0);

    private void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Jump();
        }

        if (Input.GetKeyDown(energyKey))
        {
            EnergyDrink();
        }

        if (Input.GetKey(leftKey))
        {
            GoLeft();
        }

        if (Input.GetKey(rightkey))
        {
            Rightkey();
        }
    }

    private void Jump()
    {
        Debug.Log("I jumped");
    }

    private void EnergyDrink()
    {
        Debug.Log("I Used energy drink");
    }

    private void GoLeft()
    {
        Debug.Log("I moved left");
        Vector3 currentPosition = transform.position;
        Vector3 finalPosition = currentPosition -= movement;
        transform.position = finalPosition;
    }

    private void Rightkey()
    {
        Debug.Log("I moved right");
        Vector3 currentPosition = transform.position;
        Vector3 finalPosition = currentPosition += movement;
        transform.position = finalPosition;
           
    }
}
