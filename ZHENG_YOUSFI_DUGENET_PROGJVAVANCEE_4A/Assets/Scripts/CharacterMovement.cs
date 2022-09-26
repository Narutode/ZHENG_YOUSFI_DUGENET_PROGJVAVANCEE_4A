using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            gameObject.transform.Translate(new Vector3(-speed,0,0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(new Vector3(speed,0,0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Translate(new Vector3(0,0,-speed) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(new Vector3(-0,0,speed) * Time.deltaTime);
        }
        
    }
}
