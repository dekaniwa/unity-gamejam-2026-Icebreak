using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI scoreText;

    private int currentScore = 0;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateScoreDisplay();
    }

    // アイテム回収時に呼び出してもらう用(引数でポイント数を指定できる)
    public void AddScore(int amount)
    {
        currentScore += amount;
        UpdateScoreDisplay();
    }

    void UpdateScoreDisplay()
    {
        if (scoreText == null) return;
        scoreText.text = string.Format("Score {0}", currentScore);
    }

    public int GetScore() => currentScore;
}