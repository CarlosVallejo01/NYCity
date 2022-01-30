
using UnityEngine;

public class collision : MonoBehaviour
{
      void OnCollisionEnter(Collision collision){
          print("Collision detected: " + collision.transform.tag);
       if(collision.transform.tag == "car"){
           print("Tag detected");
           Destroy(collision.transform.gameObject);
       }
   }
}
