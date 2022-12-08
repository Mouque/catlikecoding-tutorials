using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphere : MonoBehaviour
{
    void Update() 
    {
        Vector2 playerInput;
        playerInput.x = Input.GetAxis("Horizontal");
        playerInput.y = Input.GetAxis("Vertical");
        Vector3 velocity = new Vector3(playerInput.x, 0f, playerInput.y);
        Vector3 displacement = velocity * Time.deltaTime;
        transform.localPosition += displacement;
        playerInput = Vector2.ClampMagnitude(playerInput, 1f);

    }
}
