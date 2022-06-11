using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    
    public int level;
    public Vector2Int pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         level = ButtonPosToLevel(pos);
        pos = LevelToButtonPos(level);
    }
    public  Vector2Int LevelToButtonPos(int level)
    {
        Vector2Int BtnPos = new Vector2Int();
        BtnPos.y = level / SpawnLevelSelectButton.ScenePerLine;
        BtnPos.x = level % SpawnLevelSelectButton.ScenePerLine;
        return BtnPos;
    }
    public  int ButtonPosToLevel(Vector2Int BtnPos)
    {
        return BtnPos.y * SpawnLevelSelectButton.ScenePerLine + BtnPos.x;
    }
}
