using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text temps;
    public GameObject zombieprefab;
    public Transform spawnzombie;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate<>
    }

    // Update is called once per frame
    void Update()
    {
        temps.text = Time.time.ToString();
    }
}
