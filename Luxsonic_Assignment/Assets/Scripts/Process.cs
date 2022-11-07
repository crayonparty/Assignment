using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Process : MonoBehaviour
{

    private float timer = 1;
  
    public GameObject[] functions; 
    public GameObject Glove;
   
    int randomInt;
    int i = 0;

    void Start()
    {
        StartCoroutine(testEnumerator(timer));
    }

    private IEnumerator testEnumerator(float delay)
    {
        List<int> randomList = new List<int>();
        while (i<3)
        {
            int NewNumber()
            {
                do
                {
                    System.Random a = new System.Random();
                    randomInt = a.Next(0, 3);

                } while (randomList.Contains(randomInt));

                randomList.Add(randomInt);
                return randomInt;
            }

                int RN = NewNumber();

            Instantiate(functions[RN], functions[RN].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(delay);
          i++;
       }
    }

    void Update()
    {
     
    }
}