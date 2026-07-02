using rpgMissoesDoJogo;
using rpgNpc;

namespace rpgNpcsDoJogo;

public class NpcsDoJogo
{
    public static Npc CriaPolicial()
    {
        return new Npc("Ethan", MissoesDoJogo.CriaMissaoPolicial(), 120, 120, 0, 40);
    }
    public static Npc CriaCientista()
    {
        return new Npc("Freddie", MissoesDoJogo.CriaMissaoCientista(), 100, 100, 0, 20);
    }
    public static Npc CriaPadre()
    {
        return new Npc("John", MissoesDoJogo.CriaMissaoPadre(), 100, 100, 0, 10);
    }
    public static Npc CriaCachorro()
    {
        return new Npc("Billy", null, 40, 40, 0, 10);
    }
    public static Npc CriaEnfermeira()
    {
        return new Npc("Grace", MissoesDoJogo.CriaMissaoEnfermeira(), 100, 100, 0, 10);
    } 
    public static Npc CriaProfessora()
    {
        return new Npc("Sarah", MissoesDoJogo.CriaMissaoProfessora(), 100, 100, 0, 20);
    }
    public static Npc CriaCrianca()
    {
        return new Npc("Mary", null, 60, 60, 0, 10);
    }
}