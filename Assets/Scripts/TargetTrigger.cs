using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TargetTrigger : MonoBehaviour
{
    public int pointsAmount;
    public ScoreTracker tracker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            tracker.Score(pointsAmount);
        }
    }
}