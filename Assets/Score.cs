using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    static public int  currentScore = 0;
   public Text ScoreText; 

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = currentScore.ToString();
    }

    
}
