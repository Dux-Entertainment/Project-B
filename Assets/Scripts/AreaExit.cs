using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;
public class AreaExit : MonoBehaviour
{
    public string areaToLoad;

    public string areaTransitionName;

    public AreaEntrance ThEntrance;

    public float waitToLoad = 1f;
    private bool shouldLoadAfterFade;
    void Start()
    {
        ThEntrance.transitionName = areaTransitionName;
    }

    // Update is called once per frame
    void Update()
    {
        if(shouldLoadAfterFade)
        {
            waitToLoad -= Time.deltaTime;
            if(waitToLoad<=0)
            {
                shouldLoadAfterFade = false;
                SceneManager.LoadScene(areaToLoad);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //SceneManager.LoadScene(areaToLoad);
            shouldLoadAfterFade = true;
            GameManager.instance.fadingBetweenAreas = true;
            IUFade.instance.FadeToBlack();

            PlayerContoller.instance.areaTransitionName = areaTransitionName;
        }
    }
}
