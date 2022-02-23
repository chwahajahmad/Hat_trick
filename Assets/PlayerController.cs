using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float LeftBoundry;
    public float RightBoundry;
    public float MovementSpeed;

   
    // Update is called once per frame
    void Update()
    {
        Vector3 MyPos = transform.position;


        if(Input.GetKey(KeyCode.A))
        {   
            MyPos.x -= MovementSpeed;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            MyPos.x += MovementSpeed;
        }

        if(MyPos.x<LeftBoundry)
            MyPos.x = LeftBoundry;
        if(MyPos.x>RightBoundry)
            MyPos.x = RightBoundry;
        
        transform.position = MyPos;
    }
}
