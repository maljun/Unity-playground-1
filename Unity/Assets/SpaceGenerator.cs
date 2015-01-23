using UnityEngine;

public class SpaceGenerator : MonoBehaviour
{
    public GameObject planet;
    void Awake () {
        
        for (int i = 0; i < 1000; i++)
        {
            var position = new Vector3(Random.Range(-1000000, 1000000), Random.Range(-1000000, 1000000), Random.Range(-1000000, 1000000));

            var o = Instantiate(planet, position, Quaternion.identity) as GameObject;
            var size = Random.Range(10, 10000f);
            o.transform.localScale = new Vector3(size, size, size);

        }
	}
}
