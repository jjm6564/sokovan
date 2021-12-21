using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( 60*Time.deltaTime, 60*Time.deltaTime , 60*Time.deltaTime);
        //deltatime -> 화면이 한번 깜빡이는 시간 == 프레임의 시간 (60프레임이면 1/60)
        //200프레임이면 1/200
    }
}
