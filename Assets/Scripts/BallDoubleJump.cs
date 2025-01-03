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
            //if (float.TryParse(forceInputField.text, out float newForce))
            //{
            //    jumpForce = newForce;
            //}
            //else
            //{
            //    jumpForce = 30f;
            //}
            //rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //jumpCount++;
            //if (forceInputField != null)
            //{
            //    if (float.TryParse(forceInputField.text, out float newForce))
            //    {
            //        jumpForce = newForce;
            //    }
            //    else
            //    {
            //        jumpForce = 30f;
            //    }

            //    // Nonaktifkan Canvas setelah gaya diinput
            //    if (forceInputField.transform.parent != null)
            //    {
            //        forceInputField.transform.parent.gameObject.SetActive(false);
            //    }

            //    rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //    jumpCount++;
            //}
            //float.TryParse(forceInputField.text, out float newForce);
            //jumpForce = newForce;
            GameObject temp = GameObject.FindGameObjectWithTag("ForceSave");
            saveForce = temp.GetComponent<TMP_Text>();
            //GameObject inputFieldObject = GameObject.FindGameObjectWithTag("InputField");
            //forceInputField = inputFieldObject.GetComponent<TMP_InputField>();

            float.TryParse(saveForce.text, out float newForce);
            jumpForce = newForce;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpCount++;
        }
    }
    //public void ResetJumpCount()
    //{
    //    jumpCount = 0; // Reset jumlah lompatan
    //    Debug.Log("Jump count has been reset.");
    //}
    public void ButtonChangeForce()
    {
        float.TryParse(forceInputField.text, out float newForce);
        jumpForce = newForce;
        //rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        //jumpCount++;
    }
}
