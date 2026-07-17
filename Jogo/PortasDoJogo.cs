using rpgTipoChave;
using rpgPorta;

namespace rpgPortasDoJogo;

public class PortasDoJogo
{
    public static Porta CriarPortaSalaDeArmas()
    {
        return new Porta("Sala de armas", TipoChave.SalaDeArmas);
    }
    public static Porta CriarPortaSalaDeAula()
    {
        return new Porta("Sala de aula", TipoChave.SalaDeAula);
    }
    public static Porta CriarPortaSalaBiblioteca()
    {
        return new Porta("Sala da biblioteca", TipoChave.SalaBiblioteca);
    }
    public static Porta CriarPortaArmarioHospital()
    {
        return new Porta("Armário do hospital", TipoChave.ArmarioHospital);
    }
    public static Porta CriarPortaLaboratorio()
    {
        return new Porta("Laboratório", TipoChave.Laboratorio);
    }

}