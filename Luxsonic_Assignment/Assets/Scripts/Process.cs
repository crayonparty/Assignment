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
/*while (currentIndex < functions.Length)
{
    int randomIndex = Random.Range(currentIndex, functions.Length);

    string current = functions[currentIndex];
    string random = functions[randomIndex];

    functions[currentIndex] = random;
    functions[randomIndex] = current;

    if (currentIndex != 0)
    {
        if (functions[currentIndex] != functions[currentIndex - 1])
            currentIndex += 1;
    }
    else
    {
        currentIndex += 1;
    }
}

for (int i = 0; i < functions.Length; ++i)
    Invoke(functions[i], 2.0f * (i + 1));*/

/*  public float SpawnTime = 0.0f;

  void Start()
  {
    float x = Random.Range(1.0f, 3.0f);
    if (SpawnTime < 3.0f)
      {
          if (x == 1.0f)
          {
              InvokeRepeating("SpawnGloveBox", SpawnTime, SpawnTime);
          }
          if (x == 2.0f)
          {
              InvokeRepeating("SpawnVial", SpawnTime, SpawnTime);
          }
          if (x == 3.0f)
          {
              InvokeRepeating("SpawnInjection", SpawnTime, SpawnTime);
          }
      }
  }
  void SpawnGloveBox()
  {
      Instantiate(GloveBox, GloveBox.transform.position, Quaternion.identity);
      SpawnTime += 1;
  }
  void SpawnVial()
  {
      Instantiate(Vial, Vial.transform.position, Quaternion.identity);
      SpawnTime += 1;
  }
  void SpawnInjection()
  {
      Instantiate(Injection, Injection.transform.position, Quaternion.identity);
      SpawnTime += 1;
  }
}
*/






/*
    public Transform[] SpawnPoints;
    public Transform[] EffectPoints;


    public float spawnTime = 1.5f;
    public float effectSpawnTime = 1f;

    public GameObject Coins;
    public GameObject Effect;

    int spawnIndex = 0;
    int maximumRandomRange = 0;
    // Use this for initialization
    void Start()
    {
        //Initialize the variable
        spawnIndex = Random.Range(0, maximumRandomRange);
        maximumRandomRange = SpawnPoints.Length; //or EffectPoints.Length, as they got the same

        InvokeRepeating("SpawnParticle", effectSpawnTime, effectSpawnTime);
        InvokeRepeating("SpawnCoins", spawnTime, spawnTime);
    }

    void SpawnCoins()
    {
        Instantiate(Coins, SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
    }
    void SpawnParticle()
    {
        spawnIndex = Random.Range(0, maximumRandomRange); //You only need to call it here again, as it is the function which is called faster
        Instantiate(Effect, EffectPoints[spawnIndex].position, EffectPoints[spawnIndex].rotation);
    }

}
void OnTriggerEnter(Collider other)
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

//}    // Update is called once per frame
