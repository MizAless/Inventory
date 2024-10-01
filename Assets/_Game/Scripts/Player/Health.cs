public class Health
{
    public Stat<float> StatProperty { get; private set; }

    public Health(float value)
    {
        StatProperty = new Stat<float>(value);
    }

    public void TakeDamage(float damage)
    {
        StatProperty.Value -= damage;
    }
}
