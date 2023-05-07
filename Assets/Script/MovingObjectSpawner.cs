using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectSpawner : MonoBehaviour
{
   [SerializeField] private GameObject spawnObject;
   [SerializeField] private Transform SpawnPos;
   [SerializeField] private float minSeparationTime;
   [SerializeField] private float maxSeparationTime;
   [SerializeField] private bool isRightSide;

   private void Start()
   {
        StartCoroutine(SpawnVehicle());
   }

   private IEnumerator SpawnVehicle()
   {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minSeparationTime, maxSeparationTime));
            GameObject newVehicle = Instantiate(spawnObject, SpawnPos.position, Quaternion.identity);
            if (!isRightSide)
            {
               newVehicle.transform.Rotate(new Vector3(0, 180, 0));
            }
        }
   }
}
