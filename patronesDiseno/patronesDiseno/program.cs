namespace patronesDiseno
{
    internal class program
    {
        static void Main(string[] args)
        {
            //singleton
            Console.WriteLine(singleton.Instance.mensaje);
            Console.ReadLine();

            //prototype
            Animal oAnimal = new Animal() { Nombre = "Oveja Dolly", Patas = 4 };
            Animal oAnimalClonado =  oAnimal.Clone() as Animal;
            oAnimalClonado.Patas = 5;

            Console.WriteLine(oAnimal.Patas);

            //FactoryMethod
            FactoryMethod.bebidaEmbriagante oBebida = FactoryMethod.creador.creadorBebida(FactoryMethod.creador.cerveza);
            Console.WriteLine(oBebida.CuantoEmbriagaPorHora);
            FactoryMethod.bebidaEmbriagante oBebida1 = FactoryMethod.creador.creadorBebida(FactoryMethod.creador.cerveza);
            Console.WriteLine(oBebida1.CuantoEmbriagaPorHora);

            //strategy
            Strategy.estrategiasBorrachoContexto oBorracho = new Strategy.estrategiasBorrachoContexto();
            oBorracho.conquistar();
            oBorracho.EstablecerConquistaCerveza();
            oBorracho.conquistar();

            //Mediator

            Mediator.Mediator mediador = new Mediator.Mediator();
            Mediator.IColleague oPepe = new Mediator.User(mediador);
            Mediator.IColleague oAdmin = new Mediator.UserAdmin(mediador);

            mediador.add(oPepe);
            mediador.add(oAdmin);

            oPepe.communicate("oye admin tengo un problema");
            oAdmin.communicate("Dime cual es el problema");

            //State
            ServidorContext oServior = new ServidorContext();
            oServior.State = new DisponibleServerState();

            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();

            //Composite
            Ingrediente oIngrediente1 = new Ingrediente("Harina", 100, 200, "gramos");
            Ingrediente oIngrediente2 = new Ingrediente("Leche", 20, 1, "litro");
            Ingrediente oIngrediente3 = new Ingrediente("Huevo", 20, 1, "kilo");

            PastelComposite oPastel = new PastelComposite("Pastel de leche");
            oPastel.Add(oIngrediente1);
            oPastel.Add(oIngrediente2);
            oPastel.Add(oIngrediente3);

            // Console.WriteLine(oPastel.Costo);

            Ingrediente oIngrediente4 = new Ingrediente("Chocolate", 200, 1, "litro");
            PastelComposite oPastelChocolateYLeche = new PastelComposite("Pastel compuesto");

            oPastelChocolateYLeche.Add(oIngrediente4);
            oPastelChocolateYLeche.Add(oPastel);

            Console.WriteLine(oPastelChocolateYLeche.CostoTotal);

            //Builder
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());

            //AbstractFactory
            new AbstractFactory.Client().Main();

        }
    }
}
