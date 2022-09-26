using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public int speed;
    public GameObject bomb;
    private bool _bombReady;
    private float _countDown;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _bombReady = true;
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_bombReady)
            {
                _countDown = Time.time;
                bomb.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y ,gameObject.transform.position.z );
                Instantiate(bomb);
                _bombReady = false;
                
            }
           
        }
        // Compte à rebours
        if (Time.time - _countDown >= 5)
        {
            Destroy(bomb);
            _bombReady = true;
            
        }
        
    }
}
