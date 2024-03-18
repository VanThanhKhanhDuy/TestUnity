using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    private Vector3 startPosition;
    private float spriteHeight;

    void Start()
    {
        startPosition = transform.position;
        spriteHeight = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, spriteHeight);
        transform.position = startPosition + Vector3.down * newPosition;
    }
}