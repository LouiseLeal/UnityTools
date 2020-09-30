using UnityEngine;
using UnityEditor;
using System.IO;

public class UnityInit : MonoBehaviour
{

    [MenuItem("UnityInit/Create Folders ")]

    static void CreateInitalFolders()
    {
        //Get the path of the Game data folder
        var m_Path = Application.dataPath;

        //Output the Game data path to the console
        var folder = Directory.CreateDirectory(m_Path+"/Scripts");
        Debug.Log("folder : " + folder.FullName);
        //Add .gitkeep to git track the empty folders
        var file = File.Create(folder.FullName+"/.gitkeep");

        folder = Directory.CreateDirectory(m_Path + "/Prefabs");
        Debug.Log("folder : " + folder.FullName);
        file = File.Create(folder.FullName + "/.gitkeep");

        folder = Directory.CreateDirectory(m_Path + "/Materials");
        Debug.Log("folder : " + folder.FullName);
        file = File.Create(folder.FullName + "/.gitkeep");

        folder = Directory.CreateDirectory(m_Path + "/Textures");
        Debug.Log("folder : " + folder.FullName);
        file = File.Create(folder.FullName + "/.gitkeep");

        folder = Directory.CreateDirectory(m_Path + "/Material");
        Debug.Log("folder : " + folder.FullName);
        file = File.Create(folder.FullName + "/.gitkeep");

        folder = Directory.CreateDirectory(m_Path + "/Plugins");
        Debug.Log("folder : " + folder.FullName);
        file = File.Create(folder.FullName + "/.gitkeep");
    }
}
