using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingLocation : MonoBehaviour
{
    [SerializeField] GameObject theX;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Vector3 mousePos = Input.mousePosition;
            Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0f;
            Instantiate(theX, objectPos, Quaternion.identity);
        }
    }
}
