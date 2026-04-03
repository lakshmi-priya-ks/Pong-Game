using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 8f;

    void Start()
    {
        Launch();
    }

    void Launch()
    {
        float x = Random.value > 0.5f ? 1 : -1;
        float y = Random.Range(-0.5f, 0.5f);

        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(x, y).normalized * speed;
    }

    public void ResetBall()
    {
        transform.position = Vector2.zero;
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        Invoke(nameof(Launch), 1f);
    }
}
