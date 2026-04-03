using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isLeftGoal;
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Something entered goal: " + collision.name); // 🔥 ADD THIS

        if (collision.CompareTag("Ball"))
        {
            Debug.Log("BALL DETECTED"); // 🔥 ADD THIS

            if (isLeftGoal)
                gameManager.RightScores();
            else
                gameManager.LeftScores();
        }
    }
}