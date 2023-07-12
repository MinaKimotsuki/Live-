using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingCircleController : MonoBehaviour
{
    ParticleSystem[] particles;
    ArtCreator artCreator;

    // Start is called before the first frame update
    void Start()
    {
        artCreator = GameObject.Find("ArtCreator").GetComponent<ArtCreator>();

        particles = new ParticleSystem[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            particles[i] = transform.GetChild(i).GetComponent<ParticleSystem>();
        }

        artCreator.SetRandomPosition(gameObject);
        artCreator.SetColor(particles);
        MakeButtonPushTiming(particles[0]);
        particles[0].Play();
    }

    // Update is called once per frame
    void Update()
    {
        artCreator.DestroyItsself(particles, gameObject);
    }

    void MakeButtonPushTiming(ParticleSystem particle)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, 0);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.10f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = -0.5f;
        main.startSize = 0.1f;
        main.playOnAwake = false;
        main.maxParticles = 1000;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 200)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 1;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }
}
