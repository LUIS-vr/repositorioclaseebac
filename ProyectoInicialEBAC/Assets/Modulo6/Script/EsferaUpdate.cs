using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaUpdate : MonoBehaviour
{
    public GameObject PrefabEsfera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabEsfera);
        Color c = new Color(Random.value, Random.value,Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
