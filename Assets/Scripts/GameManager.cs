using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int targetScore = 4;
    private int score = 0;
    public Text scoreText;


    private void Awake()
    {
        // Enforce one instance
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            
        }
        else
        { 
            Destroy(gameObject);
        }
       
    }


    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();
    }


    private void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {score}";
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}


