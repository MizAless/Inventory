using UnityEngine;

[CreateAssetMenu(fileName = nameof(PlayerStatsConfig), menuName = nameof(PlayerStatsConfig), order = 51)]
public class PlayerStatsConfig : ScriptableObject
{
    [field: SerializeField] public int Health { get; private set; }  
    [field: SerializeField] public int Power { get; private set; }
    [field: SerializeField] public int Endurance { get; private set; }
    [field: SerializeField] public int Wisdom { get; private set; }
    [field: SerializeField] public float Speed { get; private set; }
}
