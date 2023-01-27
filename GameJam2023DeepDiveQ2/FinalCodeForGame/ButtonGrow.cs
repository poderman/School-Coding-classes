using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonGrow : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public RectTransform Button;

    // Start is called before the first frame update
    void Start()
    {
        Button.GetComponent<Animator>().Play("Button Shrink");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("Button Grow");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("Button Shrink");
    }
}
