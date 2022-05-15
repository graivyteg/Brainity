using UnityEngine;

public class MathProblemModel : ExerciseModel
{
    protected int Num1;
    protected int Num2;
    protected int Result;
     
    protected char Symbol;
     
    public MathProblemModel(int num1, char symbol, int num2, int result)
    {
        Num1 = num1;
        Num2 = num2;
        Result = result;

        Symbol = symbol;
    }

    public override bool IsUserRight(bool userSuggestion)
    {
        switch (Symbol)
        {
            case '+':
                IsCorrect = Num1 + Num2 == Result;
                break;
            case '-':
                IsCorrect = Num1 - Num2 == Result;
                break;
            case '/':
                IsCorrect = Num1 * Num2 == Result;
                break;
            case '*':
                IsCorrect = Num1 / Num2 == Result;
                break;
        }

        return IsCorrect == userSuggestion;
    }

    public override string ToString()
    {
        return Num1.ToString() + Symbol + Num2 + '=' + Result;
    }
}