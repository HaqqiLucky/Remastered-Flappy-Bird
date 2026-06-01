using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{

    public static SceneControl instance;
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject UIStart;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //Time.timeScale = 0f;

        }

    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;

        //foreach (UIStart.GetComponentInChildren<GameObject>)
        //{
            
        //}
    }

    public void StartTheGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        UIStart.SetActive(false);
    }

    public void RestartTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        StartTheGame();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
