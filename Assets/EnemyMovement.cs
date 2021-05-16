using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] List<Waypoint> path;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine( FollowPath() );
        print("Hey I'm back at start!");
    }

    private IEnumerator FollowPath()
    {
        print("Starting patrol.");
        foreach (Waypoint w in path)
        {
            transform.position = new Vector3(w.transform.position.x, 4, w.transform.position.z);
            print("Visiting block: "+w.transform.position.x/10f+","+w.transform.position.z/10f);
            yield return new WaitForSeconds(1f);
        }
        print("Ending patrol");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
