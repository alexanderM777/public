using pruebaHerencia;

empleadoXComision empleadoporcomision = new empleadoXComision("julieth", " Diaz",
    "222-22-2222", 06M, 10000.10M);
Console.WriteLine("{0} : {1} \n\n {2} \n{3}: {4}\n ",
                "LLama a  ToString de Empleado por comision con referencia de clase base ",
                "a objeto de la clase base", empleadoporcomision.ToString(),
                "ingresos", empleadoporcomision.ingresos());


empleadoBaseMasComision2 empleado = new ("MESSI ", " theGoat",
                                      "123-123-4423", .08M, 10065.00M, 300.00M);
Console.WriteLine("{0} : {1} \n\n {2} \n{3}: {4}\n ",
                "LLama a  ToString de Empleado base mas  comision con referencia de clase base ",
                "deriva a objeto de clase derivada ", empleado.ToString(),
                "ingresos", empleado.ingresos());

empleadoXComision empleadoXComision2 = empleado;

Console.WriteLine("{0} : {1} \n\n {2} \n{3}: {4}\n ",
                "LLama a  ToString de Empleado base mas  comision con referencia de clase base ",
                "deriva a objeto de clase derivada ", empleado.ToString(),
                "ingresos", empleado.ingresos());
