using UnityEngine;

public class Step : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }
}