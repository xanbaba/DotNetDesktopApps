#define DEBUGGER
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Controls;

public class Calculator
{
    private readonly string _equation;

    private Node _mainNode = null!;

    public Calculator(string equation)
    {
        _equation = equation;
        ImplementMainNode();
    }

    public string Calculate()
    {
        while (_mainNode.Links != null)
        {
            var firstOperandNode = _mainNode;
            var operatorNode = _mainNode;
            var secondOperandNode = _mainNode;

            while (secondOperandNode.Links != null)
            {
                firstOperandNode = operatorNode;
                operatorNode = secondOperandNode;
                secondOperandNode = secondOperandNode.Links.First();
            }

            if (CalculatorHelper.IsNodeNumber(firstOperandNode) &&
                CalculatorHelper.IsNodeNumber(secondOperandNode) &&
                OperatorsHelper.IsOperator(operatorNode.Value))
            {
                firstOperandNode.Value = CalculateSimpleEquation(firstOperandNode, secondOperandNode, operatorNode)
                    .ToString(CultureInfo.CurrentCulture);
                firstOperandNode.Links.RemoveAt(0);
                if (firstOperandNode.Links.Count == 0)
                {
                    firstOperandNode.Links = null;
                }
            }
            else
            {
                throw new ArgumentException("The equation is in invalid format");
            }
        }

        return _mainNode.Value;
    }

    private decimal CalculateSimpleEquation(Node firstOperandNode, Node secondOperandNode, Node operatorNode)
    {
        var firstOperand = decimal.Parse(firstOperandNode.Value);
        var secondOperand = decimal.Parse(secondOperandNode.Value);
        try
        {
            switch (OperatorsHelper.GetOperator(operatorNode.Value))
            {
                case Operators.Power:
                    if (firstOperand < 0)
                    {
                        return -(decimal)Math.Pow((double)firstOperand * -1, (double)secondOperand);
                    }

                    return (decimal)Math.Pow((double)firstOperand, (double)secondOperand);
                case Operators.Divide:
                    try
                    {
                        return firstOperand / secondOperand;
                    }
                    catch (DivideByZeroException)
                    {
                        throw new ArgumentException("Division by zero");
                    }
                case Operators.Plus:
                    return firstOperand + secondOperand;
                case Operators.Minus:
                    return firstOperand - secondOperand;
                case Operators.Multiply:
                    return firstOperand * secondOperand;
                case Operators.Remainder:
                    return firstOperand % secondOperand;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        catch (OverflowException)
        {
            throw new ArgumentException("The number is too big");
        }
    }

    private void ImplementMainNode()
    {
        _mainNode = new Node();
        var isLastOperator = true;
        for (var i = 0; i < _equation.Length; i++)
        {
            var symbol = _equation[i];
            if (char.IsNumber(symbol) || (isLastOperator && symbol == (char)Operators.Minus &&
                                          _equation.Length != i + 1 && char.IsNumber(_equation[i + 1])))
            {
                AddNumber(ref i);
                isLastOperator = false;
            }
            else if (OperatorsHelper.IsOperator(symbol.ToString()))
            {
                AddOperator(symbol);
                isLastOperator = true;
            }
        }
    }

    private void AddNumber(ref int startIndex)
    {
        var currentNode = _mainNode;
        var number = CalculatorHelper.ReadNumber(_equation, startIndex, out var endIndex);
        startIndex = endIndex - 1;
        while (currentNode.Links != null)
        {
            currentNode = currentNode.Links.Last();
        }

        if (currentNode == _mainNode)
        {
            currentNode.Value = number;
        }
        else
        {
            currentNode.Links = new List<Node>
            {
                new()
                {
                    Value = number
                }
            };
        }
    }

    private void AddOperator(char symbol)
    {
        var @operator = (Operators)symbol;
        var isAdded = false;
        var currentNode = _mainNode;
        while (currentNode.Links != null)
        {
            if (OperatorsHelper.IsOperator(currentNode.Links.Last().Value))
            {
                var compare = OperatorsHelper.CompareOperatorsPowers(
                    @operator, (Operators)currentNode.Links.Last().Value[0]);
                if (compare == 1 || @operator == Operators.Power)
                {
                    currentNode = currentNode.Links.Last();
                    continue;
                }

                if (compare == 0 || compare == -1)
                {
                    currentNode.Links!.Add(new Node
                    {
                        Value = symbol.ToString()
                    });
                    isAdded = true;
                    break;
                }
            }
            else
            {
                currentNode = currentNode.Links.Last();
            }
        }

        if (!isAdded)
        {
            currentNode.Links = new List<Node>
            {
                new()
                {
                    Value = symbol.ToString()
                }
            };
        }
    }
}