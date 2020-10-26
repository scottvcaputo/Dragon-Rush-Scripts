using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class WizardSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject trap;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newtrap = Instantiate(trap);
        newtrap.transform.position = transform.position + new Vector3(0, UnityEngine.Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newtrap = Instantiate(trap);
            newtrap.transform.position = transform.position + new Vector3(0, UnityEngine.Random.Range(-height, height), 0);
            Destroy(newtrap, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
