using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_changer : MonoBehaviour
{   
    public void Change(int number_scene)
    {
        SceneManager.LoadScene(number_scene);
    }
}