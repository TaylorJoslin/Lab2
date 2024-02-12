using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class stamina : MonoBehaviour
{
    [SerializeField] private float maxStamina = 100f;
    [SerializeField] private float currentStamina;
    [SerializeField] private float staminaDepletionRate = 1f;
    [SerializeField] private Slider bar;
    [SerializeField] private TMP_Text staminaText;

    private Vector3 lastPosition;

    void Start()
    {
        currentStamina = maxStamina;
        bar.maxValue = maxStamina;
        bar.value = maxStamina;
        lastPosition = transform.position;
    }

    void Update()
    {
        // Calculate distance moved since last frame
        float move = Vector3.Distance(transform.position, lastPosition);

        // Deplete stamina based on distance moved
        currentStamina -= move * staminaDepletionRate;

        // Clamp the stamina value to ensure it doesn't go below 0 or above maxStamina
        currentStamina = Mathf.Clamp(currentStamina, 0, maxStamina);

        // Update the UI slider
        bar.value = currentStamina;

        // Update lastPosition for the next frame
        lastPosition = transform.position;

        // Update UI text
        staminaText.text = Mathf.Round(currentStamina).ToString();
    }

    public float GetCurrentStamina()
    {
        return currentStamina;
    }

    public void healStamina(float heal)
    {
        currentStamina += heal;
        Debug.Log("Recovered " + heal);
    }
}
