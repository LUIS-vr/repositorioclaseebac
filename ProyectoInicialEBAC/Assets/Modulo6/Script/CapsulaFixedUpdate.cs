using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulaFixedUpdate : MonoBehaviour
{
    public GameObject PrefabCapsula;
    public int numColor = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        numColor++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCapsula);
        tempGameObject.name = "CuboEsferas" + numColor;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
