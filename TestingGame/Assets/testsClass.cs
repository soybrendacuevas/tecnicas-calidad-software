using Unity.Engine;

public class Personaje : MonoBehaviour 
{
    public string nombre;
    public int vida;
    private int energia;

    public void RecivirDano (int dano){
        vida -= dano;
        Debug.Log(nombre + " recivio " + dano + " puntos de daño. Vida restante: " + vida);
    }

    public int energia
    {
        get { return energia;}
        set { energia = Mathf.Clamp(value, 0, 100) }
    }

    public delegate void EventoMuerte();
    public event EventoMuerte AlMorir;

    void start()
    {
        Debug.Log(nombre + "ha iniciado con " + vida + " puntos de vida y " + energia + " puntos de energia");
    }

    void update()
    {
        if ( vida <= 0 && AlMorir!= null){
            AlMorir();
        }
    }
}