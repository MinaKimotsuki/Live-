using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//çƒê∂èIÇÌÇ¡ÇΩÇÁè¡Ç∑

public class ArtCreator : MonoBehaviour
{
    [SerializeField] GameObject timing;
    [SerializeField] GameObject circle;
    [SerializeField] GameObject dotCircle;
    [SerializeField] GameObject lineCircle;
    [SerializeField] GameObject tireCircle;
    [SerializeField] GameObject fireWork;
    [SerializeField] GameObject dotedLineCircle;
    [SerializeField] GameObject lineRoundCircle;
    [SerializeField] GameObject curveRoundCircle;
    [SerializeField] GameObject jaggedCircle;
    [SerializeField] GameObject doubleLineCircle1;
    [SerializeField] GameObject doubleLineCircle2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        JudgeKey();
    }

    void JudgeKey()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(timing);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(circle);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(dotCircle);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(lineCircle);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(tireCircle);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Instantiate(fireWork);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            Instantiate(dotedLineCircle);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(lineRoundCircle);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            Instantiate(curveRoundCircle);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(jaggedCircle);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(doubleLineCircle1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(doubleLineCircle2);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.G))
        {

        }
        if (Input.GetKeyDown(KeyCode.H))
        {

        }
        if (Input.GetKeyDown(KeyCode.J))
        {

        }
        if (Input.GetKeyDown(KeyCode.K))
        {

        }
        if (Input.GetKeyDown(KeyCode.L))
        {

        }
    }

    public void SetRandomPosition(GameObject changePositionGameObject)
    {
        changePositionGameObject.transform.position = new Vector3(Random.Range(-8f, 8f), Random.Range(-5f, 5f), 0);
    }

    public void SetColor(ParticleSystem[] particles)
    {
        int red = Random.Range(0, 256);
        int green = Random.Range(0, 256);
        int blue = Random.Range(0, 256);
        foreach (ParticleSystem particle in particles)
        {
            var main = particle.main;
            main.startColor = new ParticleSystem.MinMaxGradient(new Color32((byte)red, (byte)green, (byte)blue, 255));
        }
    }

    public void DestroyItsself(ParticleSystem[] particles, GameObject destroyedObject)
    {
        if (particles[0].isPlaying) return;
        Destroy(destroyedObject);
    }
}
