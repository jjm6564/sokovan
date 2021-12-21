using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Itembox[] itemboxes; 
    public GameObject WinUI;
    // Start is called before the first frame update
    public bool isGameOver;
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)){
            //SceneManager.LoadScene("main");
            SceneManager.LoadScene(0); //게임 빌드의 순서
        }

        if(isGameOver == true){
            return;
        }
        int count = 0;
        for(int i = 0; i<3;i++){
           if(itemboxes[i].isOverraped==true){
            count ++;
            }
        }
        if(count>=3){
            isGameOver =true;
            WinUI.SetActive(true);
        }
    }
}
