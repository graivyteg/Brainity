using UnityEngine;

public class AddModelGenerator : IModelGenerator
{
    public ExerciseModel Generate()
    {
        int num1 = Random.Range(1, GameManager.Instance.AddMaxNumber);
        int num2 = Random.Range(1, GameManager.Instance.AddMaxNumber);
        bool tempTruth = Random.Range(0, 2) == 1;
        int result = 0;
          
        if (tempTruth)
        {
            result = num1 + num2;
        }
        else
        {
            int dist = GameManager.Instance.MaxAnswerDistance;
            result = Random.Range(Mathf.Max(dist, num1 + num2) - dist, num1 + num2 + dist);
            if (result == num1 + num2)
            {
                result += 1;
            }
        }

        return new MathProblemModel(num1, '+', num2, result);
    }
}