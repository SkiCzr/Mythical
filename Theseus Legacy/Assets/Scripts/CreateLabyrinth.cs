using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLabyrinth : MonoBehaviour
{
    public GameObject[] LabyrinthPart = new GameObject[15];
    public GameObject BossRoom;
    public GameObject Character;

    GameObject[] ChunksForBoss = new GameObject[20];
    GameObject CurentPart;
    GameObject PreviousPart;

    int LabyrinthParths = 0;
    int CurentPassage;
    int[] CurentPassageIndex = new int[11];
    int[] ChunksAreCreated = new int[11];
    int Passages = 0;
    void Start()
    {
        float xLength = LabyrinthPart[14].transform.localScale.x;

        ChunksForBoss[0] = Instantiate(LabyrinthPart[0], LabyrinthPart[0].transform.position, Quaternion.identity);
        CurentPassageIndex[0] = 0;
        CurentPart = ChunksForBoss[0];

        for (int i = 0; i < 11; i++)
            ChunksAreCreated[i] = 0;

        switch (Random.Range(1, 8))
        {
            case 1:
                ChunksForBoss[1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                CurentPassageIndex[1] = 5;
                break;
            case 2:
                ChunksForBoss[1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                CurentPassageIndex[1] = 7;
                break;
            case 3:
                ChunksForBoss[1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                CurentPassageIndex[1] = 8;
                break;
            case 4:
                ChunksForBoss[1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                CurentPassageIndex[1] = 11;
                Passages += 1;
                break;
            case 5:
                ChunksForBoss[1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                CurentPassageIndex[1] = 12;
                Passages += 1;
                break;
            case 6:
                ChunksForBoss[1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                CurentPassageIndex[1] = 13;
                Passages += 1;
                break;
            case 7:
                ChunksForBoss[1] = Instantiate(LabyrinthPart[14], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                CurentPassageIndex[1] = 14;
                Passages += 2;
                break;
        }
        LabyrinthParths += 1;
    }
    

    void CreateNewPart()
    {
        float xLength = LabyrinthPart[14].transform.localScale.x;
        float yLength = LabyrinthPart[14].transform.localScale.y;

        if (CurentPassage == 4)
        {
            if (CurentPart.transform.position.y - yLength == PreviousPart.transform.position.y)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity) ;
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 9))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity); ;
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                            case 5:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                            case 6:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                            case 7:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[14], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 14;
                                Passages += 2;
                                break;
                            case 8:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[2], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 2;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 8))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity); ;
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                            case 5:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                            case 6:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                            case 7:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[14], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 14;
                                Passages += 2;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 9))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity); ;
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                            case 5:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                            case 6:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                            case 7:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[14], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 14;
                                Passages += 2;
                                break;
                            case 8:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[3], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 3;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 8))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity); ;
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                            case 5:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                            case 6:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                            case 7:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[14], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - yLength, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 14;
                                Passages += 2;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
        }
        else if (CurentPassage == 5)
        {
            if ((CurentPart.transform.position.x - xLength) == PreviousPart.transform.position.x)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 9))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                            case 5:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                            case 6:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                            case 7:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[14], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 14;
                                Passages += 2;
                                break;
                            case 8:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[1], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 1;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 8))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                            case 5:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                            case 6:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                            case 7:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[14], new Vector3(CurentPart.transform.position.x + xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 14;
                                Passages += 2;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 9))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                            case 5:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                            case 6:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                            case 7:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[14], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 14;
                                Passages += 2;
                                break;
                            case 8:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[0], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 0;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 8))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                            case 5:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                            case 6:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                            case 7:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[14], new Vector3(CurentPart.transform.position.x - xLength, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 14;
                                Passages += 2;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
        }
        else if (CurentPassage == 6)
        {
            if (CurentPart.transform.position.y + yLength == PreviousPart.transform.position.y)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[1], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 1;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[2], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 2;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
        }
        else if (CurentPassage == 7)
        {
            if (CurentPart.transform.position.x - xLength == PreviousPart.transform.position.x)
            {
                if (LabyrinthParths == 10)
                {
                   Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[2], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 2;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[0], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 0;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
        }
        else if (CurentPassage == 8)
        {
            if (CurentPart.transform.position.x - xLength == PreviousPart.transform.position.x)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[3], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 3;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[0], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 0;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
        }
        else if (CurentPassage == 9)
        {
            if (CurentPart.transform.position.y - yLength == PreviousPart.transform.position.y)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[1], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 1;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[3], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 3;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
        }
        else if (CurentPassage == 10)
        {
            if (CurentPart.transform.position.y + yLength == PreviousPart.transform.position.y)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[1], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 1;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                       ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                       CurentPassageIndex[LabyrinthParths + 1] = 5;
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[3], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 3;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else if (CurentPart.transform.position.y - yLength == PreviousPart.transform.position.y)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[1], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 1;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 5;
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[2], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 2;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[2], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 2;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[3], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 3;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[11], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 11;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
        }
        else if (CurentPassage == 11)
        {
            if (CurentPart.transform.position.y + yLength == PreviousPart.transform.position.y)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[0], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 0;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 5;
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                   Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[3], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 3;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else if (CurentPart.transform.position.y - yLength == PreviousPart.transform.position.y)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[0], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 0;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 5;
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[2], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 2;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[2], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 2;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[3], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 3;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[10], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 10;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
        }
        else if (CurentPassage == 12)
        {
            if (CurentPart.transform.position.x - xLength == PreviousPart.transform.position.x)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[3], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 3;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 4;
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[1], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 1;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else if (CurentPart.transform.position.x + xLength == PreviousPart.transform.position.x)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[3], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 3;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 4;
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[0], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 0;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else
            {
                if (LabyrinthParths == 10)
                {
                   Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[0], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 0;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[6], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 6;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[1], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 1;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[7], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 7;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[13], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 13;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
        }
        else if (CurentPassage == 13)
        {
            if (CurentPart.transform.position.x - xLength == PreviousPart.transform.position.x)
            {
                if (LabyrinthParths == 10)
                {
                   Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[2], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 2;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 4;
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[1], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 1;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else if (CurentPart.transform.position.x + xLength == PreviousPart.transform.position.x)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[2], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 2;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 4;
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[0], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 0;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
            else
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[0], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 0;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[9], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 9;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 5))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                            case 4:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[1], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 1;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[8], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 8;
                                break;
                            case 3:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[12], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 12;
                                Passages += 1;
                                break;
                        }
                    }
                    LabyrinthParths += 1;
                }
            }
        }
        else if (CurentPassage == 14)
        {
            if (CurentPart.transform.position.x - xLength == PreviousPart.transform.position.x)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[2], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 2;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 4;
                    }
                    LabyrinthParths += 1;
                }


                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[1], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 1;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 5;
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[3], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 3;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 4;
                    }
                    LabyrinthParths += 1;
                }
            }

            else if (CurentPart.transform.position.x + xLength == PreviousPart.transform.position.x)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[2], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 2;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 4;
                    }
                    LabyrinthParths += 1;
                }


                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[0], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 0;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 5;
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[3], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 3;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 4;
                    }
                    LabyrinthParths += 1;
                }
            }
            else if (CurentPart.transform.position.y - yLength == PreviousPart.transform.position.y)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[2], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 2;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 4;
                    }
                    LabyrinthParths += 1;
                }


                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[1], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 1;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 5;
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[0], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 0;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 5;
                    }
                    LabyrinthParths += 1;
                }
            }

            if (CurentPart.transform.position.y + yLength == PreviousPart.transform.position.y)
            {
                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 4;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[3], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 3;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[4], new Vector3(CurentPart.transform.position.x, CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 4;
                    }
                    LabyrinthParths += 1;
                }


                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[1], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 1;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.y, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 5;
                    }
                    LabyrinthParths += 1;
                }

                if (LabyrinthParths == 10)
                {
                    Instantiate(BossRoom, new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                }
                else
                {
                    if (Passages > 0)
                    {
                        switch (Random.Range(1, 3))
                        {
                            case 1:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 5;
                                break;
                            case 2:
                                ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[0], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                                CurentPassageIndex[LabyrinthParths + 1] = 0;
                                Passages -= 1;
                                break;
                        }
                    }
                    else
                    {
                        ChunksForBoss[LabyrinthParths + 1] = Instantiate(LabyrinthPart[5], new Vector3(CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x, CurentPart.transform.position.y, CurentPart.transform.position.z), Quaternion.identity);
                        CurentPassageIndex[LabyrinthParths + 1] = 5;
                    }
                    LabyrinthParths += 1;
                }
            }
        }
    }
    

    private void Update()
    {
        if (!((Character.transform.position.x + Character.transform.localScale.x / 2 <= CurentPart.transform.position.x + LabyrinthPart[14].transform.localScale.x / 2 && Character.transform.position.x - Character.transform.localScale.x / 2 >= CurentPart.transform.position.x - LabyrinthPart[14].transform.localScale.x / 2) && (Character.transform.position.y - Character.transform.localScale.y <= CurentPart.transform.position.y + LabyrinthPart[14].transform.localScale.y / 2 && Character.transform.position.y - Character.transform.localScale.y >= CurentPart.transform.position.y - LabyrinthPart[14].transform.localScale.y / 2)))
        {
            for (int i = 0; i <= LabyrinthParths; i++)
            {
                if((Character.transform.position.x + Character.transform.localScale.x / 2 <= ChunksForBoss[i].transform.position.x + LabyrinthPart[14].transform.localScale.x / 2 && Character.transform.position.x - Character.transform.localScale.x / 2 >= ChunksForBoss[i].transform.position.x - LabyrinthPart[14].transform.localScale.x / 2) && (Character.transform.position.y - Character.transform.localScale.y <= ChunksForBoss[i].transform.position.y + LabyrinthPart[14].transform.localScale.y / 2 && Character.transform.position.y - Character.transform.localScale.y >= ChunksForBoss[i].transform.position.y - LabyrinthPart[14].transform.localScale.y / 2))
                {
                    PreviousPart = CurentPart;
                    CurentPart = ChunksForBoss[i];
                    if (ChunksAreCreated[i] == 0)
                    {
                        CurentPassage = CurentPassageIndex[i];
                        CreateNewPart();
                        ChunksAreCreated[i] = 1;
                    }
                }
            }
        }
    }
}
