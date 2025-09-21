using System;
using MoreMountains.Feedbacks;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    public Rigidbody rb;
    private float _lastVelocityMagnitude;

    public float minCrashVelocity;

    public MMF_Player effects;
    public AudioSource crashAudioSource;

    private void LateUpdate()
    {
        _lastVelocityMagnitude = rb.linearVelocity.magnitude;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (Mathf.Abs(_lastVelocityMagnitude - rb.linearVelocity.magnitude) > minCrashVelocity)
        {
            if (effects)
                effects.PlayFeedbacks();
            if (crashAudioSource)
                crashAudioSource.Play();
        }
    }
}
