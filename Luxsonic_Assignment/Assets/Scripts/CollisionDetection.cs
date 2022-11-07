using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    int[] Correct = { 0, 0, 0, 0 };
    int success = 0;
    int wrong = 0;
    public GameObject ErrorPanel;
    public GameObject GloveWorn;
    int i = 1;
    bool hasJoint;

    public GameObject Vial;
    // Start is called before the first frame update

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Vial")
        {
            Debug.Log("Collision Detected");
            if (col.gameObject.GetComponent<Rigidbody>() != null && !hasJoint)
            {
                gameObject.AddComponent<FixedJoint>();
                gameObject.GetComponent<FixedJoint>().connectedBody = col.gameObject.GetComponent<Rigidbody>();
                hasJoint = true;
            }
            print("Vial and injection are in contact");
            Correct[i] = 2;
            i++;
        }

        void OnCollisionExit(Collision other)
        {
            Debug.Log("Collision Broken");
            var Container = gameObject.GetComponent<FixedJoint>();
            if (other.gameObject.GetComponent<Rigidbody>() != null && hasJoint == true)
            {
                Destroy(Container);
                hasJoint = false;
            }
            print("No longer in contact with + other.transform.name");

            if (hasJoint == false)
            {
                Destroy(Vial);
                Correct[i] = 3;
                i++;
            }
        }
        int Inject()
        {
            if (col.gameObject.name == "Arm")
            {
                Debug.Log("Collision Detected");
                if (col.gameObject.GetComponent<Rigidbody>() != null && !hasJoint)
                {
                    Correct[i] = 4;
                    i++;
                }
                return Correct[i];
            }
            return 0;

        }
        void Start()
        {
            Controller A = new Controller();
            int a = A.check();
            int b = Inject();
        }

        // Update is called once per frame
        void Update()
        {
            for (int i = 0; i < 4; i++)
            {
                int[] array = new int[] { 1, 2, 3, 4 };
                if (!(Correct[i] == array[4]))
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
            int attempts = wrong + success;
        }

    }
}