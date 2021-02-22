using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    [SerializeField] Text hello;
    [SerializeField] Button donateBtn;
    [SerializeField] Text donateTxt;
    float time = 0f;
    Color zm, bzm;
    
    // Start is called before the first frame update
    void Start()
    {
        zm = hello.color;
        bzm = donateTxt.color;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //1st text
        if (time < 3f)
            zm.a += Time.deltaTime * 0.5f;
        else if (time < 6.5f)
            zm.a -= Time.deltaTime * 0.5f;
        //2nd text
        else if (time < 10f) { 
            hello.text = "Welcome to TheNoGame.";
            zm.a += Time.deltaTime * 0.5f; 
        }
        else if (time < 13f)
            zm.a -= Time.deltaTime * 0.5f;
        //3rd text
        else if (time < 16f){
            hello.text = "Just use your imagination and play.";
            zm.a += Time.deltaTime * 0.5f;
        }
        else if (time < 19f)
            zm.a -= Time.deltaTime * 0.5f;
        //4th text
        else if (time < 21f)
        {
            hello.text = "If you like it, dont forget to support us.";
            zm.a += Time.deltaTime * 0.5f;
            bzm.a = zm.a;
        }
        else if (time < 24f)
            zm.a -= Time.deltaTime * 0.5f;



        hello.color = zm;
        donateTxt.color = bzm;
    }

    public void DonateBtn() {
        if (time > 19f)
            Application.OpenURL("https://www.donationalerts.com/r/bag911");
    }
}
