using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioKeyInputs : MonoBehaviour
{

    public AudioSource Dio;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Dio.Play();
        }
    }
}
