using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterPickup : MonoBehaviour
{
    public delegate void GoldCounterAction();
    public static event GoldCounterAction OnGoldUpdate;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            OnGoldUpdate();
        }
    }
}
