using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Zamanlayici : MonoBehaviour
{
    public float sure;//Deneme süresi

    public TextMeshProUGUI dkText;
    public TextMeshProUGUI snText;
    public TMP_InputField dkInput;

    private float gecenSure;
    private float kalanSure;
    private bool playing;

    private void Start()
    {
        kalanSure = sure;
        playing = false;
        gecenSure = 0f;
        dkText.text = "00";
        snText.text = "00";
    }

    private void Update()
    {
        if (playing)
        {
            gecenSure += Time.deltaTime;
        }
        guncelle();
    }

    private void guncelle()
    {
        kalanSure = sure - gecenSure;

        if (kalanSure < 0) { playing = false; }
        int dk = (int)kalanSure / 60;
        int sn = (int)kalanSure % 60;

        dkText.text = (dk < 10) ? dkText.text = "0" + dk.ToString() : dk.ToString();
        snText.text = (sn < 10) ? snText.text = "0" + sn.ToString() : sn.ToString();

    }

    public void PlayPause()
    {
        if (!playing && kalanSure == sure)
        {
            //buraya belki bir þey yazarým
        }


        playing = !playing;
    }

    public void sureAyarla()
    {
        sure = float.Parse(dkInput.text) * 60;
        gecenSure = 0f;
        playing = false;
    }
}
