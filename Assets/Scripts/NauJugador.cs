using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauJugador : MonoBehaviour
{
    private float _vel;

    private Vector2 minPantalla, maxPantalla;

    // Start is called before the first frame update
    void Start()
    {
        _vel = 8;

        minPantalla = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        maxPantalla = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        float midaMeitatImatgeX = GetComponent<SpriteRenderer>().sprite.bounds.size.x * transform.localScale.x  / 2;
        float midaMeitatImatgeY = GetComponent<SpriteRenderer>().bounds.size.y /2;


        // minPantalla.x = minPantalla.x + 0.75f;
        // minPantalla.x += 0.75f; // Es sinonim a la linia de dalt.
        minPantalla.x  += midaMeitatImatgeX;
        maxPantalla.x  -= midaMeitatImatgeX;
        minPantalla.y += midaMeitatImatgeY; 
        maxPantalla.y -= midaMeitatImatgeY;
        
    }

    // Update is called once per frame
    void Update()
    {
        float direccioIndicadaX = Input.GetAxisRaw("Horizontal");
        float direccioIndicadaY = Input.GetAxisRaw("Vertical");
        //Debug.Log("X:" + direccioIndicadaX + "-Y:"+ direccioIndicadaY);

        Vector2 direccioIndicada = new Vector2(direccioIndicadaX,direccioIndicadaY).normalized;

        Vector2 novaPos = transform.position;
        novaPos = novaPos + direccioIndicada * _vel * Time.deltaTime;

        novaPos.x = Mathf.Clamp(novaPos.x,minPantalla.x,maxPantalla.x);
        novaPos.y = Mathf.Clamp(novaPos.y, minPantalla.y, maxPantalla.y);

        transform.position = novaPos;
        
    }
}
