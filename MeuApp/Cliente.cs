namespace MeuApp;

class Cliente
{
    public int Id;

    public EEstadoCivil EstadoCivil;

    public Cliente(int id, EEstadoCivil estadoCivil)
    {
        Id = id;
        EstadoCivil = estadoCivil;
    }
}