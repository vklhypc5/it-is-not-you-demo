using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataSystem : MonoBehaviour
{
   
    public static void LevelComplete(int level)
    {
        Vector2Int btnpos = DataSystem.LevelToButtonPos(level);
        DataSystem.setkey(btnpos, 1);
        int up = DataSystem.ButtonPosToLevel(btnpos + new Vector2Int(1, 0));
        checkandset(up);
        int down = DataSystem.ButtonPosToLevel(btnpos + new Vector2Int(-1, 0));
        checkandset(down);
        int right = DataSystem.ButtonPosToLevel(btnpos + new Vector2Int(0, 1));
        checkandset(right);
        int left = DataSystem.ButtonPosToLevel(btnpos + new Vector2Int(0, -1));
        checkandset(left);
        //Debug.Log("levelcomplete");
    }
    public static void checkandset(int level)
    {
        if (getkey(level) == 0)
        {
            setkey(level, 2);
            Debug.Log("set level " + ":" + level);
        }
    }
    public static void setkey(Vector2Int BtnPos,int state)
    {
        string SceneKey = "level" + DataSystem.ButtonPosToLevel(BtnPos);
        PlayerPrefs.SetInt(SceneKey, state);
        Debug.Log("set level " + ":" + DataSystem.ButtonPosToLevel(BtnPos));
    }
    public static void setkey(int level, int state)
    {
        string SceneKey = "level" + level;
        PlayerPrefs.SetInt(SceneKey, state);
    }
    public static int getkey(int level)
    {
        string SceneKey = "level" + level;
        return PlayerPrefs.GetInt(SceneKey);
    }
    public static Vector2Int LevelToButtonPos(int level)
    {
        Vector2Int BtnPos = new Vector2Int();
        BtnPos.y = level / SpawnLevelSelectButton.ScenePerLine;
        BtnPos.x = level % SpawnLevelSelectButton.ScenePerLine;
        return BtnPos;
    }
    public static int ButtonPosToLevel(Vector2Int BtnPos)
    {
        return BtnPos.y * SpawnLevelSelectButton.ScenePerLine + BtnPos.x;
    }
}
