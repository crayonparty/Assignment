using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Process : MonoBehaviour
{

    public GameObject GloveBox;
    public GameObject Vial;
    public GameObject Injection;
    //  public GameObject Glove;
    // public Transform GloveBoxPosition;
    // public Transform InjectionPosition;
    //  public Transform VialPosition;
    //  public Transform GlovePosition;

    private int counter = 0;
    void Start()
    {
        GameObject C = Instantiate(GloveBox, GloveBox.transform.position, Quaternion.identity);
        GameObject E = Instantiate(Vial, Vial.transform.position, Quaternion.identity);
        GameObject K = Instantiate(Injection, Injection.transform.position, Quaternion.identity);
    }
    /*void OnTriggerEnter(Collider other)
    {
        GameObject C = Instantiate(GloveBox, transform.position, Quaternion.identity);
        GameObject E = Instantiate(Vial, transform.position, Quaternion.identity);
        GameObject K = Instantiate(Injection, transform.position, Quaternion.identity);
        //  InvokeRepeating("Instantiate", 1.0f, 1.0f);
        // other.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        // Load();

    }
}
    private void Instantiate()
    {
        GameObject C = Instantiate(GloveBox, GloveBox.transform.position, Quaternion.identity);
        GameObject E = Instantiate(Vial, Vial.transform.position, Quaternion.identity);
        GameObject K = Instantiate(Injection, Injection.transform.position, Quaternion.identity);
        //GameObject G = Instantiate(Glove, Glove.transform.position, Quaternion.identity);

        if (counter < 6)
               {
                   //C.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
                  // counter++;
               }
               else
               {
                   CancelInvoke();
                   counter = 0;
               }*/
    //}
    /* public void Load()
     {
         if (counter == 6)
         {
             SceneManager.LoadScene(1);
         }
     }*/
    // Start is called before the first frame update

}    // Update is called once per frame
   /*void Update()
    {
        
    }*/