using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour  //, Interactible
{
   /* int[] Correct = {0,0,0,0};
    int success = 0;
    int wrong = 0;
    public GameObject ErrorPanel;
    public GameObject GloveWorn;
    public GameObject Glove;
    int i = 4;
    bool hasJoint;
    public Controller controller;

    private Interactable interactable;
    public bool isGrabbed = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() != null && !hasJoint)
        {
            gameObject.AddComponent<FixedJoint>();
            gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
            hasJoint = true;
        }
        print("Vial and injection are in contact");
        Correct[i] = 2;
        i++;
    }
    void OnCollisionExit(Collision other)
    {
        //Destroy(GetComponent (FixedJoint));
          
            var Container = gameObject.GetComponent<FixedJoint>();
            if (other.gameObject.GetComponent<Rigidbody>() != null && hasJoint == true)
            {
                Destroy(Container);
                hasJoint = false;
        }
        print("No longer in contact with + other.transform.name");
        Correct[i] = 3;
        i++;
    }
    /* void OnCollisionEnter(Collision collision)
     {
         Vial.transform.parent = Injection.transform;
     }*/



    // Start is called before the first frame update
   /* void Start()
    {
        interactable = this.GetComponent<Interactable>();

        for (int i = 0; i < 4; i++)
        {
            if (!(Correct[i] == { 1, 2, 3, 4 })
            {
                ErrorPanel.SetActive(true);
                wrong++;
            }
            else
            {
                success++;
                SceneManager.LoadScene(0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    Gloves();
        if (interactable != null)
        {
            isGrabbed = true;
        }
    }*/

  /*  void Gloves()
    {

    OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller);
    OVRInput.Get(OVRInput.Button.One, controller);

    if (OVRInput.GetDown(OVRInput.RawButton.Y))
         {
             Instantiate(Glove, Glove.transform.position, Quaternion.identity);
             Debug.Log("A button pressed");
         }
         else (OVRInput.Get(OVRInput.Button.Up))
         {
             Debug.Log("A button is not pressed");
             Instantiate(GloveWorn, GloveWorn.transform.position, Quaternion.identity);
         }
         Correct[i] = 1;
         i++;
}
}*/
    }