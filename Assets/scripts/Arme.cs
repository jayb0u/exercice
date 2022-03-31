using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arme : MonoBehaviour
{
    public Text chargeur;
    int ammo = 8;
    bool reloading = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chargeur.text = ammo + "/8";

        //reload
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (ammo != 8 && !reloading)
            {
                StartCoroutine(reload());
            }
            
        }

        //tir
        if (Input.GetButtonDown("Fire1"))
        {
            if (ammo > 0 && !reloading)
            {
                ammo -= 1;
            }

            else if (ammo == 0)
            {
                StartCoroutine(reload());
            }
            
        }

        //bombe
        if (Input.GetButtonDown("Fire2"))
        {

        }

        IEnumerator reload()
        {
            reloading = true;

            yield return new WaitForSeconds(3f);

            //Je ne suis plus occupé
            reloading = false;
            ammo = 8;
        }
    }
}
