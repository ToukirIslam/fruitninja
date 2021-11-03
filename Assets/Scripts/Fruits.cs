using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    public GameObject slicedFruitPrefeb;
    public float explotinRadius = 5f;
    public void CreateSlicedFruit()
    {
        GameObject inst = Instantiate(slicedFruitPrefeb, transform.position,transform.rotation);

        Rigidbody[] rbsliced = inst.transform.GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rigidbody in rbsliced) //the collection that we go through , type Rigidbody in rbsliced name object rigidbody 
        {
            rigidbody.transform.rotation = Random.rotation;
            rigidbody.AddExplosionForce(Random.Range(500, 1000), transform.position, explotinRadius);
        }

        Destroy(gameObject);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { 
            CreateSlicedFruit();
        }
    }
}
