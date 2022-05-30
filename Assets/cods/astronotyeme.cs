using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class astronotyeme : MonoBehaviour
{

    public Text astrotext;
    int atropuan = 0;
    public Text oretext;
    int orepoint = 0;
    public ProgressBar Pb;
    public GameObject AtomRocket;
    public GameObject astroid1;
    int counter = 200;
    void Start()
    {
        Pb.BarValue = 100;
        InvokeRepeating("sayac", 1, 1);
        
    }
    public void Update()
    {
        if (Pb.BarValue == 0)
        {
            AtomRocket.SetActive(false);
            Invoke("bekle", 1);
           
            
        }

    }
    public void bekle()
    {
        SceneManager.LoadScene(2);
    }



    public void sayac()
    {
        Pb.BarValue--;
    }

    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "astro")
        {
            Destroy(collision.gameObject);
            atropuan++;
            astrotext.text = "Astronaut : " + atropuan;
        }
        if (collision.gameObject.tag == "Asteroid")
        {
            Destroy(collision.gameObject);
            Pb.barValue -= 25;
        }
        if (collision.gameObject.tag == "ore")
        {
            Destroy(collision.gameObject);
            orepoint++;
            oretext.text = "Materials : " + orepoint;
        }
        if (collision.gameObject.tag == "cell")
        {
            Destroy(collision.gameObject);
            counter += 50;
            Pb.barValue = 100;
        }
        if (collision.gameObject.tag == "blackhole")
        {
            Pb.barValue = 0;
           
            
            
            
        }
        if (collision.gameObject.tag == "alien")
        {
            Destroy(collision.gameObject);
            Pb.barValue -= 50;
        }
    }
}