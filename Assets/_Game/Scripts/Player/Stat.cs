using System;

public class Stat<T>
{
    private T _value;

    public Stat(T value)
    {
        Value = value;
    }

    public T Value
    {
        get => _value; 
        set
        {
            _value = value;
            Changed?.Invoke(_value);
        }
    }

    public event Action<T> Changed;
}
