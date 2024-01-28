using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nose : MonoBehaviour 
{
    // Start is called before the first frame update
    public float laughter = 0;

    public Text debugText;

    public Button noseButton;

    public AudioSource honk;
    
    public AudioClip laugh1;
    public AudioClip laugh2;
    public AudioClip laugh3;
    public AudioClip laugh4;
    public AudioClip laugh5;
    public AudioClip laugh6;
    public AudioClip laugh7;
    public AudioClip laugh8;
    public AudioClip laugh9;
    public AudioClip laugh10;
    public AudioClip laugh11;
    public AudioClip laugh12;
    public AudioClip laugh13;
    public AudioClip laugh14;
    public AudioClip laugh15;
    public AudioClip laugh16;

    int decay =0;

    public Slider progressBar;

    [SerializeField] public int decayRateMin;
    [SerializeField] public int decayRateMax;
    [SerializeField] public int decayRate;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        debugText.text = laughter.ToString();
        progressBar.value = laughter / 100;
    }
    private void FixedUpdate()
    {
        if (decay >= decayRate && laughter > 0)
        {
            laughter--;
            decay = 0;
            decayRate = Random.Range(decayRateMin, decayRateMax);
        }
        else
        {
            decay++;
        }
    }
    public void laugh()
    {
        laughter++;
        int i = Random.Range(1, 16);
        switch (i)
        {
            case 1:
                honk.clip = laugh1;
                break;
            case 2:
                honk.clip = laugh2;
                break;
            case 3:
                honk.clip = laugh3;
                break;
            case 4:
                honk.clip = laugh4;
                break;
            case 5:
                honk.clip = laugh5;
                break;
            case 6:
                honk.clip = laugh6;
                break;
            case 7:
                honk.clip = laugh7;
                break;
            case 8:
                honk.clip = laugh8;
                break;
            case 9:
                honk.clip = laugh9;
                break;
            case 10:
                honk.clip = laugh10;
                break;
            case 11:
                honk.clip = laugh11;
                break;
            case 12:
                honk.clip = laugh12;
                break;
            case 13:
                honk.clip = laugh13;
                break;
            case 14:
                honk.clip = laugh14;
                break;
            case 15:
                honk.clip = laugh15;
                break;
            case 16:
                honk.clip = laugh16;
                break;
        }
        honk.Play();
    }
}
