using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private screenShake screen;



    public void moveUp() 
    {
        stamina CurrentStamina = GetComponent<stamina>();

        if (CurrentStamina != null)
        {
            float currentStamina = CurrentStamina.GetCurrentStamina();

            if (currentStamina > 0) 
            {
                player.transform.position += new Vector3(0, 0, 1);
            } 
            else
            {
                screen.Shake();
                Debug.Log("Can't Move");
            }
        }

    
    }

    public void moveRight()
    {

        stamina CurrentStamina = GetComponent<stamina>();

        if (CurrentStamina != null)
        {
            float currentStamina = CurrentStamina.GetCurrentStamina();

            if (currentStamina > 0)
            {
                player.transform.position += new Vector3(1, 0, 0);
            }
            else
            {
                screen.Shake();
                Debug.Log("Can't Move");
            }
        }
       
    }

    public void moveLeft()
    {

        stamina CurrentStamina = GetComponent<stamina>();

        if (CurrentStamina != null)
        {
            float currentStamina = CurrentStamina.GetCurrentStamina();

            if (currentStamina > 0)
            {
                player.transform.position += new Vector3(-1, 0, 0);
            }
            else
            {
                screen.Shake();
                Debug.Log("Can't Move");
            }
        }
        
    }

    public void moveDown()
    {

        stamina CurrentStamina = GetComponent<stamina>();

        if (CurrentStamina != null)
        {
            float currentStamina = CurrentStamina.GetCurrentStamina();

            if (currentStamina > 0)
            {
                player.transform.position += new Vector3(0, 0, -1);
            }
            else
            {
                screen.Shake();
                Debug.Log("Can't Move");
            }
        }
        
    }
}
