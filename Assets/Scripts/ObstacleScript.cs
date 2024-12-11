using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    // Batasan jangkauan posisi
    public Vector3 minPosition; // Posisi minimum (x, y, z)
    public Vector3 maxPosition; // Posisi maksimum (x, y, z)

    // Kecepatan gerakan
    public float moveSpeed = 2f;

    // Waktu tunggu di setiap posisi
    public float waitTime = 1f;

    private Vector3 targetPosition; // Posisi tujuan berikutnya
    // Start is called before the first frame update
    void Start()
    {
        // Tentukan posisi tujuan awal secara acak
        SetRandomTargetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        // Gerakkan balok ke posisi tujuan
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Jika sudah sampai di posisi tujuan, tentukan posisi baru
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
