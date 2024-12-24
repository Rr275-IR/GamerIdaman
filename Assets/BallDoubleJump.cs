using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallDoubleJump : MonoBehaviour
{
    public float jumpForce = 30f;
    private int jumpCount = 0;
    private Rigidbody rb;
    public TMP_InputField forceInputField;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (forceInputField == null)
        {
            GameObject inputFieldObject = GameObject.FindGameObjectWithTag("InputField");
            if (inputFieldObject != null)
            {
                forceInputField = inputFieldObject.GetComponent<TMP_InputField>();
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1) && jumpCount < 1)
        {
            if (float.TryParse(forceInputField.text, out float newForce))
            {
                jumpForce = newForce;
            }
            else
            {
                jumpForce = 30f;
            }
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpCount++;
        }
    }
}
