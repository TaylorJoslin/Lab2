using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class youwin : MonoBehaviour
{
    [SerializeField] private TMP_Text win;

    // Start is called before the first frame update
    void Start()
    {
        win.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            win.gameObject.SetActive(true);

        }
    }
}
