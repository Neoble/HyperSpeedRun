using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuLevelScript : MonoBehaviour {

public void PlayClick()
    {
        SceneManager.LoadScene("Play");
    }
public void ExitClick()
    {
        SceneManager.LoadScene("Exit");
    }
    public void ShopClick()
    {
        SceneManager.LoadScene("Shop");
    }

}
