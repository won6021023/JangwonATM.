using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GoMainSn() 
    {
        SceneManager.LoadScene(0);
    }

    public void GoDepoistSn()
    {
        SceneManager.LoadScene(1);
    }

    public void GoWithdrawSn()
    {
        SceneManager.LoadScene(2);
    }
}
