using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerPickup : MonoBehaviour
{
    public float timerDuration;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            TimerManager.timerDuration = 11f;
            Object.Destroy(gameObject);
            Debug.Log ("Trigger Zone");
        }
    }
}
