using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Kronometre : MonoBehaviour
{
    public TextMeshProUGUI dkText;
    public TextMeshProUGUI snText;

    private float gecenSure;
    private bool playing;

    private void Start()
    {
        playing = false;
        gecenSure = 0;
        dkText.text = "00";
        snText.text = "00";
    }

    private void Update()
    {
        if (playing)
        {
            gecenSure += Time.deltaTime;
        }
        gucelle();
    }

    private void gucelle()
    {
        int dk = (int)gecenSure / 60;
        int sn = (int)gecenSure % 60;

        dkText.text = (dk < 10) ? dkText.text = "0" + dk.ToString() : dk.ToString();
        snText.text = (sn < 10) ? snText.text = "0" + sn.ToString() : sn.ToString();
        
    }

    public void PlayPause()
    {
        playing = !playing;
    }
}
