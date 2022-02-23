using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public void btnStartClick()
    {
        SceneManager.LoadScene(1);
    }
}
