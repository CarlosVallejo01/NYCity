using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carGenerator : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;
    public GameObject car5;
    public GameObject car6;
    public GameObject car7;
    public GameObject car8;
    private GameObject[] cars;
    void Start()
    {
        cars =  new GameObject[] {car1, car2, car3, car4, car5, car6, car7, car8};
        StartCoroutine(prefabSpawn());
    }

    IEnumerator prefabSpawn(){
        while(true){
            //We select a number from 1 to 8
            Instantiate(cars[Random.Range(1,8)], new Vector3(234.5F, 18.78F, 134F), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(5,10));
        }
    }
}

/*
Random rnd = new Random();

for (int j = 0; j < 4; j++)
{
    Console.WriteLine(rnd.Next(10));//returns random integers < 10
}

*/