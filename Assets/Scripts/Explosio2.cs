using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Invoke("DestrueixExplosio",1f);


    }

    private void DestrueixExplosio()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
