using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fruit;
    public Transform[] spawnPlaces;
    public float minWait = 0.3f;
    public float maxWait = 1f;
    public float minForce = 10;
    public float maxForce = 30;

    private void Start()
    {
        StartCoroutine(SpwanFruits());
    }
    IEnumerator SpwanFruits()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWait,maxWait));

            Transform t = spawnPlaces[Random.Range(0,spawnPlaces.Length)]; // to make random point spawner to make game more unpredictable
            GameObject fruits =  Instantiate(fruit, t.transform.position, t.transform.rotation);
            fruit.GetComponent<Rigidbody2D>().AddForce(t.transform.up* Random.Range(minForce, maxForce), ForceMode2D.Impulse);
        }
    }
}
