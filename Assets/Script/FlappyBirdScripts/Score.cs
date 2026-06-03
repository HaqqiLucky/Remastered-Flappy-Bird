using TMPro;
using UnityEditor;
using UnityEngine;

public class Score : MonoBehaviour
{

    public static Score instance;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI hi;

    private int skor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        score.text = skor.ToString();
        hi.text = PlayerPrefs.GetInt("Hi", 0).ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if (skor > PlayerPrefs.GetInt("Hi"))
        {
            PlayerPrefs.SetInt("Hi", skor);
            hi.text = skor.ToString();

        }
    }

    public void UpdateScore()
    {
        skor++;
        score.text = skor.ToString();
        UpdateHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
