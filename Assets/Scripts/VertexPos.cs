using UnityEngine;

public class VertexPos
{
    public Vector3 position;
    public float originalY;
    public WaveType waveType;

    
    public Vector3 CalculateNewPosition(float amplitude = 1f, float waveLengthMult = 1f,float speed=0.5f,float YRange=50f)
    {
        float time = Time.realtimeSinceStartup;
        float newY = 0f;
        switch (waveType) 
        {
            case WaveType.Sine:
                newY = originalY + (amplitude * Mathf.Sin(position.x * waveLengthMult + time*speed ));
                break;
            case WaveType.Cosine:
                newY = originalY + (amplitude * Mathf.Cos(position.x * waveLengthMult + time*speed ));
                break;
            case WaveType.CosinePlusTan:
                newY = originalY + (amplitude *( Mathf.Cos(position.x * waveLengthMult + time * speed)+ Mathf.Tan(position.x * waveLengthMult + time * speed)));
                break;
            case WaveType.Tan:
                newY =Mathf.Clamp( originalY + (amplitude * Mathf.Tan(position.x * waveLengthMult + time * speed)),-YRange,YRange);
                break;
            case WaveType.SinPlusTan:
                newY = originalY + (amplitude * (Mathf.Sin(position.x * waveLengthMult + time * speed) + Mathf.Tan(position.x * waveLengthMult + time * speed)));
                break;

        }
        position.y = newY;
        return position;
    }
}
