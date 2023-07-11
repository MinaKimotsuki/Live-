using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//çƒê∂èIÇÌÇ¡ÇΩÇÁè¡Ç∑

public class ArtCreator : MonoBehaviour
{
    /*[SerializeField] GameObject particles;*/
    /*[SerializeField] ParticleSystem[] particle;*/
    /*bool isPlayLineRoundCircle = false;*/
    /*bool isPlayCurveRoundCircle = false;*/

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
        /*Turn();*/
    }

    void JudgeKey()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(timing);
            ParticleSystem[] particles = new ParticleSystem[timing.transform.childCount];
            for (int i = 0; i < timing.transform.childCount; i++)
            {
                particles[i] = timing.transform.GetChild(i).GetComponent<ParticleSystem>();
            }
            MakeButtonPushTiming(particles[0]);
            particles[0].Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(circle);
            ParticleSystem[] particles = new ParticleSystem[circle.transform.childCount];
            for (int i = 0; i < circle.transform.childCount; i++)
            {
                particles[i] = circle.transform.GetChild(i).GetComponent<ParticleSystem>();
            }
            MakeCircle(particles[0]);
            particles[0].Play();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(dotCircle);
            ParticleSystem[] particles = new ParticleSystem[dotCircle.transform.childCount];
            for (int i = 0; i < dotCircle.transform.childCount; i++)
            {
                particles[i] = dotCircle.transform.GetChild(i).GetComponent<ParticleSystem>();
            }
            MakeDotCircle(particles[0]);
            particles[0].Play();
        }
        /*if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(lineCircle);
            MakeLineCircle(particle[0]);
            particle[0].Play();
        }*/
        /*if (Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(tireCircle);
            MakeTireCircle(particle[0]);
            particle[0].Play();
        }*/
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Instantiate(fireWork);
            ParticleSystem[] particles = new ParticleSystem[fireWork.transform.childCount];
            for (int i = 0; i < fireWork.transform.childCount; i++)
            {
                particles[i] = fireWork.transform.GetChild(i).GetComponent<ParticleSystem>();
            }
            MakeFireWork(particles[0]);
            particles[0].Play();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            Instantiate(lineCircle);
            ParticleSystem[] particles = new ParticleSystem[lineCircle.transform.childCount];
            for (int i = 0; i < lineCircle.transform.childCount; i++)
            {
                particles[i] = lineCircle.transform.GetChild(i).GetComponent<ParticleSystem>();
            }
            for (int i = 0; i < 21; i++)
            {
                MakeLineCircle2(particles[i], i);
                particles[i].Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(tireCircle);
            ParticleSystem[] particles = new ParticleSystem[tireCircle.transform.childCount];
            for (int i = 0; i < tireCircle.transform.childCount; i++)
            {
                particles[i] = tireCircle.transform.GetChild(i).GetComponent<ParticleSystem>();
            }
            for (int i = 0; i < 21; i++)
            {
                MakeTireCircle2_1(particles[i], i);
                particles[i].Play();
            }
            MakeTireCircle2_2(particles[21]);
            particles[21].Play();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            Instantiate(dotedLineCircle);
            ParticleSystem[] particles = new ParticleSystem[dotedLineCircle.transform.childCount];
            for (int i = 0; i < dotedLineCircle.transform.childCount; i++)
            {
                particles[i] = dotedLineCircle.transform.GetChild(i).GetComponent<ParticleSystem>();
            }
            for (int i = 0; i < 50; i++)
            {
                MakeDotedLineCircle(particles[i], i);
                particles[i].Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(lineRoundCircle);
            ParticleSystem[] particles = new ParticleSystem[lineRoundCircle.transform.childCount];
            for (int i = 0; i < lineRoundCircle.transform.childCount; i++)
            {
                particles[i] = lineRoundCircle.transform.GetChild(i).GetComponent<ParticleSystem>();
            }
            for (int i = 0; i < 40; i++)
            {
                MakeLineRoundCircle(particles[i], i + 10);
                particles[i].Play();
            }
            /*isPlayLineRoundCircle = true;*/
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(curveRoundCircle);
            ParticleSystem[] particles = new ParticleSystem[curveRoundCircle.transform.childCount];
            for (int i = 0; i < curveRoundCircle.transform.childCount; i++)
            {
                particles[i] = curveRoundCircle.transform.GetChild(i).GetComponent<ParticleSystem>();
            }
            for (int i = 0; i < 35; i++)
            {
                MakeCurveRoundCircle(particles[i], i + 5);
                particles[i].Play();
            }
            /*isPlayCurveRoundCircle = true;*/
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(jaggedCircle);
            ParticleSystem[] particles = new ParticleSystem[jaggedCircle.transform.childCount];
            for (int i = 0; i < jaggedCircle.transform.childCount; i++)
            {
                particles[i] = jaggedCircle.transform.GetChild(i).GetComponent<ParticleSystem>();
            }
            for (int i = 0; i < 40; i++)
            {
                MakeJaggedCircle1_1(particles[i], i + 10);
                particles[i].Play();
            }
            for (int i = 40; i < 80; i++)
            {
                MakeJaggedCircle1_2(particles[i], i + 10);
                particles[i].Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(doubleLineCircle1);
            ParticleSystem[] particles = new ParticleSystem[doubleLineCircle1.transform.childCount];
            for (int i = 0; i < dotCircle.transform.childCount; i++)
            {
                particles[i] = doubleLineCircle1.transform.GetChild(i).GetComponent<ParticleSystem>();
            }
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
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(doubleLineCircle2);
            ParticleSystem[] particles = new ParticleSystem[doubleLineCircle2.transform.childCount];
            for (int i = 0; i < doubleLineCircle2.transform.childCount; i++)
            {
                particles[i] = doubleLineCircle2.transform.GetChild(i).GetComponent<ParticleSystem>();
            }
            for (int i = 0; i < 20; i++)
            {
                MakeDoubleLineCircle2_1(particles[i], i);
                particles[i].Play();
            }
            for (int i = 20; i < 40; i++)
            {
                MakeDoubleLineCircle2_2(particles[i], i);
                particles[i].Play();
            }
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

    /*void StopAllParticles()
    {
        for (int i = 0; i < particle.Length; i++)
        {
            particle[i].Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        }
        isPlayLineRoundCircle = false;
        isPlayCurveRoundCircle = false;
        particles.transform.rotation = Quaternion.identity;
    }*/

    /*void Turn()
    {
        if (isPlayLineRoundCircle == true)
        {
            for ()
            MoveLineRoundCircle();
        }
        if (isPlayCurveRoundCircle == true)
        {
            MoveCurveRoundCircle();
        }
    }*/

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

    void MakeCircle(ParticleSystem particle)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, 0);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.10f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = 2.0f;
        main.startSize = 0.1f;
        main.playOnAwake = false;
        main.maxParticles = 1000;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 1000)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }

    void MakeDotCircle(ParticleSystem particle)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, 0);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.10f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = 2.0f;
        main.startSize = 0.5f;
        main.playOnAwake = false;
        main.maxParticles = 12;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 12)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }

    void MakeLineCircle(ParticleSystem particle)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, 0);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.20f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = 2.0f;
        main.startSize = 0.1f;
        main.playOnAwake = false;
        main.maxParticles = 1000;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 8, 8, 20, 0.010f)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }

    void MakeLineCircle2(ParticleSystem particle, int i)
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

    void MakeTireCircle(ParticleSystem particle)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, 0);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 1.00f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = 2.0f;
        main.startSize = 0.1f;
        main.playOnAwake = false;
        main.maxParticles = 10000;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.000f, 8, 8, 20, 0.010f),
                new ParticleSystem.Burst(0.200f, 400, 400, 1, 0.010f),
                new ParticleSystem.Burst(0.200f, 8, 8, 20, 0.010f)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }

    void MakeTireCircle2_1(ParticleSystem particle, int i)
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
                new ParticleSystem.Burst(0.0f, 8)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }

    void MakeTireCircle2_2(ParticleSystem particle)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, 0);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.10f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = 1.75f;
        main.startSize = 0.1f;
        main.playOnAwake = false;
        main.maxParticles = 1000;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 1000)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }

    void MakeFireWork(ParticleSystem particle)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, 0);
        particle.transform.localScale = new Vector3(1, 1, 0);
        var main = particle.main;
        main.duration = 0.10f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = 2.0f;
        main.startSize = 0.5f;
        main.playOnAwake = false;
        main.maxParticles = 100;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 100)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Sphere;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
        /*var renderer = particle.gameObject.GetComponent<ParticleSystemRenderer>();
        renderer.renderMode = ParticleSystemRenderMode.HorizontalBillboard;*/
    }

    void MakeDotedLineCircle(ParticleSystem particle, int i)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, i * 0.4f);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.10f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = 2.0f;
        main.startSize = 0.1f;
        main.playOnAwake = false;
        main.maxParticles = 12;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 12)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }

    void MakeLineRoundCircle(ParticleSystem particle, int i)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, Mathf.Pow(i, 0.6f) * 1.5f);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.20f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = i * 0.01f + 1.5f;
        main.startSize = 0.1f;
        main.playOnAwake = false;
        main.maxParticles = 1000;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 12, 12, 1, 0.010f)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }

    void MakeCurveRoundCircle(ParticleSystem particle, int i)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, Mathf.Pow(i, 1.1f) * 0.2f);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.20f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = Mathf.Pow(i, 0.3f) * 0.3f + 1.5f;
        main.startSize = 0.1f;
        main.playOnAwake = false;
        main.maxParticles = 1000;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 12, 12, 1, 0.010f)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }

    void MakeJaggedCircle1_1(ParticleSystem particle, int i)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, Mathf.Pow(i, 0.6f) * 2.8f);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.20f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = i * 0.01f + 1.5f;
        main.startSize = 0.1f;
        main.playOnAwake = false;
        main.maxParticles = 1000;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 12, 12, 1, 0.010f)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
    }

    void MakeJaggedCircle1_2(ParticleSystem particle, int i)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, Mathf.Pow(i, 0.6f) * -2.8f + 10);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.20f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = (i - 40) * 0.01f + 1.5f;
        main.startSize = 0.1f;
        main.playOnAwake = false;
        main.maxParticles = 1000;
        var emission = particle.emission;
        emission.rateOverTime = 0;
        emission.SetBursts(new ParticleSystem.Burst[]
            {
                new ParticleSystem.Burst(0.0f, 12, 12, 1, 0.010f)
            });
        var shape = particle.shape;
        shape.shapeType = ParticleSystemShapeType.Circle;
        shape.radius = 0;
        shape.radiusThickness = 0;
        shape.arcMode = ParticleSystemShapeMultiModeValue.BurstSpread;
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

    void MakeDoubleLineCircle2_1(ParticleSystem particle, int i)
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

    void MakeDoubleLineCircle2_2(ParticleSystem particle, int i)
    {
        particle.transform.rotation = Quaternion.Euler(0, 0, 22.5f);
        particle.transform.localScale = new Vector3(1, 1, 1);
        var main = particle.main;
        main.duration = 0.20f;
        main.loop = false;
        main.startLifetime = 2.0f;
        main.startSpeed = (i - 20) * 0.0125f + 1.5f;
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
