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

    public AudioClip caught1;
    public AudioClip caught2;
    public AudioClip caught3; 
    public AudioClip caught4;
    public AudioClip caught5;
    public AudioClip caught6;
    public AudioClip caught7;
    public AudioClip caught8;
    public AudioClip caught9;
    public AudioClip caught10;
    public AudioClip caught11;


    [SerializeField] GameObject loseScreen;

    int decay =0;

    [SerializeField] float anger = 0;
    [SerializeField] int tooAngery;

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
        //Code for making the meter go down
        if (decay >= decayRate && laughter > 0)
        {
            laughter--;
            decay = 0;
            //Randomize next decay interval
            decayRate = Random.Range(decayRateMin, decayRateMax);
        }
        else
        {
            decay++;
        }
        //If laugher it out of ideal range progress towards losing
        if (laughter > 60)
        {
            anger = anger + (laughter - 50);
        }
        else if (laughter < 40)
        {
            anger = anger + (50 - laughter);
        }
        else
        {
            anger--;
        }
        if (anger >= tooAngery)
        {
            lose();
            anger = -10000000;
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

    public void lose()
    {
        loseScreen.SetActive(true);
        int i = Random.Range(1, 11);
        switch (i)
        {
            case 1:
                honk.clip = caught1;
                break;
            case 2:
                honk.clip = caught2;
                break;
            case 3:
                honk.clip = caught3;
                break;
            case 4:
                honk.clip = caught4;
                break;
            case 5:
                honk.clip = caught5;
                break;
            case 6:
                honk.clip = caught6;
                break;
            case 7:
                honk.clip = caught7;
                break;
            case 8:
                honk.clip = caught8;
                break;
            case 9:
                honk.clip = caught9;
                break;
            case 10:
                honk.clip = caught10;
                break;
            case 11:
                honk.clip = caught11;
                break;
        }
        honk.Play();
    }
}
