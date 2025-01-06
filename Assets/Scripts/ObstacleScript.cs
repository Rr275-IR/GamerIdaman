using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    // Batasan jangkauan posisi
    public Vector3 minPosition; // (x, y, z)
    public Vector3 maxPosition; // (x, y, z)

    // Kecepatan gerakan
    public float moveSpeed = 2f;
    public float waitTime = 1f;
    private Vector3 targetPosition;
    void Start()
    {

        SetRandomTargetPosition();
    }


    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            StartCoroutine(WaitAndSetNewTarget());
        }
    }
    void SetRandomTargetPosition()
    {
        float x = Random.Range(minPosition.x, maxPosition.x);
        float y = Random.Range(minPosition.y, maxPosition.y);
        float z = Random.Range(minPosition.z, maxPosition.z);
        targetPosition = new Vector3(x, y, z);
    }

    // Tunggu sebentar sebelum menentukan posisi tujuan baru
    IEnumerator WaitAndSetNewTarget()
    {
        yield return new WaitForSeconds(waitTime);
        SetRandomTargetPosition();
    }
}
