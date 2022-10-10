using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    private float startingTime;
    public float realStartingTime;
    public static float timerDuration;
    public bool timerActive = false;

    [SerializeField] private TextMeshProUGUI timerText;
    private float seconds;

    void Start()
    {
        timerDuration = realStartingTime;
        timerActive = true;
        
    }

    public void Update()
    {
        if(timerActive)
        {
            if(timerDuration > 0)
            {
                timerDuration -= Time.deltaTime;

                seconds = (int)(timerDuration % 60);
            }
            else
            {
                Debug.Log("Time up");
                timerDuration = 0;
                timerActive = false;
                SceneManager.LoadScene(5);
            }
            timerText.text = seconds.ToString();
        }
    }

    void ResetTextTimer ()
    {
        timerDuration = 11f;

        seconds = (int)(timerDuration % 60);
        timerText.text = seconds.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            ResetTextTimer();
            Debug.Log("Triggered");
            Object.Destroy(gameObject);
        }
    }
}