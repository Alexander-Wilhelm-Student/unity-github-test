using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    if(Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("j key was pressed");
        }

    
    }


}
