using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinspawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject coinPrefab;
    public float spawnInterval = 3f;
    public float coinLifetime = 3f;
    private float timer = 0f;

    void Start()
    {
   
}

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

    if (timer >= spawnInterval)
{
    SpawnCoin();
            timer = 0f;
        }
}

void SpawnCoin()
{
        Vector3 randomPos = new Vector3(0f, 0f, 0f);
     

GameObject newCoin = Instantiate(coinPrefab, randomPos, Quaternion.identity);
Destroy(newCoin, coinLifetime);

  }
}
