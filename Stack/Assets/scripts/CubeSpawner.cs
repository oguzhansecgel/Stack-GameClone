using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeSpawner : MonoBehaviour
{
    [SerializeField]
    private Movingcubes cubePrefab;
    [SerializeField]
    private Direction movedirection; 
 
    public void SpawnCube()
    {
        var cube = Instantiate(cubePrefab);
        if(Movingcubes.LastCube != null && Movingcubes.LastCube.gameObject != GameObject.Find("Start"))
        {
            float x = movedirection == Direction.X ? transform.position.x : Movingcubes.LastCube.transform.position.x;
            float z = movedirection == Direction.z ? transform.position.z : Movingcubes.LastCube.transform.position.z;



            cube.transform.position = new Vector3(x,
            Movingcubes.LastCube.transform.position.y + cubePrefab.transform.localScale.y,
            z);
        }
        else
        {
            cube.transform.position = transform.position;
        }
        cube.Direction = movedirection;



    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, cubePrefab.transform.localScale);
    }
}
