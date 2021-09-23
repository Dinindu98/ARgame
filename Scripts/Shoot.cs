using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject arCamera;
    MenuManager endMenu;

    // Start is called before the first frame update
    private void Start()
    {
        endMenu = gameObject.GetComponent<MenuManager>();
    }
    public void shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(arCamera.transform.position,arCamera.transform.forward, out hit))
        {
            if(hit.transform.name== "Cola Can")
            {
                Destroy(hit.transform.gameObject);
              
                endMenu.gameend();
            }
        }
    }
}
