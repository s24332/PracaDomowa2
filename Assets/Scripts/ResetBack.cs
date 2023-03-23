using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetBack : MonoBehaviour
{
    public void ResetTheGame ()
    {
        SceneManager.LoadScene("SampleScene");
        print("The button is working.");
    }   
}
