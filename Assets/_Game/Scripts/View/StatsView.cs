using System;
using UnityEngine;
using UnityEngine.UI;
public class StatsView : MonoBehaviour
{
    private const string Power = nameof(Power);
    private const string Endurance = nameof(Endurance);
    private const string Wisdom = nameof(Wisdom);

    [SerializeField] private Text _powerLabel;
    [SerializeField] private Text _enduranceLabel;
    [SerializeField] private Text _wisdomLabel;

    public void ChangePower(string power)
    {
        _powerLabel.text = Power + ": " + power;
    }

    public void ChangeEndurance(string endurance)
    {
        _enduranceLabel.text = Endurance + ": " + endurance;
    }

    public void ChangeWisdom(string wisdom)
    {
        _wisdomLabel.text = Wisdom + ": " + wisdom;
    }
}
