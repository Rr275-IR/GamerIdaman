using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallDoubleJump : MonoBehaviour
{
    public float jumpForce = 30f;
    private int jumpCount = 0;
    private Rigidbody rb;

    public TMP_InputField forceInputField; // Reference to TMP InputField
    public Button updateButton; // Reference to the Button

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Ensure that TMP_InputField is correctly assigned
        if (forceInputField == null)
        {
            GameObject inputFieldObject = GameObject.FindGameObjectWithTag("InputField");
            if (inputFieldObject != null)
            {
                forceInputField = inputFieldObject.GetComponent<TMP_InputField>();
            }
        }

        // Find the Button using tag
        if (updateButton == null)
        {
            GameObject buttonObject = GameObject.FindGameObjectWithTag("Button");
            if (buttonObject != null)
            {
                updateButton = buttonObject.GetComponent<Button>();
                Debug.Log("Button found and assigned");
            }
            else
            {
                Debug.LogWarning("Button with 'Button' tag not found in the scene.");
            }
        }

        // Check if button is correctly assigned
        if (updateButton != null)
        {
            Debug.Log("Adding listener to update button");
            updateButton.onClick.AddListener(OnUpdateForceButtonClicked);
        }
        else
        {
            Debug.LogWarning("Update Button is not assigned or found.");
        }
    }

    void Update()
    {
        // Perform the jump with the updated jumpForce value
        if (Input.GetMouseButtonDown(1) && jumpCount < 1)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpCount++;
        }
    }

    public void OnUpdateForceButtonClicked()
    {
        // Debug to check if the button click is working
        Debug.Log("Update Button Clicked");

        // Only update force if input field has a valid number
        if (forceInputField != null)
        {
            string inputValue = forceInputField.text; // Get the value from the input field
            Debug.Log("Input Value: " + inputValue); // Log the value

            UpdateJumpForce(inputValue);
        }
    }

    public void UpdateJumpForce(string input)
    {
        Debug.Log("Input value: " + input);
        if (float.TryParse(input, out float newForce))
        {
            jumpForce = newForce;
            Debug.Log($"Jump force updated to: {jumpForce}");
        }
        else
        {
            Debug.LogWarning("Invalid input! Please enter a valid number.");
        }
    }
}
