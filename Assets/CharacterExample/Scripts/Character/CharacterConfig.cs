using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private GroundedStateConfig _runningStateConfig;
    [SerializeField] private AirborneStateConfig _airborneStateConfig;

    public GroundedStateConfig GroundedStateConfig => _runningStateConfig;
    public AirborneStateConfig AirborneStateConfig => _airborneStateConfig;
}
