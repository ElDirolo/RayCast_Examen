using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Raycast : MonoBehaviour
{


 [SerializeField] GameObject timer;   

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
                    GameManager.Instance.inicioAtras = true;
                    Invoke("LoadLevel1", 5f);
                }

                if(rayHit.transform.name == "Sphere")
                {
                    Debug.Log("Level2");
                    timer.SetActive(true);
                    GameManager.Instance.inicioAtras = true;
                    Invoke("LoadLevel2", 5f);
                }

                if(rayHit.transform.name == "Cube1")
                {
                    Debug.Log("Level3");
                    timer.SetActive(true);
                    GameManager.Instance.inicioAtras = true;
                    Invoke("LoadLevel3", 5f);
                }
            }
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
