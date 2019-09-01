using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpaw : MonoBehaviour
{
    GameObject parent;
    public GameObject prefab;
    public GameObject spawnPoint;
    public float waitTime = 3f;
    public float projectileSpeed = 3f;
    
    public Vector3[] directions;

    void Start()
    {
        parent = GameObject.Find("Tape");
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn() {
        while (true) {
            yield return new WaitForSeconds(waitTime);
            for (int i=0; i<directions.Length; i++) {
                GameObject projectile = Instantiate(prefab, spawnPoint.transform.position, Quaternion.identity);
                projectile.transform.SetParent(parent.transform);
                projectile.GetComponent<Rigidbody2D>().velocity = projectileSpeed * directions[i];
            }
        }
    }
<<<<<<< HEAD
}
=======
<<<<<<< HEAD
}
=======
}
  
>>>>>>> 4c0c45b1464b83e09a9760d1c55e5e71164107a8
>>>>>>> 4de1668c5a8c4a7ff3b1cb04cd26a6da48054362
