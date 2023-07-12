using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleLineCircle1Controller : MonoBehaviour
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
        for (int i = 0; i < 20; i++)
        {
            MakeDoubleLineCircle1_1(particles[i], i);
            particles[i].Play();
        }
        for (int i = 20; i < 40; i++)
        {
            MakeDoubleLineCircle1_2(particles[i], i);
            particles[i].Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        artCreator.DestroyItsself(particles, gameObject);
    }

    void MakeDoubleLineCircle1_1(ParticleSystem particle, int i)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, 0);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.20f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = i * 0.025f + 1.5f;
        main.startSize = 0.1f;
        main.playOnAwake = false;
        main.maxParticles = 1000;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 8, 8, 1, 0.010f)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }

    void MakeDoubleLineCircle1_2(ParticleSystem particle, int i)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, 22.5f);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.20f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = (i - 20) * 0.0125f + 1.75f;
        main.startSize = 0.1f;
        main.playOnAwake = false;
        main.maxParticles = 1000;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 8, 8, 1, 0.010f)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }
}
