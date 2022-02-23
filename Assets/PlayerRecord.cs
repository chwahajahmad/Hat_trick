using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerRecord : MonoBehaviour
{

    public int Lives;
    public int Score;
    // Start is called before the first frame update

    public Text txtScore;
    public Text txtLives;
    void Start()
    {
        Score = 0;
        Lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        txtScore.text = "Score: " + Score.ToString();
        txtLives.text = "Lives: " + Lives.ToString();
        
        if(this.Lives<=0)
        {
            SceneManager.LoadScene(0);
            // SceneManager.UnloadSceneAsync(1);
            
        }
    }
}
