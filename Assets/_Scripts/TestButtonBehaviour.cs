using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TestButtonBehaviour : MonoBehaviour
{
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTestButtonPressed()
    {
        Debug.Log("TestButtonPressed");
        //Places text in the correct position thats given in the vector2
        //Anchored for Relevant position (UI)
        LivesLabel.rectTransform.anchoredPosition = new Vector2(278.0f, -80.0f);
        ScoreLabel.rectTransform.anchoredPosition = new Vector2(0.0f, -8.0f);
    }
}
