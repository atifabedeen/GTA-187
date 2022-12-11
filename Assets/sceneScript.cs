using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void goToDubai(){
        SceneManager.LoadScene(1);
    }

    public void goToNoida(){
        SceneManager.LoadScene(2);
    }
}
