using System;
using UnityEngine;
using TMPro;


public class TimeCount : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private float gameTime;
    [SerializeField] private FloatSO gameTimeSo;
    [SerializeField] Gameover gameover;
    TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        timeText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameTimeSo.Value > 0)
        {
            gameTimeSo.Value -= Time.deltaTime;
            updateGameTime(gameTimeSo.Value);
        }
        else
        {
            gameover.gameOverPage();
            playerHealth.disable();
            emptyString();
        }
    }

    public void emptyString()
    {
        timeText.text = String.Empty;
    }
    void updateGameTime(float time)
    {
        //time++;
        float min = Mathf.Floor(time/ 60);
        float sec = Mathf.RoundToInt(time%60);
        //timeText.text = gameTimeSo.Value.ToString(min.ToString("00")) + ":" + gameTimeSo.Value.ToString(sec.ToString("00"));
        timeText.text = String.Format("{0:00}:{1:00}", min, sec);


    }
}