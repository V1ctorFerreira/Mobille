using System.IO;
using JetBrains.Annotations;

using UnityEngine;
public enum Tools
{
    None,Axe,Hoe,WateringCan
}
[System.Serializable]
public class PlayerToolSystem
{
    [SerializeField] float toolCooldonw;
    [SerializeField] Tools tollInHand;

    public PlayerToolSystem(float toolCooldonw)
    {
        this.toolCooldonw = toolCooldonw;
        this.tollInHand = Tools.None;
    }
}


[RequireComponent (typeof(Rigidbody2D),typeof(BoxCollider2D))]
public class PLayerMove : MonoBehaviour
{
    [SerializeField]PlayerToolSystem toolSystem = new PlayerToolSystem(0.5f);

    [SerializeField] Joystick joystick;
    Rigidbody2D rb;
    Vector2 movement;
    [SerializeField] float speed = 5;


 string savePath;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        savePath = Application.persistentDataPath + "/savefile.json";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Save(toolSystem);

        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerToolSystem temp = Load();
            if (temp != null)
                return;
            toolSystem = Load();
        }
        movement = joystick.Direction;

     
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = movement * speed;
    }
    public void Save(PlayerToolSystem data)
    {
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(savePath, json);
        print("Jogo Salvo!");
    }
    public PlayerToolSystem Load()
    {
        if (!File.Exists(savePath))
            return null;
        string json = File.ReadAllText(savePath);
        PlayerToolSystem playerToolSystem = JsonUtility.FromJson<PlayerToolSystem>(json);
        print("Jogo Carregado");
        return playerToolSystem;
        

        
    }
}
