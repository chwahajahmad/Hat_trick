using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowScoreAtEnd : MonoBehaviour
{
    
    // Start is called before the first frame update

    public Text txtScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtScore.text = "Score: " + GameObject.Find("Player").GetComponent<PlayerRecord>().Score.ToString();
    }
}
