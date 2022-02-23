using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter2d()
    {
        Debug.Log("Something got hit me...!");
    }
}
