using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animateGif : MonoBehaviour
{
    public Sprite[] animatedImages;
    public Image animatedImageObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
            animatedImageObj.sprite = animatedImages[(int)(Time.time * 3) % animatedImages.Length];
    }
}
