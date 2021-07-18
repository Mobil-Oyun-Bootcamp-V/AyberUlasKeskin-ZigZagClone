using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardChecker : MonoBehaviour
{
    private Vector3 direction;
    public static bool cardFallControl;
    private int _bestScore;
    public static int _score;
    // Start is called before the first frame update
    void Start()
    {
        _bestScore = PlayerPrefs.GetInt("highScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    private void OnCollisionExit(Collision _collision)
    {
        if (_collision.gameObject.tag == "Card")
        {
            
            if (transform.position.y <= 0.7)
            {
                cardFallControl = true;
                _score++;
                print(_score);
                if (_score > _bestScore)
                {
                    _bestScore = _score;
                    PlayerPrefs.SetInt("bestScore",_bestScore);
                }
                UIManager.instance.ScoreManager(_score,_bestScore);
            }
            if (cardFallControl == true)
            {
                return;
            
            }
        }
    }
}
