using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject prefab;

    private bool hasObject;

    private void Update()
    {
        if (!hasObject) {
            StartCoroutine(CreatObject());
        }
    }

    void OnTriggerExit(Collider other)
    {
		hasObject &= !other.CompareTag("Ball");
	}

    private void OnTriggerEnter(Collider other)
    {
        hasObject |= other.CompareTag("Ball");
    }

    IEnumerator CreatObject() {
        hasObject = true;
        yield return new WaitForSeconds(1);
        Instantiate(prefab, transform.position, Quaternion.identity, transform);
    }

}
