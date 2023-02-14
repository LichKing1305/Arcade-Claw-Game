using System;                                   // System contains a lot of default C# libraries 
using GXPEngine;                                // GXPEngine contains the engine
using System.Drawing;                           // System.Drawing contains drawing tools such as Color definitions
using System.Collections.Generic;
public class MyGame : Game
{


    private string levelname = "Levels/Placeholder.tmx";


    public MyGame() : base(1440, 950, false)
    {
        LoadLevel(levelname);
    }


    void Update()
    {

    }

    static void Main()
    {
        new MyGame().Start();
    }

    public void LoadLevel(string name) // This functions destroys the previous level and creates the new level
    {
        List<GameObject> children = GetChildren();
        for (int i = children.Count - 1; i >= 0; i--)
        {
            children[i].Destroy();
        }
        AddChild(new Level(name));
        scale = 3.0f;


    }

}