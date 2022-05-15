using System;
using System.Security.Cryptography.X509Certificates;

public interface IModelGenerator
{
     ExerciseModel Generate();
}

public class RandomNumberPair
{
     public int Num1;
     public int Num2;

     public RandomNumberPair(int num1, int num2)
     {
          Num1 = num1;
          Num2 = num2;
     }
}

public abstract class ExerciseModel
{
     public abstract bool IsUserRight(bool userSuggestion);

     protected bool IsCorrect;
}