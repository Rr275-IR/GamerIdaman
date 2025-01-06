using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallDoubleJump : MonoBehaviour
{
    public float jumpForce = 30f;
    private int jumpCount = 0;
    private Rigidbody rb;
    public TMP_InputField forceInputField;
    public TMP_Text saveForce;
    private bool canDoubleJump = true;
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
        if (Input.GetMouseButtonDown(1) && jumpCount < 1 && canDoubleJump)
        {
            GameObject temp = GameObject.FindGameObjectWithTag("ForceSave");
            saveForce = temp.GetComponent<TMP_Text>();

            float.TryParse(saveForce.text, out float newForce);
            jumpForce = newForce;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpCount++;
        }
    }
    public void ButtonChangeForce()
    {
        float.TryParse(forceInputField.text, out float newForce);
        jumpForce = newForce;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
        {
            canDoubleJump = false;
        }
    }
}
