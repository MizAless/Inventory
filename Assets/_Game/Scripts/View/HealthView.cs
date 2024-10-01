using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    private const string Health = nameof(Health);

    [SerializeField] private Text _textLabel;

    public void ChangeHealth(string health)
    {
        _textLabel.text = Health + ": " + health;
    }
}
