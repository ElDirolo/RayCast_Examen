using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private float stringTime;
    public float totalTime;
    public Text text;
    private float minutes;
    private float seconds;
    public bool inicioAtras = false;
    

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }


     
    // Start is called before the first frame update
    private void Start()
    {
        stringTime = totalTime;
        
    }
    private void Update()
    {

        if(inicioAtras == true)
        {
            totalTime -= Time.deltaTime;
            minutes = (int)(totalTime / 60);
            seconds = (int)(totalTime % 60);
            text.text = minutes.ToString() + ":" + seconds.ToString();

        }
        else
        {
            inicioAtras = false;
        }
        if (totalTime < 0)
        {
            text.text = "00";
            Debug.Log("aa");
        }
    }
   

    
}
