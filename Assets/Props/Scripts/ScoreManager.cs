using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    GameController gc;
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    int score;
    int totalCoins;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        if(instance==null)
            instance=this;
        text.text="X"+score.ToString()+ " / "+ gc.collectables.ToString();
    }
    public void ChangeScore(int coinValue){
        score+=coinValue;
        gc.collectables--;
        text.text="X"+score.ToString()+ " / "+ gc.collectables.ToString();

    }
}
