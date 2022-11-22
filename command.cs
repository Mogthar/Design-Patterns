using System.Collections;
using System.Collections.Generic;

public class Command
{
    public Command(){}
    public virtual Execute(){}
    public virtual Undo(){}
}

public class MoveObject : Command
{
    private float[] _previousPosition;
    private float[] _nextPosition;
    private Object _myObject;

    public MoveObject(Object object, float[] nextPosition)
    {
        _myObject = object;
        _previousPosition = _myObject.GetPosition();
        _nextPosition = nextPosition;
    }

    public override Execute()
    {
        _myObject.Move(_nextPosition);
    }

    public override Undo()
    {
        _myObject.Move(_previousPosition);
    }
}

public class Object
{
    private float[] _position;
    public Object(float[] initialPosition)
    {
        _position = initialPosition;
    }

    public float[] GetPosition()
    {
        return _position;
    }

    public void Move(float[] nextPosition)
    {
        _position = newPosition;
    }
}
