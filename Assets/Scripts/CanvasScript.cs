using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public ScoreManager scoremanager;

    void Update()
    {
        if (scoremanager.canStartable)
        {
            Destroy(transform.Find("PlayButton").gameObject);
            Destroy(transform.Find("TapToPlay").gameObject);
        }
    }
}
