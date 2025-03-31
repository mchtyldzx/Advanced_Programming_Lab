using System;
using System.Collections.Generic;

public class Quadruple<T1, T2, T3, T4> : IComparable<Quadruple<T1, T2, T3, T4>> where T1 : IComparable<T1>
{
    private T1? id;
    private T2? second;
    private T3? third;
    private T4? fourth;

    public T1? Id { get => id; set => id = value; }
    public T2? Second { get => second; set => second = value; }
    public T3? Third { get => third; set => third = value; }
    public T4? Fourth { get => fourth; set => fourth = value; }

    public Quadruple() { }

    public Quadruple(T1 id, T2 second, T3 third, T4 fourth)
    {
        this.id = id;
        this.second = second;
        this.third = third;
        this.fourth = fourth;
    }

    public override string ToString()
    {
        return $"({id}, {second}, {third}, {fourth})";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Quadruple<T1, T2, T3, T4> other)
        {
            return EqualityComparer<T1>.Default.Equals(id, other.id) && 
                   EqualityComparer<T2>.Default.Equals(second, other.second) &&
                   EqualityComparer<T3>.Default.Equals(third, other.third) &&
                   EqualityComparer<T4>.Default.Equals(fourth, other.fourth);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(id, second, third, fourth);
    }

    public int CompareTo(Quadruple<T1, T2, T3, T4>? other)
    {
        if (other == null) return 1;
        if (id == null) return -1;
        if (other.id == null) return 1;
        return id.CompareTo(other.id);
    }
}