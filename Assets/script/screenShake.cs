using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenShake : MonoBehaviour
{
    [SerializeField] private float shakeDuration = 0.1f; // Duration of the shake effect
    [SerializeField] private float shakeIntensity = 0.3f; // Intensity of the shake effect

    private Vector3 originalPosition;
    private float shakeTimer = 0f;

    void Start()
    {
        originalPosition = transform.localPosition; // Store the original position of the camera
    }

    void Update()
    {
        if (shakeTimer > 0)
        {
            // Generate a random offset based on shake intensity
            Vector3 randomOffset = Random.insideUnitSphere * shakeIntensity;

            // Apply the offset to the camera's position
            transform.localPosition = originalPosition + randomOffset;

            // Decrement the timer
            shakeTimer -= Time.deltaTime;
        }
        else
        {
            // Reset the camera position to its original position
            transform.localPosition = originalPosition;
        }
    }

    public void Shake()
    {
        shakeTimer = shakeDuration;
    }
}
