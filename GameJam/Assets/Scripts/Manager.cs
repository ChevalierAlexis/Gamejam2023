using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Texture2D cursorTexture;
    public int CurrentWave;
    public int MaxWave;
    private int ennemiesnumber;
    public Spawner spawn1;
    public Spawner spawn2;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursorTexture,Vector2.zero,CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn1.ennemiesspawned+spawn2.ennemiesspawned>ennemiesnumber)
        {
            spawn1.ennemiesspawned = 0;
            spawn2.ennemiesspawned = 0;
            CurrentWave += 1;
            if (CurrentWave<MaxWave)
            {
                if (CurrentWave==5)
                {

                }
                ennemiesnumber += 5;
                spawn1.tempsRespawn = spawn1.tempsRespawn*0.95f;
                spawn2.tempsRespawn = spawn2.tempsRespawn*0.95f;
                spawn1.probaBouclier+=1;
                spawn1.probaMil+=1;
                spawn2.probaBouclier+=1;
                spawn2.probaMil+=1;
            }
        }
    }
}
