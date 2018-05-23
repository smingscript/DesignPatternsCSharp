class MoveCommand : Command
{
    private readonly int _x;
    private readonly int _y;

    public MoveCommand(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public override void Execute(Marine marine)
    {
        marine.X = _x;
        marine.Y = _y;
    }
}