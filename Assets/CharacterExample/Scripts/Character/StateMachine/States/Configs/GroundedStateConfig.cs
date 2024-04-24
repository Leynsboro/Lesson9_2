using System;
using UnityEngine;

[Serializable]
public class GroundedStateConfig
{
    [field: SerializeField, Range(0, 10)] public float RunningSpeed { get; private set; }

    [field: SerializeField, Range(0, 10)] public float SpringtingSpeed { get; private set; }

    [field: SerializeField, Range(0, 10)] public float WalkingSpeed { get; private set; }
}
