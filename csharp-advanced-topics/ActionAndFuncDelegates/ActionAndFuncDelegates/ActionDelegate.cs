﻿namespace ActionAndFuncDelegates;

public class ActionDelegate
{
    public static void Driver()
    {
        Action<string> actionWithOneParameter = MethodWithStringParameter;
        actionWithOneParameter("code-maze");

        Action<string, bool> actionWithTwoParameter = MethodWithStringAndBoolParameter;
        actionWithTwoParameter("code=maze", true);
    }

    public static void MethodWithStringParameter(string name)
    {
        Console.WriteLine($"Called from Action<string> delegate with parameter : {name}");
    }

    public static void MethodWithStringAndBoolParameter(string name, bool canPrint)
    {
        if (canPrint)
        {
            Console.WriteLine($"Called from Action<string,bool> delegate with name parameter as : {name}");
        }
    }

    public static void MethodWithVoidReturnTypeAndNoParameter()
    {
        Action simpleAction = MethodWithVoidReturnTypeAndNoParameter;
        simpleAction();

        Console.WriteLine($"Action delegate Called");
    }
}