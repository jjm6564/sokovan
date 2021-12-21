using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itembox : MonoBehaviour
{

    public bool isOverraped = false;
    private Renderer myRenderer;

    public Color touchColor;
    private Color originalColor;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //트리거인 콜라이더와 충돌할 때 자동 실행
    //Enter 충돌을 한 순간
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="EndPoint"){
            myRenderer.material.color = touchColor;
            isOverraped = true;
        }
    }
    // Exit은 떨어지는 순간
    void OnTriggerExit(Collider other)
    {
        if(other.tag=="EndPoint"){
            myRenderer.material.color = originalColor;
            isOverraped = false;
        }
    }
    //충동하고 있는, 붙어있는 동안.
    void OnTriggerStay(Collider other)
    {
         if(other.tag=="EndPoint"){
            myRenderer.material.color = touchColor;
            isOverraped = true;
        }
    }
    
}
