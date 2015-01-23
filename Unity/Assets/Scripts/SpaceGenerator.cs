using UnityEngine;

public class SpaceGenerator : MonoBehaviour
{
    public GameObject planet;
    public GameObject star;
    private float maxDistance = 100000;

    void Awake ()
    {
        CreatePlanets();
        CreateStars();
    }

    private void CreateStars()
    {
        for (int i = 0; i < 30; i++)
        {
            var position = new Vector3(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance),
                Random.Range(-maxDistance, maxDistance));

            var o = Instantiate(star, position, Quaternion.identity) as GameObject;
            
            o.light.intensity = Random.Range(0.1f, 3f);
            o.light.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        }
    }

    private void CreatePlanets()
    {
        for (int i = 0; i < 1000; i++)
        {
            var position = new Vector3(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance),
                Random.Range(-maxDistance, maxDistance));

            var o = Instantiate(planet, position, Quaternion.identity) as GameObject;
            var size = Random.Range(10, 10000f);
            o.transform.localScale = new Vector3(size, size, size);
        }
    }
}
