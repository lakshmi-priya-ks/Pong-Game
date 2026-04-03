using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int leftScore = 0;
    public int rightScore = 0;

    public TMP_Text leftText;
    public TMP_Text rightText;

    public Ball ball;

    void Start()
    {
        UpdateScoreUI(); 
    }

    public void LeftScores()
    {
        if (!CheckReferences()) return;

        leftScore++;
        UpdateScoreUI();
        ball.ResetBall();
    }

    public void RightScores()
    {
        if (!CheckReferences()) return;

        rightScore++;
        UpdateScoreUI();
        ball.ResetBall();
    }

    void UpdateScoreUI()
    {
        if (leftText != null)
            leftText.text = leftScore.ToString();

        if (rightText != null)
            rightText.text = rightScore.ToString();
    }

    bool CheckReferences()
    {
        bool isValid = true;

        if (leftText == null)
        {
            Debug.LogError("LeftText is NULL");
            isValid = false;
        }

        if (rightText == null)
        {
            Debug.LogError("RightText is NULL");
            isValid = false;
        }

        if (ball == null)
        {
            Debug.LogError("Ball is NULL");
            isValid = false;
        }

        return isValid;
    }
}