using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collectibles : MonoBehaviour
{
    public Text collect;
    private int collectNum;
    GameObject mainplayer;

    // Start is called before the first frame update
    void Start()
    {
        collectNum = 0;
        collect.text = "Pages " + collectNum;
    }

    private void OnTriggerEnter2D(Collider2D pages)
    {
        if (pages.CompareTag("Objective"))
        {
            SoundManagerScript.PlaySound("paper");
            collectNum++;
            Destroy(pages.gameObject);
            collect.text = "Pages " + collectNum;
        }
        if (collectNum == 8)
        {
            SceneManager.LoadScene("VictoryScreen"); //loads on Victory menu
        }
    }

}
