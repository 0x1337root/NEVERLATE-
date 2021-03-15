using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Text time;

    public Text scoreText;

    public PlayerScript playersc;

    public float score = 0;

    public Button playButton;

    public bool canStartable = false;

    void Start()
    {
        playButton.onClick.AddListener(letStart);
    }

    void Update()
    {
        if (canStartable)
        {
            scoreText.text = "Score\n" + score.ToString();

            if (playersc.countdown >= .5f)
            {
                time.text = "Time\n" + playersc.countdown.ToString("0");
            }

            else
            {
                time.text = "";
            }
        }
    }

    void letStart()
    {
        canStartable = true;
    }
}
