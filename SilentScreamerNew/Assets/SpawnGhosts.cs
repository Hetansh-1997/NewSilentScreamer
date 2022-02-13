using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhosts : MonoBehaviour
{
    public GameObject ghost;
    public int xPos, zPos, ghostCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generateGhosts());
    }

    IEnumerator generateGhosts()
    {
        while(ghostCount < 5)
        {
            xPos = Random.Range(453, 464);
            zPos = Random.Range(156, 175);
            Instantiate(ghost, new Vector3(xPos, 27.14f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            ghostCount += 1;
        }
    }
}
