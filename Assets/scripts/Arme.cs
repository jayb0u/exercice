using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Arme : MonoBehaviour
{
    public Text chargeur;
    int ammo = 8;
    bool reloading = false;
    public AudioManager SoundManager;
    public GameObject bomb;
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
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
                SoundManager.FaireFeu(false);
                
            }

            else if (ammo <= 0)
            {
                SoundManager.FaireFeu(true);
                StartCoroutine(reload());
            }
            
        }

        //bombe
        if (Input.GetButtonDown("Fire2"))
        {

            Instantiate(bomb, transform.position + transform.forward, Quaternion.identity);
        }

        IEnumerator reload()
        {
            reloading = true;

            yield return new WaitForSeconds(3f);

            //fini de recharger
            reloading = false;
            ammo = 8;
        }
    }
}
