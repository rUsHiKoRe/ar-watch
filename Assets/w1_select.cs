using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class w1_select : MonoBehaviour
{
    public GameObject Watchmodel1;
    public GameObject Watchmodel2;
    public GameObject Watchmodel3;

    public GameObject W1window;
    public GameObject W2window;
    public GameObject W3window;

     Animation w1windowani;
     Animation w2windowani;
     Animation w3windowani;
    // Start is called before the first frame update
    void Start()
    {
        w1windowani = W1window.GetComponent<Animation>(); 
        w2windowani = W2window.GetComponent<Animation>();
        w3windowani = W3window.GetComponent<Animation>();
    }
    public void w1onclicked()
    {
        //show w1 model on wrist
        Watchmodel1.SetActive(true);
        Watchmodel2.SetActive(false);
        Watchmodel3.SetActive(false);

        //make animation 
        w1windowani["w1Animation"].speed = 1;
        w1windowani.Play();

    }
    public void w2onclicked()
    {
        //show w2 model on wrist
        Watchmodel1.SetActive(false);
        Watchmodel2.SetActive(true);
        Watchmodel3.SetActive(false);

        //make animation 
        w2windowani["w2Animation"].speed = 1;
        w2windowani.Play();



    }
    public void w3onclicked()
    {
        //show w3 model on wrist
        Watchmodel1.SetActive(false);
        Watchmodel2.SetActive(false);
        Watchmodel3.SetActive(true);

        //make animation 
        w3windowani["w3Animation"].speed = 1;
        w3windowani.Play();


    }

    public void w1buttonclosed()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "w1close")
        {
            w1windowani["w1Animation"].speed = -1;
            w1windowani["w1Animation"].time = w1windowani["w1Animation"].length;
            w1windowani.Play();

        }
    }
        public void w2buttonclosed()
        {
            string buttonName = EventSystem.current.currentSelectedGameObject.name;

            if (buttonName == "w2close")
        {
            w2windowani["w2Animation"].speed = -1;
            w2windowani["w2Animation"].time = w2windowani["w2Animation"].length;
            w2windowani.Play();
         }
        }
        public void w3buttonclosed()
        {
            string buttonName = EventSystem.current.currentSelectedGameObject.name;

            if (buttonName == "w3close")
        {
            w3windowani["w3Animation"].speed = -1;
            w3windowani["w3Animation"].time = w3windowani["w3Animation"].length;
            w3windowani.Play();
        }
        }
    }

