using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Raycast : MonoBehaviour
{
    private float stringTime;
    public float totalTime;
    public Text text;
    private float minutes;
    private float seconds;
    public bool inicioAtras = false;
    [SerializeField] GameObject timer; 


     
    private void Start()
    {
        stringTime = totalTime;
        
    }
    void Update()
    {

        if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHit;

            if(Physics.Raycast(ray, out rayHit))
            {
                Debug.Log(rayHit.transform.name);
                
                if(rayHit.transform.name == "Cube")
                {
                    Debug.Log("Level1");
                    timer.SetActive(true);
                    inicioAtras = true;
                    Invoke("LoadLevel1", 5f);
                }

                if(rayHit.transform.name == "Sphere")
                {
                    Debug.Log("Level2");
                    timer.SetActive(true);
                    inicioAtras = true;
                    Invoke("LoadLevel2", 5f);
                }

                if(rayHit.transform.name == "Cube1")
                {
                    Debug.Log("Level3");
                    timer.SetActive(true);
                    inicioAtras = true;
                    Invoke("LoadLevel3", 5f);
                }
            }
        }

        if(inicioAtras == true)
        {
            totalTime -= Time.deltaTime;
            seconds = (int)(totalTime % 60);
            text.text = seconds.ToString() + "";

        }
        else
        {
            inicioAtras = false;
        }
        if (totalTime < 0)
        {
            text.text = "0";
        }



    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Scene1 1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Scene1 2");
    }  

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Scene1 3");
    } 
}    
