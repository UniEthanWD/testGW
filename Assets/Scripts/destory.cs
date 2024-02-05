using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using Yarn;
using Yarn.Unity;

public class destory : MonoBehaviour
{
    public GameObject[] barrior1;
    public GameObject[] barrior2;
    public GameObject[] barrior3;
    public int life;
    private DialogueRunner runner;
    public float time = 30f;


    // Start is called before the first frame update
    void Start()
    {
        life = 3;

    }

    // Update is called once per frame
    
    void Update()
    {

        time -= Time.deltaTime;
        if (time <= 0f)
        {
            life = life - 1;
            Debug.Log("Time's up!");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            life = life - 1;
            Debug.Log("bad rep" + life);

        }
        if (life == 2)
        {
            barrior1 = GameObject.FindGameObjectsWithTag("firstBarrior");
            for (int i = 0; i < barrior1.Length; i++)
            {

                DestroyObject(barrior1[i]);

            }


        }
        if (life == 1)
        {
            barrior2 = GameObject.FindGameObjectsWithTag("secondBarrior");
            for (int i = 0; i < barrior2.Length; i++)
            {

                DestroyObject(barrior2[i]);
            }
        }
        if (life == 0)
        {
            barrior3 = GameObject.FindGameObjectsWithTag("thirdBarrior");
            for (int i = 0; i < barrior3.Length; i++)
            {

                DestroyObject(barrior3[i]);
            }
        }
    }
    

}
