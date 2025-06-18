using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    private Vector2 target;
    private Vector2 pos;
    [SerializeField] private GameObject Player;
    public Transform other;

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector2();
        pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector2.Distance(other.position, transform.position);
        if (dist < 4.45)
        {
            float step = 10f * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, step);
        }

    }

}
