namespace DataStructures;

public class HashMap<TValue>
{
    private readonly LinkedList<KeyValuePair<string, TValue>>[] _values;
    private readonly int _capacity;

    public HashMap(int capacity = 10)
    {
        _capacity = capacity;
        _values = new LinkedList<KeyValuePair<string, TValue>>[capacity];
    }

    public void Set(string key, TValue value)
    {
        var index = Hash(key);

        if (_values[index] == null)
        {
            _values[index] = new LinkedList<KeyValuePair<string, TValue>>();
        }

        foreach (var pair in _values[index])
        {
            if (pair.Key == key)
            {
                _values[index].Remove(pair);
                break;
            }
        }

        _values[index].AddLast(new KeyValuePair<string, TValue>(key, value));
    }

    public TValue Get(string key)
    {
        var index = Hash(key);

        if (_values[index] != null)
        {
            foreach (var pair in _values[index])
            {
                if (pair.Key == key)
                {
                    return pair.Value;
                }
            }
        }

        throw new KeyNotFoundException("Key not found.");
    }

    private int Hash(string key) =>
        Math.Abs(key.GetHashCode()) % _capacity;
}