using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class BeatManager : Singleton<BeatManager>
{
    [SerializeField] private float bpm;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Intervals[] intervals;

    private void Update()
    {
        foreach (Intervals interval in intervals)
        {
            float sampleTime = (audioSource.timeSamples /
                                (audioSource.clip.frequency * interval.GetIntervalLength(bpm)));
            interval.CheckForNewInterval(sampleTime);
        }
    }
}

[System.Serializable]
public class Intervals
{
    [SerializeField] private float steps;
    [SerializeField] private UnityEvent trigger;
    private int lastInterval;

    public float GetIntervalLength(float bpm)
    {
        return 60f / (bpm * steps);
    }

    public void CheckForNewInterval(float internval)
    {
        if (Mathf.FloorToInt(internval) != lastInterval)
        {
            lastInterval = Mathf.FloorToInt(internval);
            SpawnObject();
            trigger.Invoke();
        }
    }

    private void SpawnObject()
    {
        
    }
}