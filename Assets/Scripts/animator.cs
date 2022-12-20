using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class animator : MonoBehaviour
{

    private string[] names = { "idle", "applause", "applause2", "celebration", "celebration2", "celebration3" };

    // Use this for initialization
    void Start()
    {
        Animation[] audience = gameObject.GetComponentsInChildren<Animation>();
        foreach (Animation a in audience)
        {
            string anim = names[Random.Range(0, 5)];

            a.wrapMode = WrapMode.Loop;
            a.GetComponent<Animation>().CrossFade(anim);
            a[anim].time = Random.Range(0f, 3f);
        }
    }
}