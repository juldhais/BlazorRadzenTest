namespace BlazorRadzenTest.Helpers;

public class State<T>
{
    private T _value;
    public T Value
    {
        get { return _value; }
        set
        {
            _value = value;
            OnChange?.Invoke();
        }
    }

    public event Action OnChange;
}
