using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class BallVelocityDisplay : MonoBehaviour
{
    public Rigidbody ballRigidbody;
    public TMP_Text velocityText;       
    void Start()
    {
        if (velocityText == null)
        {
            GameObject inputFieldObject = GameObject.FindGameObjectWithTag("Velocity");
            if (inputFieldObject != null)
            {
                velocityText = inputFieldObject.GetComponent<TMP_Text>();
            }
        }
    }
    void Update()
    {
        if (ballRigidbody != null && velocityText != null)
        {
            Vector3 velocity = ballRigidbody.velocity;
            float vx = velocity.z;
            float vy = velocity.y;
            velocityText.text = $"Vx: {Math.Round(velocity.z,2)} \n Vy: {Math.Round(velocity.y,2)}";
        }
    }
}
