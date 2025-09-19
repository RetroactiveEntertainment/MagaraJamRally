using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TrackSO", menuName = "Scriptable Objects/TrackSO")]
public class TrackSO : ScriptableObject
{
    public GameObject TrackPiecePrefab;
    public TurnDirection Direction;

    [Tooltip("Lower is easier, 0 is only for straight"), Range(0, 6)]
    public int TurnDifficulty;

    public TurnDuration Duration;
    public bool Titans;
    public bool Crest;
    public bool Jump;
    public bool Caution;
    public bool Water;
}


public enum TurnDirection
{
    Straight,
    Left,
    Right
}

public enum TurnDuration
{
    Normal,
    Short,
    Long
}