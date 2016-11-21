using UnityEngine;
using System.Collections;

public class PathSpawnColliderScript : MonoBehaviour
{

    public float positionY = 0.81f;
    public Transform[] PathSpawnPoints;
    public GameObject Path;
    public GameObject DangerousBorder;

    public Object SpawnBorder { get; private set; }

    void OnTriggerEnter(Collider hit)
    {
       
        if (hit.gameObject.tag == GameManager.Constants.PlayerTag)
        {
            
            int randomSpawnPoint = Random.Range(0, PathSpawnPoints.Length);
            for (int i = 0; i < PathSpawnPoints.Length; i++)
            {

                if (i == randomSpawnPoint)
                    Instantiate(Path, PathSpawnPoints[i].position, PathSpawnPoints[i].rotation);
                else
                {

                    Vector3 rotation = PathSpawnPoints[i].rotation.eulerAngles;
                    rotation.y += 90;
                    Vector3 position = PathSpawnPoints[i].position;
                    position.y += positionY;
                    Instantiate(SpawnBorder, position, Quaternion.Euler(rotation));
                }
            }

        }
    }
}
