using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    public void Load()

    {
        //Debug.Log("asdas");

        SceneManager.LoadScene(name);
    }

    
}
