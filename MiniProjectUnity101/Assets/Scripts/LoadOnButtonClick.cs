using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnButtonClick : MonoBehaviour
{
    public int index;

    public void LoadSceneOnClickWithIndex()
    {
        SceneManager.LoadScene(index);
    }
}
