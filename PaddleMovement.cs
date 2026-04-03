using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed = 8f;
    public string inputAxis;

    void Update()
    {
        float move = Input.GetAxis(inputAxis);
        transform.Translate(Vector2.up * move * speed * Time.deltaTime);
    }
}