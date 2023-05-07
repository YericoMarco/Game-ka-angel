using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothness;
    
    private void Update()
    {
        if(Player !=null)
        {
        transform.position = Vector3.Lerp(transform.position, Player.transform.position + offset, smoothness);
        }
    }
}
