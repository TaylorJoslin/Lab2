using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMovement : MonoBehaviour
{
    [SerializeField] private Transform player;


    public void moveUp() 
    { 
        player.transform.position += new Vector3 (0, 0, 1);
    }

    public void moveRight()
    {
        player.transform.position += new Vector3(1, 0, 0);
    }

    public void moveLeft()
    {
        player.transform.position += new Vector3(-1, 0,0);
    }

    public void moveDown()
    {
        player.transform.position += new Vector3(0, 0, -1);
    }
}
