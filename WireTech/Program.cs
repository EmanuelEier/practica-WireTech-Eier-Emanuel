using WireTechService;

Logica logica = new Logica();
logica.CargarProveedores();

Console.WriteLine("Ingrese servicio a utilizar:");
Console.WriteLine("1: Retirar saldo proveedor");
Console.WriteLine("2: Registrar transaccion");
Console.WriteLine("3: Agregar servicio");
Console.WriteLine("4: Agregar Proveedor");
Console.WriteLine("10: Salir");
int accion = int.Parse(Console.ReadLine());

while (accion != 10)
{
    switch (accion)
    {
        case 1:
            Console.WriteLine("Ingrese codigo de proveedor");
            int CodProv = int.Parse(Console.ReadLine());

            bool Estado = false;
            int Saldo;

            while (!Estado)
            {
                Console.WriteLine("Ingrese monto a retirar");
                int Monto = int.Parse(Console.ReadLine());

                Proveedor proveedor = new Proveedor();
                (Estado, Saldo) = logica.RetirarSaldoProveedor(Monto, CodProv);

                if (!Estado) Console.WriteLine("Saldo INSUFICIENTE, saldo: " + Saldo);
                else Console.WriteLine("Ok");
            }

            break;
        
        case 2:
            
            Console.WriteLine("Ingrese documento");
            int doc = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cod servicio");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese importe");
            int imp = int.Parse(Console.ReadLine());

            logica.NuevaTransaccion(doc, codigo,imp);
            break;
        
        case 3:
            
            Console.WriteLine("Ingrese nombre");
            string nom = Console.ReadLine();

            Console.WriteLine("Ingrese descripcion");
            string desc = Console.ReadLine();

            Console.WriteLine("Ingrese codigo de proveedor");
            int cod = int.Parse(Console.ReadLine());

            Console.WriteLine("Es un servicio electrico?");
            string tipo = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese zona:");
            Console.WriteLine("1 = Cuyo");
            Console.WriteLine("2 = Norte");
            Console.WriteLine("3 = Centro");
            Console.WriteLine("4 = Patagonia");
            int zona = int.Parse(Console.ReadLine());

            if (tipo == "S")
            {
                Console.WriteLine("Ingrese porcetaje de impuestos. Ej 50% = 0.5");
                double porc = double.Parse(Console.ReadLine());

                logica.CargarServicio(nom, desc, cod, zona, true, porc);


            } else
            {
                Comunicacion comunicacion = new Comunicacion();
                logica.CargarServicio(nom,desc,cod,zona,false,0);

            }

            break;

        case 4:

            Console.WriteLine("Ingrese nombre del proveedor");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese nombre del proveedor");
            string pais = Console.ReadLine();
            logica.CargarProveedor(nombre, pais);

            break;
    }

    Console.WriteLine("Ingrese servicio a utilizar:");
    Console.WriteLine("1: Retirar saldo Proveedor");
    Console.WriteLine("2: Registrar transaccion");
    Console.WriteLine("3: Agregar servicio");
    Console.WriteLine("10: Salir");
    accion = int.Parse(Console.ReadLine());
}

