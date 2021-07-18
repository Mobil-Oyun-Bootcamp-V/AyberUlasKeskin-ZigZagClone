using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoSingleton<UIManager>
{
     
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private TextMeshProUGUI _bestScore;
    [SerializeField] private TextMeshProUGUI _currentScore;
    [SerializeField] private GameObject _main;
    [SerializeField] private GameObject _start;
    
   

    public void GameStart()
    {
        _start.SetActive(true);
        _main.SetActive(false);
        _gameOverPanel.SetActive(false);
    }
    
    public void GameMain()
    {
        _start.SetActive(false);
        
        _main.SetActive(true);
        _gameOverPanel.SetActive(false);
    }
    public void GameOver()
    {
        _start.SetActive(false);
        _main.SetActive(false);
<<<<<<< HEAD
        _gameOverPanel.SetActive(true);
        
    }
   
=======
        
    }
 
>>>>>>> 39f25feb411f2b21c43a024487085b2fe4299f0e
    public void ScoreManager(int score, int bestScore)
    {
        _currentScore.text = $"{score}";
        _score.text = $"{score}";
        _bestScore.text = $"{bestScore}";

    }
  
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
