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
    
    // Start is called before the first frame update

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
        _gameOverPanel.SetActive(true);
        //StartCoroutine(PanelRoutine(_gameOverPanel));
    }
   // IEnumerator PanelRoutine(GameObject obj)
   // {
     //   yield return new WaitForSeconds(1);
    //    obj.SetActive(true);
   // }
    public void ScoreManager(int score, int bestScore)
    {
        _currentScore.text = $"{score}";
        _score.text = $"{score}";
        _bestScore.text = $"{bestScore}";

    }
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
