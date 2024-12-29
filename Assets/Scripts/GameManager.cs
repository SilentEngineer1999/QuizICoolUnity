using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    EndScreen endScreen;

    void Awake()
    {
        quiz = FindAnyObjectByType<Quiz>();
        endScreen = FindAnyObjectByType<EndScreen>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        quiz.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (quiz.isComplete)
        {
            quiz.gameObject.SetActive(false);
            endScreen.ShowFinalScore();
            endScreen.gameObject.SetActive(true);
        }
    
    }

    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
