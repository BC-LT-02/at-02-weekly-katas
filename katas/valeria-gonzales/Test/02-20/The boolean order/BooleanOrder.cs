namespace TheBooleanOrder;
using System.Numerics;

public class BooleanOrder
{
    private readonly string _operands;
    private readonly string _operators;
    private readonly int _operandsQuantity;

    public BooleanOrder(string operands, string operators)
    {
        _operands = operands;
        _operators = operators;
        _operandsQuantity = operands.Length;
    }

    public BigInteger Solve()
    {
        var waysToFormATrue = new BigInteger[_operandsQuantity, _operandsQuantity];
        var waysToFormAFalse = new BigInteger[_operandsQuantity, _operandsQuantity];

        for (int i = 0; i < _operandsQuantity; i++)
        {
            var isTrue = _operands[i] == 't';
            waysToFormATrue[i, i] = isTrue ? BigInteger.One : BigInteger.Zero;
            waysToFormAFalse[i, i] = isTrue ? BigInteger.Zero : BigInteger.One;
        }

        for (int length = 2; length <= _operandsQuantity; length++)
        {
            for (int i = 0; i < _operandsQuantity - length + 1; i++)
            {
                var j = i + length - 1;

                for (int k = i; k < j; k++)
                {
                    var leftTrue = waysToFormATrue[i, k];
                    var leftFalse = waysToFormAFalse[i, k];
                    var rightTrue = waysToFormATrue[k + 1, j];
                    var rightFalse = waysToFormAFalse[k + 1, j];

                    switch (_operators[k])
                    {
                        case '&':
                            waysToFormATrue[i, j] += leftTrue * rightTrue;
                            waysToFormAFalse[i, j] += leftTrue * rightFalse + leftFalse * rightTrue + leftFalse * rightFalse;
                            break;

                        case '|':
                            waysToFormATrue[i, j] += leftTrue * rightTrue + leftTrue * rightFalse + leftFalse * rightTrue;
                            waysToFormAFalse[i, j] += leftFalse * rightFalse;
                            break;

                        case '^':
                            waysToFormATrue[i, j] += leftTrue * rightFalse + leftFalse * rightTrue;
                            waysToFormAFalse[i, j] += leftTrue * rightTrue + leftFalse * rightFalse;
                            break;
                    }
                }
            }
        }

        return waysToFormATrue[0, _operandsQuantity - 1];
    }
}
