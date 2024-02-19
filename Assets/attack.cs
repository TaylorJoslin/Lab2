using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    [SerializeField] private stamina Stamina;
    [SerializeField] private screenShake screen;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Stamina != null)
            {
                Stamina.healStamina(-3);
                screen.Shake();
                Destroy(this.gameObject);
            }

            
        }
    }
}
