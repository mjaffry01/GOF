// Abstract Expression
public interface IExpression
{
    int Interpret();
}

// Terminal Expression
public class NumberExpression : IExpression
{
    private int _number;
    public NumberExpression(int number) => _number = number;
    public int Interpret() => _number;
}

// Non-Terminal Expression
public class AddExpression : IExpression
{
    private IExpression _leftExpression;
    private IExpression _rightExpression;

    public AddExpression(IExpression left, IExpression right)
    {
        _leftExpression = left;
        _rightExpression = right;
    }

    public int Interpret() => _leftExpression.Interpret() + _rightExpression.Interpret();
}

// Usage
 

