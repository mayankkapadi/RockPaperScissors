using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 ogscale;

    // Start is called before the first frame update
    void Start()
    {
        ogscale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        transform.localScale = ogscale * 1.2f;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        transform.localScale = ogscale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
