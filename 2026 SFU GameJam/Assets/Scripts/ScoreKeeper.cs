using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper instance;

    public TextMeshProUGUI scoreTMP;

    int score = 0;


    private void Awake()
    {
        instance = this;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreTMP.text = score.ToString();
    }

    public void AddP(int i)
    {
        score += i;
        scoreTMP.text = score.ToString();

    }

}
