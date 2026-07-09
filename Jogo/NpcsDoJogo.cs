using rpgMissoesDoJogo;
using rpgNpc;

namespace rpgNpcsDoJogo;

public class NpcsDoJogo
{
    public static Npc CriaPolicial()
    {
        return new Npc("Ethan", 120, 120, 0, 40, 0, MissoesDoJogo.CriaMissaoPolicial());
    }
    public static Npc CriaCientista()
    {
        return new Npc("Freddie", 100, 100, 0, 20, 0, MissoesDoJogo.CriaMissaoCientista());
    }
    public static Npc CriaPadre()
    {
        return new Npc("John", 100, 100, 0, 10, 0, MissoesDoJogo.CriaMissaoPadre());
    }
    public static Npc CriaCachorro()
    {
        return new Npc("Billy", 40, 40, 0, 10, 0, null);
    }
    public static Npc CriaEnfermeira()
    {
        return new Npc("Grace", 100, 100, 0, 10, 0, MissoesDoJogo.CriaMissaoEnfermeira());
    } 
    public static Npc CriaProfessora()
    {
        return new Npc("Sarah", 100, 100, 0, 20, 0, MissoesDoJogo.CriaMissaoProfessora());
    }
    public static Npc CriaCrianca()
    {
        return new Npc("Mary", 60, 60, 0, 10, 0, null);
    }
}