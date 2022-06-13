using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    [SerializeField] SpriteRenderer PressureP;
    public Sprite off;
    public Sprite on;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        PressureP.sprite = off;
        door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        PressureP.sprite = off;
        door.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       PressureP.sprite = on;
        door.SetActive(false);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        PressureP.sprite = off;
        door.SetActive(true);
    }
}
