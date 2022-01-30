using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollowScript : MonoBehaviour
{   
    //Here the dron Object is going to be set
    public Transform targetObject;
    //public Vector3 cameraOffset;

    // Update is called once per frame
    void LateUpdate()
    {
        //We get the position of the dron
       Vector3 newPosition = targetObject.transform.position;
       //We position the main camara where the dron is located
       transform.position = newPosition;
       //We rotate the main camara how the dron is rotated
       float yRotation = targetObject.eulerAngles.y;
       transform.eulerAngles = new Vector3( transform.eulerAngles.x, yRotation, transform.eulerAngles.z );

    }
}
