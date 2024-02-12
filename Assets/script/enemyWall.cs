using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWall : MonoBehaviour
{
    [SerializeField] private bool isWall;
    [SerializeField] private float wallDistance;
    [SerializeField] private LayerMask wallMask;


    [SerializeField] private float x, y, z;

    [SerializeField] private Transform me;

   

    // Update is called once per frame
    void Update()
    {
        isWall = Physics.CheckSphere(transform.position, wallDistance, wallMask);

        if (isWall )
        {
            me.transform.position += new Vector3(x, y, z);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, wallDistance);

    }
}
