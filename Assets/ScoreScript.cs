using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    // Materialを入れる
    Material myMaterial;    
    private int score = 0; //スコア計算用変数
    private GameObject scoreText;
    // 加算するスコアの値を格納する変数
      
    

    // Use this for initialization
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");        
    }    


    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        string tag = other.gameObject.tag;
        // タグによって得点を変える
        if (tag == "SmallStarTag")
        {
            score += 50;
            
        }
        else if (tag == "LargeStarTag")
        {
            score += 100;
            
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")           
        {
            score += 150;
            
        }
        SetScore();               

    }
    void SetScore()
    {
        scoreText.GetComponent<Text>().text =   string.Format("Score:{0}", score);
    }
}
