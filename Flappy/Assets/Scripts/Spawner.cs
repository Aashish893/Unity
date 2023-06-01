using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public float spawnrate = 1f;

    public float minHeight = -1f;

    public float maxHeigh = 0.15f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn),spawnrate,spawnrate);
    }

    private void onDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
         GameObject pipes = Instantiate(prefab,transform.position, Quaternion.identity);
         pipes.transform.position += Vector3.up * Random.Range(minHeight,maxHeigh);
    }


}
