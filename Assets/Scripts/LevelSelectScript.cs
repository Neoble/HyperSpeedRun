using UnityEngine;
using System.Collections;

public class LevelSelectScript : MonoBehaviour
{

    protected string currentLevel;
    protected int worldIndex;
    protected int levelIndex;

    void Start()
    {
        for (int i = 1; i <= LockLevel.worlds; i++)
        {
            if (Application.loadedLevelName == "World" + i)
            {
                worldIndex = i;
                CheckLockedLevels();
            }
        }
    }
    public void Selectlevel(string worldLevel)
    {
        Application.LoadLevel("Level" + worldLevel);
    }
    void CheckLockedLevels()
    {
        for (int j = 1; j < LockLevel.levels; j++)
        {
            levelIndex = (j + 1);
            if ((PlayerPrefs.GetInt("level" + worldIndex.ToString() + ":" + levelIndex.ToString())) == 1)
            {
                GameObject.Find("LockedLevel" + (j + 1)).active = false;
                Debug.Log("Unlocked");
            }
        }
    }
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "Goal")
    //    {
    //        UnlockLevels();        }
    //}

    //protected void UnlockLevels()
    //{
    //    //set the playerprefs value of next level to 1 to unlock
    //    for (int i = 0; i < LockLevel.worlds; i++)
    //    {
    //        for (int j = 1; j < LockLevel.levels; j++)
    //        {
    //            if (currentLevel == "Level" + (i + 1).ToString() + "." + j.ToString())
    //            {
    //                worldIndex = (i + 1);
    //                levelIndex = (j + 1);
    //                PlayerPrefs.SetInt("level" + worldIndex.ToString() + ":" + levelIndex.ToString(), 1);
    //            }
    //        }
    //    }
    //}
}