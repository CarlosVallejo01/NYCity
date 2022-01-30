using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dronController : MonoBehaviour
{   
    //Initial speed
    public float dronSpeed = 15.0f;
    //Initial rotation speed
    public float dronRotationSpeed = 100.0f;


    // Update is called once per frame
    void Update()
    {
        //Get the vertical keys and transform the position of the dron
        float translation = Input.GetAxis("Vertical") * dronSpeed * Time.deltaTime;
        //Get the horizontal keys and transform the rotation of the dron
        float rotation = Input.GetAxis("Horizontal") * dronRotationSpeed * Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }

    void OnCollisionEnter(Collision c){
        // force is how forcefully we will push the dron away from the enemy.
        float force = 1000;
            // Calculate Angle Between the collision point and the dron
            Vector3 dir = c.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the dron
            GetComponent<Rigidbody>().AddForce(dir*force);
    }
}
