﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Input.deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                SceneLabel.text = "Portrait";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(270.0f, -80.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-317.0f, -131.0f);
                break;
            case DeviceOrientation.LandscapeLeft:
                SceneLabel.text =  "LandscapeLeft";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(405.0f, -77.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-510.0f, -77.0f);
                break;
            case DeviceOrientation.LandscapeRight:
                SceneLabel.text = "LandscapeRight";
                LivesLabel.rectTransform.anchoredPosition = new Vector2(654.0f, -159.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(46.0f, -159.0f);
                break;
            case DeviceOrientation.Unknown:
                SceneLabel.text = "Unknown";
                break;
            default:
               SceneLabel.text = "Unknown";
                break;
        }
    }
}
