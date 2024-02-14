using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevate : MonoBehaviour
{
    [SerializeField] GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position += new Vector3(0, 1, 0);
        }
    }
}
