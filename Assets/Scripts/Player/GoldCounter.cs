using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldCounter : MonoBehaviour
{
    public int totalGoldCollected;

    [SerializeField] private TextMeshProUGUI goldCollectedText;
    [SerializeField] private int resetCount = 0;

    private void OnEnable()
    {
        CounterPickup.OnGoldUpdate += IncreaseGoldCount;
    }

    private void OnDisable()
    {
        CounterPickup.OnGoldUpdate -= IncreaseGoldCount;
    }

    // when the OnMarbleReset event is announced, we increase the counter's value

    private void IncreaseGoldCount()
    {
        resetCount++;
        goldCollectedText.text = resetCount.ToString();
    }
}
