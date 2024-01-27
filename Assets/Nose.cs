using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nose : MonoBehaviour 
{
    // Start is called before the first frame update
    public int laughter = 0;

    public Text debugText;

    public Button buttonOne;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        debugText.text = laughter.ToString();
        //if (buttonOne.click == true)
        {
            laughter++;
        }
    }
}
