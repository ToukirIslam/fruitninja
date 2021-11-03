using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fruit;
    public Transform[] spawnPlaces;
    public float minWait = 0.3f;
    public float maxWait = 1f;

    private void Start()
    {
        StartCoroutine(SpwanFruits());
    }
    IEnumerator SpwanFruits()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWait,maxWait));
            GameObject fruits =  Instantiate(fruit, transform.position, transform.rotation);
        }
    }
}
