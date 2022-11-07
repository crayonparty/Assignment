using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    int[] Correct = { 0, 0, 0, 0 };
    public GameObject ErrorPanel;
    public GameObject GloveWorn;
    int i = 0;
    bool hasJoint;

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name == "GloveBox")
        {
            Instantiate(GloveWorn, GloveWorn.transform.position, Quaternion.identity);
            if (collider.gameObject.GetComponent<Rigidbody>() != null && !hasJoint)
            {
                gameObject.AddComponent<FixedJoint>();
                gameObject.GetComponent<FixedJoint>().connectedBody = collider.gameObject.GetComponent<Rigidbody>();
                hasJoint = true;
            }
            print("Glove is worn");

        }
    }
    public int check()
    {
        if (hasJoint == true)
        {
            Correct[i] = 1;
            return Correct[i];
        }
        return 0;
    }
    void Start()
    {

    }
}
    //bool hasJoint;
    // public Controller controller;

    // Interactable interactable;
    /*public bool isGrabbed = false;
    private XRDirectInteractor interactor = null;
    public bool IsGrabbing;

    private void Awake()
    {

        interactor = GetComponent<XRDirectInteractor>();
        IsGrabbing = false;

    }

    private void OnEnable()
    {

        interactor.onSelectEntered.AddListener(TakeInput);
        interactor.onSelectExited.AddListener(StopInput);

    }

    private void OnDisable()
    {

        interactor.onSelectEntered.RemoveListener(TakeInput);
        interactor.onSelectExited.RemoveListener(StopInput);

    }

    private void TakeInput(XRBaseInteractable interactable)
    {

        IsGrabbing = true;
        Debug.Log("is grabbing");

    }

    private void StopInput(XRBaseInteractable interactable)
    {

        IsGrabbing = false;
        Debug.Log("is releasing");

    }
    // Update is called once per frame
    void Update()
    {
        Gloves();
        if (interactable != null)
        {
            isGrabbed = true;
        }
    }

    void Gloves()
    {
        OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller);
        OVRInput.Get(OVRInput.Button.One, controller);

        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
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

    /*  void OnCollisionEnter(Collision collision)
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
    }*/
    /* void OnCollisionEnter(Collision collision)
     {
         Vial.transform.parent = Injection.transform;
     }*/



    // Start is called before the first frame update