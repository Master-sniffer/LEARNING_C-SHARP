using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour
{
    private CubePos nowCube = new CubePos(0, 1, 0);
    public float cubeChangePlaceSpeed = 0.5f;
    public Transform CubeToPlace;
    private float camMoveToPosition , camMoveSpeed=2f;

    public GameObject[] canvasStartPage;

    public GameObject CubeToCreate, AllCubes;
    private Rigidbody AllCubesRB;

    public Color[] bgcolor;
    private Color toCameraCaller;

    private bool IsLoos , FirstCube;

    private List<Vector3> allCubesPositions = new List<Vector3>
    {
        new Vector3(0,0,0),
        new Vector3(1,0,0),
        new Vector3(-1,0,0),
        new Vector3(0,0,1),
        new Vector3(0,0,-1),
        new Vector3(0,1,0),
        new Vector3(-1,0,-1),
        new Vector3(-1,0,1),
        new Vector3(1,0,-1),
        new Vector3(1,0,1)
    };

    private int prevCountMaxHorizontal;
    private Transform mainCam;
    private Coroutine showCubePlace;

    private void Start()
    {
        toCameraCaller = Camera.main.backgroundColor;
        mainCam = Camera.main.transform;
        camMoveToPosition = 4.51f + nowCube.y - 1f;

        AllCubesRB = AllCubes.GetComponent<Rigidbody>();
        showCubePlace = StartCoroutine(ShowCubePlace());
    }

    private void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.touchCount>0) && CubeToPlace!=null && AllCubes!=null  && !EventSystem.current.IsPointerOverGameObject() )
        {
#if !UNITY_EDITOR
            if (Input.GetTouch(0).phase != TouchPhase.Began)
                return;
#endif

            if (!FirstCube)
            {
                FirstCube = true;
                foreach (GameObject obj in canvasStartPage)
                    Destroy(obj);
            }

            GameObject newCube = Instantiate(CubeToCreate, CubeToPlace.position, Quaternion.identity) as GameObject;

            newCube.transform.SetParent(AllCubes.transform);
            nowCube.SetVector(CubeToPlace.position);
            allCubesPositions.Add(nowCube.GetVector());

            AllCubesRB.isKinematic = true;
            AllCubesRB.isKinematic = false;

            SpawnPositions();
            MoveCameraBG();
        }

        if (!IsLoos && AllCubesRB.velocity.magnitude > 0.1f )
        {
            Destroy(CubeToPlace.gameObject);
            IsLoos = true;
            StopCoroutine(showCubePlace);
        }
        mainCam.localPosition = Vector3.MoveTowards(mainCam.localPosition , (new Vector3(mainCam.localPosition.x, camMoveToPosition, mainCam.localPosition.z)), camMoveSpeed*Time.deltaTime  );

        if (Camera.main.backgroundColor != toCameraCaller)
            Camera.main.backgroundColor = Color.Lerp(Camera.main.backgroundColor, toCameraCaller, Time.deltaTime / 1.5f);
    }

    IEnumerator ShowCubePlace()
    {
        while (true)
        {
            SpawnPositions();

            yield return new WaitForSeconds(cubeChangePlaceSpeed);
        }

    }
    private void SpawnPositions()
    {
        List<Vector3> positions = new List<Vector3>();
        if (IsPositionEmpty(new Vector3(nowCube.x + 1, nowCube.y , nowCube.z)) && nowCube.x + 1!= CubeToPlace.position.x)
        {
            positions.Add(new Vector3(nowCube.x + 1, nowCube.y, nowCube.z));
        }
         if (IsPositionEmpty(new Vector3(nowCube.x - 1, nowCube.y, nowCube.z)) && nowCube.x - 1 != CubeToPlace.position.x)
        {
            positions.Add(new Vector3(nowCube.x -1 , nowCube.y , nowCube.z));
        }
         if (IsPositionEmpty(new Vector3(nowCube.x , nowCube.y - 1, nowCube.z)) && nowCube.y - 1 != CubeToPlace.position.y)
        {
            positions.Add(new Vector3(nowCube.x , nowCube.y - 1, nowCube.z));
        }
         if (IsPositionEmpty(new Vector3(nowCube.x , nowCube.y+1, nowCube.z)) && nowCube.y + 1 != CubeToPlace.position.y)
        {
            positions.Add(new Vector3(nowCube.x , nowCube.y + 1, nowCube.z));
        }
         if (IsPositionEmpty(new Vector3(nowCube.x , nowCube.y, nowCube.z - 1)) && nowCube.z - 1 != CubeToPlace.position.z)
        {
            positions.Add(new Vector3(nowCube.x , nowCube.y, nowCube.z - 1)); 
        }
         if (IsPositionEmpty(new Vector3(nowCube.x , nowCube.y, nowCube.z + 1)) && nowCube.z + 1 != CubeToPlace.position.z)
        {
            positions.Add(new Vector3(nowCube.x - 1, nowCube.y, nowCube.z + 1));
        }


        if (positions.Count > 1)
            CubeToPlace.position = positions[UnityEngine.Random.Range(0, positions.Count)];
        else if (positions.Count == 0)
        {
            IsLoos = true;
        }

        else
            CubeToPlace.position = positions[0];


    }
    private bool IsPositionEmpty(Vector3 Targerpos)
    {
        if (Targerpos.y == 0) return false;
        foreach (Vector3 pos in allCubesPositions)
        {
            if (pos.x == Targerpos.x && pos.y == Targerpos.y && pos.z == Targerpos.z) return false;
        }
        return true;
    }

    private void MoveCameraBG()
    {
        int maxX = 0, maxY = 0, maxZ = 0 , maxHor;

        foreach (Vector3 pos in allCubesPositions)
        {
            if (Mathf.Abs(Convert.ToInt32(pos.x)) > maxX)
                maxX = Convert.ToInt32(pos.x);

            if ((Convert.ToInt32(pos.y)) > maxY)
                maxY = Convert.ToInt32(pos.y);

            if (Mathf.Abs(Convert.ToInt32(pos.z)) > maxZ)
                maxZ = Convert.ToInt32(pos.z);
        }

        camMoveToPosition = 4.51f + nowCube.y - 1f;

        maxHor = maxX > maxZ ? maxX : maxZ; 
        if (maxHor % 3 == 0 && prevCountMaxHorizontal != maxHor)
        {
            mainCam.localPosition -= new Vector3(0, 0, -2.5f);
            prevCountMaxHorizontal = maxHor;
        }

        if (maxY >= 5)
        {
            toCameraCaller = bgcolor[0];
        }

        else if (maxY >= 2)
        {
            toCameraCaller = new Color(233/255 , 233/255 , 233/255);
        }

    }
}



struct CubePos
{
    public int x, y, z;

    public CubePos(int x,int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Vector3 GetVector()
    {
        return new Vector3(x,y,z);
    }

    public void SetVector(Vector3 pos)
    {
        x = Convert.ToInt32( pos.x);
        y = Convert.ToInt32(pos.y);
        z = Convert.ToInt32(pos.z);
    }
}
