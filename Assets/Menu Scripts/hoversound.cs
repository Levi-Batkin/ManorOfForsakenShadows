using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class hoversound: MonoBehaviour, IPointerEnterHandler, IPointerDownHandler
{
    // Start is called before the first frame update
    private AudioSource ui;
    public AudioClip hover;
    public AudioClip select;
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        ui = GetComponent<AudioSource>();
        ui.PlayOneShot(hover);
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        ui = GetComponent<AudioSource>();
        ui.PlayOneShot(select);
    }
    void Update()
    {
        ui = GetComponent<AudioSource>();
        if(Input.GetKeyDown(KeyCode.S)) {
            ui.PlayOneShot(hover);
        }
        if(Input.GetKeyDown(KeyCode.W)) {
            ui.PlayOneShot(hover);
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            ui.PlayOneShot(select);
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            ui.PlayOneShot(select);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            ui.PlayOneShot(hover);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            ui.PlayOneShot(hover);
        }
    }
}
