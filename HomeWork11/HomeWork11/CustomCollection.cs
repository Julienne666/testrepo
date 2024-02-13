using System;
using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class CustomCollection<T> : IEnumerable<T>
{
    private T[] _array;

    public CustomCollection()
    {
        _array = new T[0];
    }

    public void Add(T item)
    {
        var tempArray = new T[_array.Length + 1];

        for (int i = 0; i < _array.Length; i++)
        {
            tempArray[i] = _array[i];
        }

        tempArray[tempArray.Length - 1] = item;

        _array = tempArray;
    }

    public int Count => _array.Length;

    public void Sort(IComparer<T> comparer)
    {
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = i + 1; j < _array.Length; j++)
            {
                if (comparer.Compare(_array[i], _array[j]) > 0)
                {
                    var temValue = _array[i];
                    _array[i] = _array[j];
                    _array[j] = temValue;
                }
            }
        }

    }

    public void SetDefaultAt(int index, T defaultValue) // I would name this method SetValueAt
    {
        if (index >= 0 && index < _array.Length)
        {
            _array[index] = defaultValue;
        }
        else
        {
            Console.WriteLine("Index out of range.");
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in _array)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}