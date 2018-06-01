public abstract class Builder
{
    protected Unit _unit = new Unit();

    public Unit Unit
    {
        get { return _unit; }
    }

    public abstract void SetHP();

    public abstract void SetAttributes();
}