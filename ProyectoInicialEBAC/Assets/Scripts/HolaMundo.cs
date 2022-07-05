using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("algo paso");
        Debug.Log("algo paso");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo Salio Muy Mal");
    }
    // Update is called once per frame
    void Update()
    {
        print("algo paso");
        Debug.Log("algo paso");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo Salio Muy Mal");
    }
    void Awake ()
    {
        print("algo paso");
        Debug.Log("algo paso");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo Salio Muy Mal");
    }
    void FixedUpdate()
    {
     
       print("algo paso");
       Debug.Log("algo paso");
       Debug.LogWarning("Algo salio medianamente mal");
       Debug.LogError("Algo Salio Muy Mal");
    }
    void LateUpdate()
    {

     print("algo paso");
     Debug.Log("algo paso");
     Debug.LogWarning("Algo salio medianamente mal");
     Debug.LogError("Algo Salio Muy Mal");
    }
}