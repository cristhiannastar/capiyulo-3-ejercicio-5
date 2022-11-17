namespace ejercicio35
{

    class requisitos
    {
        static void Main()
        {
            double factura;
            double descuento;
            int cantidadproduc;
            double precio;
            double preciobruto;
            double iva = 0.12;
            double ivacompra;

            Console.WriteLine("ingrese el precio del producto");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la cantidad que va a llevar");
            cantidadproduc = int.Parse(Console.ReadLine());

            ivacompra = (precio / cantidadproduc) * 0.12;

            Console.WriteLine("el iva da un valor de:" + ivacompra);

            preciobruto = (precio * cantidadproduc) + ivacompra;

            if (preciobruto > 50000)
            {


                descuento = preciobruto * 0.05;
                factura = preciobruto - descuento;



            }
            else
            {
                factura = preciobruto;
            }
            Console.WriteLine("el precio de la factura es:" + factura);
        }
    }
}