using rpgMapa;
using rpgPortasDoJogo;
using rpgSala;

namespace rpgSalasDoJogo;

public class SalasDoJogo
{

    public static Sala criarSalaDeArmas(Mapa mapa)
    {
        return new Sala("Sala de armas", mapa.delegacia, PortasDoJogo.CriarPortaSalaDeArmas(mapa));
    }
    public static Sala criarSalaDeAula(Mapa mapa)
    {
        return new Sala("Sala de aula", mapa.escola, PortasDoJogo.CriarPortaSalaDeAula(mapa));
    }
    public static Sala criarSalaBiblioteca(Mapa mapa)
    {
        return new Sala("Sala da biblioteca", mapa.biblioteca, PortasDoJogo.CriarPortaSalaBiblioteca(mapa));
    }
    public static Sala criarSalaArmarioHospital(Mapa mapa)
    {
        return new Sala("Armário do hospital", mapa.delegacia, PortasDoJogo.CriarPortaArmarioHospital(mapa));
    }
    public static Sala criarSalaLaboratorio(Mapa mapa)
    {
        return new Sala("Laboratório", mapa.laboratorio, PortasDoJogo.CriarPortaLaboratorio(mapa));
    }
}