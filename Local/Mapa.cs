using rpgLocal;
using rpgItem;
using rpgZombie;
using rpgNpc;

namespace rpgMapa;

public class Mapa
{
    private List<Local> Locais {get; set;}

    public Mapa()
    {
        Locais = new List<Local>();

        CriarMapa();
    }

    private void CriarMapa()
    {
     //locais
        Local mercado = new Local("Mercado", "Um mercado todo bagunçado, aparentemente foi para onde muitas pessoas vieram no início do surto. Talvez você encontre coisas úteis aqui.");
        Local igreja = new Local("Igreja", "Uma igreja local, mas está toda ensanguentada e com as janelas quebradas. Deve ter sido um abrigo no início do surto.");
        Local casaAbandonada = new Local("Casa Abandonada", "Uma casa velha e quebrada, mas nas situações atuais, pode ser um bom abrigo. Ou não.");
        Local hospital = new Local("Hospital", "Um grande hospital que ajudou muitos feridos no início do surto e suportou por muito tempo. Mas até mesmo as coisas boas têm seu fim.");
        Local delegacia = new Local("Delegacia", "A delegacia municipal, parece relativamente segura, com as janelas blindadas e ainda intactas. Talvez você encontre armas e munição.");
        Local postoDeGasolina = new Local("Posto de Gasolina", "Um posto de galosina pequeno com uma lojinha de conveniencia. Tome cuidado por onde esbarra, pois há muitos carros abandonados e os alarmes podem soar.");
        Local escola = new Local("Escola", "Uma escola estudual, sempre vivída com crianças. Mas hoje, cos portões estão abertos e há diversos corpos no pátio. Talvez você encontre algum sobrevivente.");
        Local floresta = new Local("Floresta", "Uma grande floresta na extremidade da cidade. É uma boa rota de fuga, mas saiba onde você está, pois é fácil se perder.");
        Local biblioteca = new Local("Biblioteca", "A biblioteca central da cidade, com diversas enciclopédias. Talvez você descubra algo interessante nos livros.");
        Local laboratorio = new Local("Laboratório", "O laboratório federal, onde os principais estudos eram feitos. O que ele guarda pode mudar tudo.");   
    }
}