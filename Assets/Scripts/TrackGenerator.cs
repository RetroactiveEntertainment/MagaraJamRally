using System;
using System.Collections.Generic;
using UnityEngine;

public class TrackGenerator : MonoBehaviour
{
    public List<TrackSO> trackData = new List<TrackSO>();

    private void Start()
    {
        float zOffset = 0f;
        foreach (var track in trackData)
        {
            Instantiate(track.TrackPiecePrefab, new Vector3(0, 0, zOffset), Quaternion.identity);
            zOffset += 6;
        }
    }
}
