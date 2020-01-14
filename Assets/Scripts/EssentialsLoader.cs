using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{
    
    public GameObject UIScreen;
    public GameObject player;
    public GameObject gameMan;
    void Start()
    {
        if (IUFade.instance == null)
        {
            IUFade.instance = Instantiate(UIScreen).GetComponent<IUFade>();
        }

        if (PlayerContoller.instance == null)
        {
            PlayerContoller clone = Instantiate(player).GetComponent<PlayerContoller>();
            PlayerContoller.instance = clone;
        }

        if(GameManager.instance==null)
        {
            Instantiate(gameMan);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

