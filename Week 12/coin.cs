sing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private GameManager gm;

    private void Start()
    {
        // Find the GameManager in the scene
        gm = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (gm != null)
            {
                gm.AddScore(1);
            }

            Destroy(gameObject);
        }
    }
}
