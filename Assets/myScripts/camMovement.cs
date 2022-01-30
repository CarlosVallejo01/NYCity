using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMovement : MonoBehaviour
{
    public float speed = 1F;
    float startPosX = 0F;
    float startPosY = 0F;
    float startPosZ = 0F;
    void Start()
    {   
        
        startPosY = transform.position.y;
        startPosX = transform.position.x;
        startPosZ = transform.position.z;
         StartCoroutine(prefabSpawn());
        
    }

    // Update is called once per frame


     IEnumerator prefabSpawn(){
        while(true){
            startPosZ = startPosZ + speed;
            transform.position = new Vector3 (startPosX, startPosY, startPosZ);
            yield return new WaitForSeconds(0.02F);
        }
    }
}
