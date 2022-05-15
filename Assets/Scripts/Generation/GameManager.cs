using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int MaxAnswerDistance;
    public int AddMaxNumber;

    private MathProblemModel _currentModel;
     
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else if(Instance != this) Destroy(gameObject);
        
        GenerateNewExercise();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateNewExercise();
        }

        if (Input.GetKeyDown(KeyCode.Y) && _currentModel != null)
        {
            Debug.Log(_currentModel.IsUserRight(true));
            GenerateNewExercise();
        }
        if (Input.GetKeyDown(KeyCode.N) && _currentModel != null)
        {
            Debug.Log(_currentModel.IsUserRight(false));
            GenerateNewExercise();
        }
          
    }

    private void GenerateNewExercise()
    {
        IModelGenerator generator = new AddModelGenerator();
        _currentModel = (MathProblemModel)generator.Generate();
        Debug.Log(_currentModel.ToString());
    }
}