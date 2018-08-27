using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Operation 的摘要描述
/// </summary>
public class Operation
{
    private double _numberA = 0;
    private double _numberB = 0;

    public Operation()
    {
        //
        // TODO: 在這裡新增建構函式邏輯
        //
    }

    public double numberA
    {
        get
        {
            return _numberA;
        }

        set
        {
            _numberA = value;
        }
    }

    public double numberB
    {
        get
        {
            return _numberB;
        }
        set
        {
            _numberB = value;
        }
    }

    public virtual double GetResault()
    {
        double resault = 0;
        return resault;
    }
}

class OperationAdd : Operation
{
    public override double GetResault()
    {
        double resault = 0;
        resault = numberA + numberB;
        return resault;
    }
}

class OperationSub : Operation
{
    public override double GetResault()
    {
        double resault = 0;
        resault = numberA - numberB;
        return resault;
    }
}

class OperationMul : Operation
{
    public override double GetResault()
    {
        double resault = 0;
        resault = numberA * numberB;
        return resault;
    }
}

class OperationDiv :Operation
{
    public override double GetResault()
    {
        double resault = 0;
        if(numberB == 0)
        {
            throw new Exception("被除數不得為0");
        }
        resault = numberA / numberB;
        return resault;
    }
}

public class OperationFactory
{
    public static Operation createOperate(string operate)
    {
        Operation oper = null;
        switch (operate)
        {
            case "+":
                oper = new OperationAdd();
                break;
            case "-":
                oper = new OperationSub();
                break;
            case "*":
                oper = new OperationMul();
                break;
            case "/":
                oper = new OperationDiv();
                break;
        }
        return oper;
    }
}