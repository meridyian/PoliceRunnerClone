using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    [SerializeField] private FieldOfView fieldofview;
    
    void Start()
    {
        StartCoroutine(Spawn());
    }



    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            SpawnBullet();
        }
        
    }

    public void SpawnBullet()
    {
        if (fieldofview.isPlayer == true)
            Instantiate(bulletPrefab, transform.position, transform.rotation);
    }


}
