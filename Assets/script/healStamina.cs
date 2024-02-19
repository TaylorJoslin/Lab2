using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healStamina : MonoBehaviour
{
    [SerializeField] private stamina Stamina;

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Stamina != null)
            {
                Stamina.healStamina(5);
                Destroy(this.gameObject);
            }
        }

           
    }
}
