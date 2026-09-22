class Program
{
    static void Main()
 {
        
        Cachorro cachorro   = new Cachorro();
        cachorro.nome = "rex";
        Passaro  passaro = new Passaro();
        passaro.nome = "golinha";

        cachorro.FazerSom();
        cachorro.Mover();

        passaro.FazerSom();
        passaro.Mover();
 }



}






