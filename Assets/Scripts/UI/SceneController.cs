using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public int nowScene=1;
    public bool Clickable;
    void Start()
    {
        if(nowScene==1)
        DontDestroyOnLoad(this.gameObject);
    }
    public void ChangeScene()
    {
        if(nowScene==5)
        {
            nowScene=1;
            SceneManager.LoadScene(0);
            return;
        }
        else
        {
            nowScene+=1;
            Clickable = false;
            SceneManager.LoadScene(nowScene);

        }
        Debug.Log("Change scene");
       
        
 
    }
    void Update()
    {
        if(Clickable)
        if(Input.GetMouseButtonDown(0))
        {
            ChangeScene();
            
        }
    }
}
